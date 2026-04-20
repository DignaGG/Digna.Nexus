# Digna.Nexus
![C#](https://img.shields.io/badge/csharp-C%23-blue)
![.NET](https://img.shields.io/badge/.NET-4.8-purple)
![Platform](https://img.shields.io/badge/platform-Windows-lightgrey)
![License](https://img.shields.io/badge/license-MIT-green)

**Digna.Nexus** is a Windows Forms desktop application for managing and monitoring smart home devices. It provides a structured OOP architecture with real-time power consumption tracking, device lifecycle management, and JSON-based persistence.

## 🏗 Architectural Philosophy
Digna.Nexus is engineered with a **"Structure-First"** mindset, adhering to rigorous object-oriented design principles:
- **Polymorphic Device Model:** All device types (`SmartLight`, `AirConditioner`, `SecurityCamera`, `SmartSpeaker`) derive from an abstract `SmartDevice` base class, enabling polymorphic consumption calculations and unified state management.
- **Separation of Concerns:** Business logic (`SmartHomeManager`), UI (`MainForm`), and persistence (`AppSettings`) are fully decoupled, each operating within its own responsibility boundary.
- **Context-Aware UI:** The settings panel dynamically renders only the controls relevant to the selected device type, eliminating visual noise and ensuring a clean user experience.
- **JSON Persistence Layer:** Device state and application settings are serialized via `Newtonsoft.Json` with `TypeNameHandling.All`, enabling full polymorphic round-trip serialization without data loss.

## 🚀 Features & Modules

### SmartDevice Hierarchy
- [x] `SmartDevice` *(Abstract Base)*: Encapsulates shared state (`DeviceName`, `Location`, `BaseWatt`, `IsActive`), overloaded `UpdateSettings()` methods, and virtual `CalculateCurrentConsumption()`.
- [x] `SmartLight`: Brightness-scaled consumption model — `BaseWatt × (Brightness / 100)`.
- [x] `AirConditioner`: Mode-aware consumption with 1.2× multiplier in Heating mode. UI-configurable target temperature (16–30°C).
- [x] `SecurityCamera`: Cumulative multiplier model — Recording (+20%), Night Vision (+25%).
- [x] `SmartSpeaker`: Quadratic consumption curve — `BaseWatt × (Volume / 100)²`.

### Core Systems
- [x] `SmartHomeManager`: Central device registry with `AddDevice()`, `RemoveDevice()`, `CalculateTotalConsumption()`, `SaveDevices()`, and `LoadDevices()`.
- [x] `MainForm`: Full-featured WinForms dashboard with DataGridView binding, context-aware GroupBox panels, and real-time status reporting.
- [x] `SettingsForm`: Application preferences dialog with auto-save toggle.
- [x] `AppSettings`: Unified path management and data folder initialization.

## 💻 Installation & Usage
1. Clone the repository:
```bash
   git clone https://github.com/DignaGG/Digna.Nexus.git
```
2. Open `Digna.Nexus.slnx` in Visual Studio 2026.
3. Restore NuGet packages (Newtonsoft.Json 13.0.4).
4. Build and run (`F5`).

> **Note:** On first run, a `data/` folder is created next to the executable. This folder contains `devices.json` and `settings.json` and is excluded from version control.

## 🔌 Supported Device Types
| Device | Key Property | Consumption Model |
|---|---|---|
| Smart Light | Brightness (0–100%) | Linear |
| Air Conditioner | Temperature (16–30°C), Mode | Mode-multiplied |
| Security Camera | Resolution, Night Vision, Recording | Cumulative multiplier |
| Smart Speaker | Volume (0–100%) | Quadratic |

## ✍️ Author & Documentation Notes
**Author:** DignaGG (DignaSoftware)

**Design & Translation Note:** The core architecture, algorithms, and system logic of this application are natively designed and developed in Turkish. To comply with international open-source coding standards, the code comments, XML documentation, and this README were translated into English with AI assistance. The primary engineering focus remains strictly on object-oriented design principles, UI/UX quality, and system stability.

License: This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
