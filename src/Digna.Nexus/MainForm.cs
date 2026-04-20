using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using SmartHomeSystem.Classes.Abstract;
using SmartHomeSystem.Classes.Devices;
using SmartHomeSystem.Classes.Managers;

namespace SmartHomeSystem
{
    public partial class MainForm : Form
    {
        private readonly SmartHomeManager _manager;
        private bool _isUpdatingUI = false;

        public MainForm()
        {
            InitializeComponent();
            dgvDevices.CurrentCellDirtyStateChanged += dgvDevices_CurrentCellDirtyStateChanged;
            dgvDevices.CellValueChanged += dgvDevices_CellValueChanged;
            dgvDevices.CellClick += dgvDevices_CellClick;

            _manager = new SmartHomeManager();
            SetupInitialUI();
            DisableAllSettings();
        }

        private void SetupInitialUI()
        {
            if (cmbDeviceType.Items.Count > 0)
                cmbDeviceType.SelectedIndex = 0;

            dgvDevices.AutoGenerateColumns = false;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevices.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            SetupGridColumns();

            // AutoSave aktifse cihazları yükle
            if (IsAutoSaveEnabled())
                _manager.LoadDevices();

            UpdateDashboard(true);
        }

        private bool IsAutoSaveEnabled()
        {
            try
            {
                if (!File.Exists(AppSettings.SettingsPath)) return false;
                string json = File.ReadAllText(AppSettings.SettingsPath);
                var settings = JsonConvert.DeserializeObject<AppSettings>(json);
                return settings?.AutoSaveEnabled ?? false;
            }
            catch { return false; }
        }

        private void SetupGridColumns()
        {
            dgvDevices.Columns.Clear();

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                ReadOnly = true,
                FillWeight = 25
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Device Name",
                DataPropertyName = "DeviceName",
                ReadOnly = true,
                FillWeight = 100
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Location",
                DataPropertyName = "Location",
                ReadOnly = true,
                FillWeight = 70
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Base (W)",
                DataPropertyName = "BaseWatt",
                ReadOnly = true,
                FillWeight = 55
            });

