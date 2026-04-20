using System;
using SmartHomeSystem.Classes.Devices;
using SmartHomeSystem.Classes.Managers;

namespace SmartHomeSystem.Classes.Tester
{
    public class ConsoleTester
    {
        /// <summary>
        /// Orchestrator method to run all test modules with location-aware logic.
        /// </summary>
        public static void TestRun()
        {
            Console.Clear();
            Console.WriteLine("====================================================");
            Console.WriteLine("   SMART HOME SYSTEM - DEEP ANALYSIS TEST SUITE     ");
            Console.WriteLine("   (v2.3 - Location & UI Ready Edition)             ");
            Console.WriteLine("====================================================\n");

            // Module 1: SUCCESSFUL OPERATIONS
            RunSuccessScenarios();

            Console.WriteLine("\n" + new string('=', 55) + "\n");

            // Module 2: NEGATIVE TESTS
            RunNegativeScenarios();

            Console.WriteLine("\n" + new string('=', 55) + "\n");

            // Module 3: MIXED SCENARIOS
            RunMixedScenarios();

            Console.WriteLine("\n====================================================");
            Console.WriteLine(" ALL TEST MODULES COMPLETED. PRESS ENTER TO EXIT. ");
            Console.WriteLine("====================================================");
            Console.ReadLine();
        }

        private static void RunSuccessScenarios()
        {
            Console.WriteLine("[MODULE 1: SUCCESS SCENARIOS - STEP BY STEP]");
            SmartHomeManager homeManager = new SmartHomeManager();

            // 1. Setup with Locations
            Console.WriteLine("Step 1: Initializing devices with specific locations...");
            SmartLight livingRoomLight = new SmartLight("Living Room Light", "Living Room", 60);
            AirConditioner bedroomAC = new AirConditioner("Bedroom AC", "Master Bedroom", 1000);
            SecurityCamera backyardCamera = new SecurityCamera("Backyard Camera", "Garden", 15);
            SmartSpeaker kitchenSpeaker = new SmartSpeaker("Kitchen Speaker", "Kitchen", 50, 0);

            // 2. Addition
            Console.WriteLine("Step 2: Adding devices to Manager...");
            Console.WriteLine(" - " + homeManager.AddDevice(livingRoomLight));
            Console.WriteLine(" - " + homeManager.AddDevice(bedroomAC));
            Console.WriteLine(" - " + homeManager.AddDevice(backyardCamera));
            Console.WriteLine(" - " + homeManager.AddDevice(kitchenSpeaker));

            // 3. Configuration
            Console.WriteLine("\nStep 3: Configuring device states...");
            livingRoomLight.TurnOn(80);
            bedroomAC.TurnOn(24, ACMode.Heating);
            backyardCamera.TurnOn(Resolution.UHD_4K, nightVision: true, isRecording: true);
            kitchenSpeaker.TurnOn(70);
            Console.WriteLine(" >>> Configuration applied.");

            // 4. Detailed Report (Using new timestamped output)
            Console.WriteLine("\nStep 4: Full System Status Report:");
            Console.WriteLine(homeManager.ShowAllDevices());

            // 5. Dynamic Change
            Console.WriteLine("\nStep 5: Action - Removing 'Living Room Light'...");
            Console.WriteLine(" >>> Result: " + homeManager.RemoveDevice(livingRoomLight));

            // 6. Final Validation
            Console.WriteLine("\nStep 6: Final Validation Report:");
            Console.WriteLine(homeManager.ShowAllDevices());
        }

        private static void RunNegativeScenarios()
        {
            Console.WriteLine("[MODULE 2: NEGATIVE & STRESS SCENARIOS]");
            SmartHomeManager stressManager = new SmartHomeManager();

            Console.WriteLine("Action 1: Empty System Report Check");
            Console.WriteLine(" >>> Result: " + stressManager.ShowAllDevices());

            Console.WriteLine("\nAction 2: Attempting to Add NULL Device");
            Console.WriteLine(" >>> Result: " + stressManager.AddDevice(null));

            Console.WriteLine("\nAction 3: Attempting to Remove NULL Reference");
            Console.WriteLine(" >>> Result: " + stressManager.RemoveDevice(null));

            Console.WriteLine("\nAction 4: Attempting to Remove Unregistered Device (Ghost)");
            // Lokasyon parametresi buraya da eklendi
            SmartLight ghost = new SmartLight("Ghost", "Void", 100);
            Console.WriteLine(" >>> Result: " + stressManager.RemoveDevice(ghost));
        }

        private static void RunMixedScenarios()
        {
            Console.WriteLine("[MODULE 3: MIXED REAL-WORLD SCENARIOS]");
            SmartHomeManager mixedManager = new SmartHomeManager();

            // 1. Valid Add
            Console.WriteLine("1. Valid Add: Adding 'Smart Coffee Machine' to Kitchen...");
            SmartLight coffeeMachine = new SmartLight("Smart Coffee Machine", "Kitchen", 1500);
            Console.WriteLine("   Output: " + mixedManager.AddDevice(coffeeMachine));

            // 2. Invalid Add
            Console.WriteLine("\n2. Invalid Add: Attempting Null Injection...");
            Console.WriteLine("   Output: " + mixedManager.AddDevice(null));

            // 3. Valid State Change
            Console.WriteLine("\n3. Valid State Change: Turning ON Coffee Machine...");
            coffeeMachine.TurnOn(100);

            // 4. Invalid Remove
            Console.WriteLine("\n4. Invalid Remove: Attempting to remove non-existent 'Fake Toaster'...");
            SmartLight fakeToaster = new SmartLight("Fake Toaster", "Kitchen", 500);
            Console.WriteLine("   Output: " + mixedManager.RemoveDevice(fakeToaster));

            // 5. Valid Remove
            Console.WriteLine("\n5. Valid Remove: Removing Coffee Machine...");
            Console.WriteLine("   Output: " + mixedManager.RemoveDevice(coffeeMachine));

            // 6. Invalid Remove (Double Removal)
            Console.WriteLine("\n6. Invalid Remove: Attempting DOUBLE REMOVAL of Coffee Machine...");
            Console.WriteLine("   Output: " + mixedManager.RemoveDevice(coffeeMachine));

            // Final check
            Console.WriteLine("\n7. Final Stability Check - System Report:");
            Console.WriteLine(mixedManager.ShowAllDevices());
        }
    }
}