            dgvDevices.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Consumption (W)",
                DataPropertyName = "CurrentConsumption",
                ReadOnly = true,
                FillWeight = 70
            });

            dgvDevices.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Active",
                DataPropertyName = "IsActive",
                ReadOnly = false,
                FillWeight = 40
            });
        }

        private SmartDevice GetSelectedDevice()
        {
            if (dgvDevices.SelectedRows.Count == 0) return null;
            return dgvDevices.SelectedRows[0].DataBoundItem as SmartDevice;
        }

        private void DisableAllSettings()
        {
            grpLight.Visible = false;
            grpAC.Visible = false;
            grpCamera.Visible = false;
            grpSpeaker.Visible = false;

            if (btnTogglePower != null)
            {
                btnTogglePower.Enabled = false;
                btnTogglePower.Text = "TURN ON";
                btnTogglePower.BackColor = System.Drawing.Color.Gray;
            }
        }

        #region DASHBOARD
        private void UpdateDashboard(bool listChanged = false)
        {
            if (listChanged)
            {
                SmartDevice currentDevice = GetSelectedDevice();
                dgvDevices.DataSource = null;
                dgvDevices.DataSource = _manager.Devices;

                if (currentDevice != null)
                {
                    foreach (DataGridViewRow row in dgvDevices.Rows)
                    {
                        if (row.DataBoundItem == currentDevice)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                dgvDevices.Refresh();
            }

            rtbReports.Text = _manager.ShowAllDevices();
            lblTotalConsumption.Text = $"{_manager.CalculateTotalConsumption():N2} W";
        }
        #endregion

        #region DATAGRID FIX
        private void dgvDevices_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvDevices.IsCurrentCellDirty)
                dgvDevices.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvDevices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isUpdatingUI) return;
            if (e.RowIndex < 0) return;

            var col = dgvDevices.Columns[e.ColumnIndex];
            if (col.DataPropertyName == "IsActive")
            {
                var device = dgvDevices.Rows[e.RowIndex].DataBoundItem as SmartDevice;
                if (device != null)
                    UpdateSettingsPanel(device);
            }

            UpdateDashboard(false);
        }

        private void dgvDevices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var col = dgvDevices.Columns[e.ColumnIndex];
            if (col.DataPropertyName != "IsActive") return;

            var device = dgvDevices.Rows[e.RowIndex].DataBoundItem as SmartDevice;
            if (device == null) return;

            device.Toggle();
            UpdateDashboard(false);
            UpdateSettingsPanel(device);
        }
        #endregion

        #region ADD DEVICE
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            string name = txtDeviceName.Text;
            string location = txtLocation.Text;
            double watt = (double)numBaseWatt.Value;
            string type = cmbDeviceType.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Device name cannot be empty!");
                return;
            }

            SmartDevice newDevice = null;
            switch (type)
            {
                case "Smart Light": newDevice = new SmartLight(name, location, watt); break;
                case "Air Conditioner": newDevice = new AirConditioner(name, location, watt); break;
                case "Security Camera": newDevice = new SecurityCamera(name, location, watt); break;
                case "Smart Speaker": newDevice = new SmartSpeaker(name, location, watt, 50); break;
            }

            if (newDevice != null)
            {
                _manager.AddDevice(newDevice);
                UpdateDashboard(true);
                txtDeviceName.Clear();
                txtLocation.Clear();
                numBaseWatt.Value = 0;
            }
        }
        #endregion

        #region DEVICE SELECTION & POWER
        private void dgvDevices_SelectionChanged(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            if (dgvDevices.SelectedRows.Count == 0) { DisableAllSettings(); return; }
            var device = GetSelectedDevice();
            if (device != null) UpdateSettingsPanel(device);
        }

        private void btnTogglePower_Click(object sender, EventArgs e)
        {
            var device = GetSelectedDevice();
            if (device == null) return;
            device.Toggle();
            UpdateDashboard(false);
            UpdateSettingsPanel(device);
        }

        private void UpdateSettingsPanel(SmartDevice device)
        {
            _isUpdatingUI = true;
            DisableAllSettings();

            if (btnTogglePower != null)
            {
                btnTogglePower.Enabled = true;
                btnTogglePower.Text = device.IsActive ? "TURN OFF" : "TURN ON";
                btnTogglePower.BackColor = device.IsActive
                    ? System.Drawing.Color.DarkRed
                    : System.Drawing.Color.FromArgb(0, 120, 215);
            }

            if (device is SmartLight light)
            {
                grpLight.Visible = true;
                trkBrightness.Value = light.Brightness;
            }
            else if (device is AirConditioner ac)
            {
                grpAC.Visible = true;
                rbCool.Checked = ac.Mode == ACMode.Cooling;
                rbHeat.Checked = ac.Mode == ACMode.Heating;
                numTargetTemp.Value = ac.TargetTemperature;
            }
            else if (device is SecurityCamera cam)
            {
                grpCamera.Visible = true;
                chkNightVision.Checked = cam.IsNightVisionActive;
                chkRecording.Checked = cam.IsRecording;
            }
            else if (device is SmartSpeaker spk)
            {
                grpSpeaker.Visible = true;
                trkVolume.Value = spk.Volume;
            }

            _isUpdatingUI = false;
        }
        #endregion

        #region REMOVE DEVICE
        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            var device = GetSelectedDevice();
            if (device == null) return;

            var result = MessageBox.Show(
                $"Are you sure you want to remove \"{device.DeviceName}\"?",
                "Remove Device", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _manager.RemoveDevice(device);
                _isUpdatingUI = true;
                DisableAllSettings();
                dgvDevices.DataSource = null;
                dgvDevices.DataSource = _manager.Devices;
                _isUpdatingUI = false;
                rtbReports.Text = _manager.ShowAllDevices();
                lblTotalConsumption.Text = $"{_manager.CalculateTotalConsumption():N2} W";
            }
        }
        #endregion

        #region MENU
        private void menuSettings_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                settingsForm.ShowDialog(this);
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region APPLICATION LIFECYCLE
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (IsAutoSaveEnabled())
                _manager.SaveDevices();
        }
        #endregion

        #region SETTINGS EVENTS
        private void trkBrightness_Scroll(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var light = GetSelectedDevice() as SmartLight;
            if (light == null) return;
            light.Brightness = trkBrightness.Value;
            UpdateDashboard(false);
        }

        private void trkVolume_Scroll(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var spk = GetSelectedDevice() as SmartSpeaker;
            if (spk == null) return;
            spk.Volume = trkVolume.Value;
            UpdateDashboard(false);
        }

        private void rbCool_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var ac = GetSelectedDevice() as AirConditioner;
            if (ac == null || !rbCool.Checked) return;
            ac.Mode = ACMode.Cooling;
            UpdateDashboard(false);
        }

        private void rbHeat_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var ac = GetSelectedDevice() as AirConditioner;
            if (ac == null || !rbHeat.Checked) return;
            ac.Mode = ACMode.Heating;
            UpdateDashboard(false);
        }

        private void chkNightVision_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var cam = GetSelectedDevice() as SecurityCamera;
            if (cam == null) return;
            cam.IsNightVisionActive = chkNightVision.Checked;
            UpdateDashboard(false);
        }

        private void chkRecording_CheckedChanged(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var cam = GetSelectedDevice() as SecurityCamera;
            if (cam == null) return;
            cam.IsRecording = chkRecording.Checked;
            UpdateDashboard(false);
        }

        private void numTargetTemp_ValueChanged(object sender, EventArgs e)
        {
            if (_isUpdatingUI) return;
            var ac = GetSelectedDevice() as AirConditioner;
            if (ac == null) return;
            ac.TargetTemperature = (int)numTargetTemp.Value;
            UpdateDashboard(false);
        }
        #endregion
    }
}