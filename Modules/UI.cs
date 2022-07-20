using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dinkum.Modules
{
    class UI
    {
        public static string eLocate = "Tent";
        public static string tLocate = "Tent";
        public static string m_title;
        public static float dist = (float)NewChunkLoader.loader.getChunkDistance();
        public static string dbg;
        public static void menu()
        {
            if (Modules.UI_Vars.t_MENU) //Main Menu
            {
                float baseX = 200f;

                GUI.Box(new Rect(baseX + 5f, 5f, 300f, 120f), "");
                GUI.Label(new Rect(baseX + 10f, 5f, 250f, 30f), m_title);

                Modules.UI_Vars.UIToggleESPMenu = GUI.Toggle(new Rect(baseX + 10f, 32f, 106f, 15f), Modules.UI_Vars.UI_t_ESPm, "ESP Menu");
                if (Modules.UI_Vars.UIToggleESPMenu != Modules.UI_Vars.UI_t_ESPm)
                {
                    Modules.UI_Vars.UI_t_ESPm = !Modules.UI_Vars.UI_t_ESPm;
                    toggleHelper("ESP");
                }

                Modules.UI_Vars.UITogglePlayerMenu = GUI.Toggle(new Rect(baseX + 10f, 52f, 106f, 17f), Modules.UI_Vars.UI_t_Playerm, "Player Manager");
                if (Modules.UI_Vars.UITogglePlayerMenu != Modules.UI_Vars.UI_t_Playerm)
                {
                    Modules.UI_Vars.UI_t_Playerm = !Modules.UI_Vars.UI_t_Playerm;
                    toggleHelper("Player Manager");
                }

                Modules.UI_Vars.UIToggleAnimalMenu = GUI.Toggle(new Rect(baseX + 146f, 52f, 113f, 15f), Modules.UI_Vars.UI_t_Animalm, "Animal Manager");
                if (Modules.UI_Vars.UIToggleAnimalMenu != Modules.UI_Vars.UI_t_Animalm)
                {
                    Modules.UI_Vars.UI_t_Animalm = !Modules.UI_Vars.UI_t_Animalm;
                    toggleHelper("Animal Manager");
                }

                Modules.UI_Vars.UIToggleTownMenu = GUI.Toggle(new Rect(baseX + 10f, 72f, 106f, 15f), Modules.UI_Vars.UI_t_Townm, "Town Manager");
                if (Modules.UI_Vars.UIToggleTownMenu != Modules.UI_Vars.UI_t_Townm)
                {
                    Modules.UI_Vars.UI_t_Townm = !Modules.UI_Vars.UI_t_Townm;
                    toggleHelper("Town Manager");
                }

                Modules.UI_Vars.UIToggleWorldMenu = GUI.Toggle(new Rect(baseX + 146f, 72f, 113f, 15f), Modules.UI_Vars.UI_t_Worldm, "World Manager");
                if (Modules.UI_Vars.UIToggleWorldMenu != Modules.UI_Vars.UI_t_Worldm)
                {
                    Modules.UI_Vars.UI_t_Worldm = !Modules.UI_Vars.UI_t_Worldm;
                    toggleHelper("World Manager");
                }

                Modules.UI_Vars.UIToggleMiscMenu = GUI.Toggle(new Rect(baseX + 10f, 92f, 106f, 15f), Modules.UI_Vars.UI_t_Miscm, "Misc");
                if (Modules.UI_Vars.UIToggleMiscMenu != Modules.UI_Vars.UI_t_Miscm)
                {
                    Modules.UI_Vars.UI_t_Miscm = !Modules.UI_Vars.UI_t_Miscm;
                    toggleHelper("Misc");
                }
                GUI.Label(new Rect(baseX + 10f, 110f, (float)Screen.width, 30f), dbg);


                if (Modules.UI_Vars.UI_t_ESPm) //ESP Menu
                {
                    float EbaseX = baseX + 305f;

                    GUI.Box(new Rect(EbaseX + 5f, 5f, 300f, 130f), "");

                    Modules.UI_Vars.UIToggleESPAnimals = GUI.Toggle(new Rect(EbaseX + 10f, 10f, 125f, 15f), Modules.UI_Vars.UI_t_ESPAnimals, "Animals");
                    if (Modules.UI_Vars.UIToggleESPAnimals != Modules.UI_Vars.UI_t_ESPAnimals)
                    {
                        Modules.UI_Vars.UI_t_ESPAnimals = !Modules.UI_Vars.UI_t_ESPAnimals;
                    }

                    Modules.UI_Vars.UIToggleESPPlayers = GUI.Toggle(new Rect(EbaseX + 10f, 30f, 125f, 15f), Modules.UI_Vars.UI_t_ESPPlayers, "Players");
                    if (Modules.UI_Vars.UIToggleESPPlayers != Modules.UI_Vars.UI_t_ESPPlayers)
                    {
                        Modules.UI_Vars.UI_t_ESPPlayers = !Modules.UI_Vars.UI_t_ESPPlayers;
                    }

                    Modules.UI_Vars.UIToggleESPNPCs = GUI.Toggle(new Rect(EbaseX + 10f, 50f, 125f, 15f), Modules.UI_Vars.UI_t_ESPNPCs, "NPCs");
                    if (Modules.UI_Vars.UIToggleESPNPCs != Modules.UI_Vars.UI_t_ESPNPCs)
                    {
                        Modules.UI_Vars.UI_t_ESPNPCs = !Modules.UI_Vars.UI_t_ESPNPCs;
                    }

                    Modules.UI_Vars.UIToggleESPLocatorMenu = GUI.Toggle(new Rect(EbaseX + 150f, 50f, 125f, 15f), Modules.UI_Vars.UI_t_ESPLocatorMenu, "Locator");
                    if (Modules.UI_Vars.UIToggleESPLocatorMenu != Modules.UI_Vars.UI_t_ESPLocatorMenu)
                    {
                        Modules.UI_Vars.UI_t_ESPLocatorMenu = !Modules.UI_Vars.UI_t_ESPLocatorMenu;
                    }

                    Modules.UI_Vars.UIToggleESPTrees = GUI.Toggle(new Rect(EbaseX + 150f, 10f, 125f, 15f), Modules.UI_Vars.UI_t_ESPTrees, "Trees");
                    if (Modules.UI_Vars.UIToggleESPTrees != Modules.UI_Vars.UI_t_ESPTrees)
                    {
                        Modules.UI_Vars.UI_t_ESPTrees = !Modules.UI_Vars.UI_t_ESPTrees;
                    }

                    Modules.UI_Vars.UIToggleESPBuried = GUI.Toggle(new Rect(EbaseX + 150f, 30f, 125f, 15f), Modules.UI_Vars.UI_t_ESPBuried, "Buried Items");
                    if (Modules.UI_Vars.UIToggleESPBuried != Modules.UI_Vars.UI_t_ESPBuried)
                    {
                        Modules.UI_Vars.UI_t_ESPBuried = !Modules.UI_Vars.UI_t_ESPBuried;
                    }

                    Modules.UI_Vars.UIToggleESPLabels = GUI.Toggle(new Rect(EbaseX + 10f, 80f, 125f, 15f), Modules.UI_Vars.UI_t_ESPLabels, "Draw Labels");
                    if (Modules.UI_Vars.UIToggleESPLabels != Modules.UI_Vars.UI_t_ESPLabels)
                    {
                        Modules.UI_Vars.UI_t_ESPLabels = !Modules.UI_Vars.UI_t_ESPLabels;
                    }

                    Modules.UI_Vars.UIToggleESPLines = GUI.Toggle(new Rect(EbaseX + 10f, 100f, 125f, 15f), Modules.UI_Vars.UI_t_ESPLines, "Draw Lines");
                    if (Modules.UI_Vars.UIToggleESPLines != Modules.UI_Vars.UI_t_ESPLines)
                    {
                        Modules.UI_Vars.UI_t_ESPLines = !Modules.UI_Vars.UI_t_ESPLines;
                    }

                    Modules.UI_Vars.UIToggleESPBoxes = GUI.Toggle(new Rect(EbaseX + 150f, 80f, 125f, 15f), Modules.UI_Vars.UI_t_ESPBoxes, "Draw Boxes");
                    if (Modules.UI_Vars.UIToggleESPBoxes != Modules.UI_Vars.UI_t_ESPBoxes)
                    {
                        Modules.UI_Vars.UI_t_ESPBoxes = !Modules.UI_Vars.UI_t_ESPBoxes;
                    }
                }

                if (Modules.UI_Vars.UI_t_Townm) //Town Manager Menu
                {
                    float EbaseX = baseX + 305f;

                    GUI.Box(new Rect(EbaseX + 5f, 5f, 300f, 130f), "");
                    GUI.Label(new Rect(EbaseX + 10f, 5f, 290f, 25f), $"Town Debt: ${mTownManager.TownDebt}");
                    GUI.Label(new Rect(EbaseX + 10f, 25f, 290f, 25f), $"Next House Cost: ${TownManager.manage.getNextHouseCost()}");

                    if (GUI.Button(new Rect(EbaseX + 10f, 44f, 131f, 20f), "Clear Debt"))
                    {
                        mTownManager.payAllDebt();
                    }
                    if (GUI.Button(new Rect(EbaseX + 10f, 69f, 131f, 20f), "Town Donates"))
                    {
                        mTownManager.townDonates(1);
                    }
                    if (GUI.Button(new Rect(EbaseX + 164f, 44f, 131f, 20f), "Add Beauty"))
                    {
                        mTownManager.addTownBeautyToAll();
                    }
                    if (GUI.Button(new Rect(EbaseX + 164f, 69f, 131f, 20f), "Teleport to Town"))
                    {
                        mTownManager.TeleportToHome();
                    }
                    Modules.UI_Vars.UIToggleLockTent = GUI.Toggle(new Rect(EbaseX + 10f, 94f, 131f, 20f), Modules.UI_Vars.UI_t_LockTent, "Lock Tent");
                    if (Modules.UI_Vars.UIToggleLockTent != Modules.UI_Vars.UI_t_LockTent)
                    {
                        Modules.UI_Vars.UI_t_LockTent = !Modules.UI_Vars.UI_t_LockTent;
                    }
                    
                }

                if (Modules.UI_Vars.UI_t_Playerm) //Player Manager Menu
                {
                    float EbaseX = baseX + 305f;

                    GUI.Box(new Rect(EbaseX + 5f, 5f, 300f, 130f), "");

                    Modules.UI_Vars.UIToggleGodMode = GUI.Toggle(new Rect(EbaseX + 10f, 10f, 125f, 15f), Modules.UI_Vars.UI_t_GodMode, "God Mode");
                    if (Modules.UI_Vars.UIToggleGodMode != Modules.UI_Vars.UI_t_GodMode)
                    {
                        Modules.UI_Vars.UI_t_GodMode = !Modules.UI_Vars.UI_t_GodMode;
                    }

                    Modules.UI_Vars.UITogglePickupDropped = GUI.Toggle(new Rect(EbaseX + 10f, 30f, 180f, 22f), Modules.UI_Vars.UI_t_PickupDropped, "Auto Pickup Dropped Items");
                    if (Modules.UI_Vars.UITogglePickupDropped != Modules.UI_Vars.UI_t_PickupDropped)
                    {
                        Modules.UI_Vars.UI_t_PickupDropped = !Modules.UI_Vars.UI_t_PickupDropped;
                    }

                    Modules.UI_Vars.UIToggleFly = GUI.Toggle(new Rect(EbaseX + 10f, 50f, 125f, 22f), Modules.UI_Vars.UI_t_Fly, "Fly Mode");
                    if (Modules.UI_Vars.UIToggleFly != Modules.UI_Vars.UI_t_Fly)
                    {
                        Modules.UI_Vars.UI_t_Fly = !Modules.UI_Vars.UI_t_Fly;
                    }

                    Modules.UI_Vars.UIToggleCloseFollow = GUI.Toggle(new Rect(EbaseX + 10f, 70f, 180f, 22f), Modules.UI_Vars.UI_t_CloseFollow, "Close Follow Camera");
                    if (Modules.UI_Vars.UIToggleCloseFollow != Modules.UI_Vars.UI_t_CloseFollow)
                    {
                        Modules.UI_Vars.UI_t_CloseFollow = !Modules.UI_Vars.UI_t_CloseFollow;
                    }
                }

                if (Modules.UI_Vars.UI_t_ESPLocatorMenu)
                {
                    float EbaseX = baseX + 615f;

                    GUI.Box(new Rect(EbaseX + 5f, 5f, 300f, 130f), "");

                    Modules.UI_Vars.UIToggleLocator = GUI.Toggle(new Rect(EbaseX + 10f, 10f, 180f, 17f), Modules.UI_Vars.UI_t_Locator, $"Locate {eLocate}");
                    if (Modules.UI_Vars.UIToggleLocator != Modules.UI_Vars.UI_t_Locator)
                    {
                        Modules.UI_Vars.UI_t_Locator = !Modules.UI_Vars.UI_t_Locator;
                    }
                    tLocate = GUI.TextField(new Rect(EbaseX + 10f, 30f, 200f, 25f), tLocate);

                    if (GUI.Button(new Rect(EbaseX + 215f, 30f, 90f, 25f), "Set & Go"))
                    {
                        eLocate = tLocate;
                        GUI.FocusControl(null);
                        Modules.UI_Vars.UI_t_ESPLocatorMenu = false;
                    }

                    if (GUI.Button(new Rect(EbaseX + 10f, 69f, 131f, 20f), "TP to Object"))
                    {
                        ESP.tryTPtoObj = true;
                    }
                }

                if (Modules.UI_Vars.UI_t_Worldm)
                {
                    float EbaseX = baseX + 305f;

                    GUI.Box(new Rect(EbaseX + 5f, 5f, 300f, 130f), "");

                    Modules.UI_Vars.UITogglePause = GUI.Toggle(new Rect(EbaseX + 10f, 3f, 281f, 15f), Modules.UI_Vars.UI_t_Pause, "Pause Game (Toggle - F5)");
                    if (Modules.UI_Vars.UITogglePause != Modules.UI_Vars.UI_t_Pause)
                    {
                        Modules.UI_Vars.UI_t_Pause = !Modules.UI_Vars.UI_t_Pause;
                    }

                    GUI.Label(new Rect(EbaseX + 10f, 23, 107, 24),"View Distance");
                    dist = GUI.HorizontalSlider(new Rect(EbaseX + 10f, 47, 291, 20), dist, 1f, 5f);
                    if (dist != mWorldManager.viewDist) { mWorldManager.viewDist = dist; NewChunkLoader.loader.setChunkDistance((int)dist); }
                }

                if (Modules.UI_Vars.UI_t_Miscm)
                {
                    float EbaseX = baseX + 305f;

                    GUI.Box(new Rect(EbaseX + 5f, 5f, 300f, 130f), "");

                    if (GUI.Button(new Rect(EbaseX + 10f, 10f, 131f, 20f), "Debug Output"))
                    {
                        mDebug.debugWindow();
                    }
                    
                }

            }
        }

        private static void toggleHelper(string menuName)
        {
            switch (menuName)
            {
                case "ESP": // Modules.UI_Vars.UI_t_ESPm
                    if (Modules.UI_Vars.UI_t_Playerm) { Modules.UI_Vars.UI_t_Playerm = false; }
                    if (Modules.UI_Vars.UI_t_Townm) { Modules.UI_Vars.UI_t_Townm = false; }
                    if (Modules.UI_Vars.UI_t_Animalm) { Modules.UI_Vars.UI_t_Animalm = false; }
                    if (Modules.UI_Vars.UI_t_Worldm) { Modules.UI_Vars.UI_t_Worldm = false; }
                    if (Modules.UI_Vars.UI_t_Miscm) { Modules.UI_Vars.UI_t_Miscm = false; }
                    break;
                case "Player Manager": // Modules.UI_Vars.UI_t_Playerm
                    if (Modules.UI_Vars.UI_t_ESPm) { Modules.UI_Vars.UI_t_ESPm = false; }
                    if (Modules.UI_Vars.UI_t_Townm) { Modules.UI_Vars.UI_t_Townm = false; }
                    if (Modules.UI_Vars.UI_t_Animalm) { Modules.UI_Vars.UI_t_Animalm = false; }
                    if (Modules.UI_Vars.UI_t_Worldm) { Modules.UI_Vars.UI_t_Worldm = false; }
                    if (Modules.UI_Vars.UI_t_Miscm) { Modules.UI_Vars.UI_t_Miscm = false; }
                    break;
                case "Town Manager": // Modules.UI_Vars.UI_t_Townm
                    if (Modules.UI_Vars.UI_t_ESPm) { Modules.UI_Vars.UI_t_ESPm = false; }
                    if (Modules.UI_Vars.UI_t_Playerm) { Modules.UI_Vars.UI_t_Playerm = false; }
                    if (Modules.UI_Vars.UI_t_Animalm) { Modules.UI_Vars.UI_t_Animalm = false; }
                    if (Modules.UI_Vars.UI_t_Worldm) { Modules.UI_Vars.UI_t_Worldm = false; }
                    if (Modules.UI_Vars.UI_t_Miscm) { Modules.UI_Vars.UI_t_Miscm = false; }
                    break;
                case "Animal Manager": // Modules.UI_Vars.UI_t_Animalm
                    if (Modules.UI_Vars.UI_t_ESPm) { Modules.UI_Vars.UI_t_ESPm = false; }
                    if (Modules.UI_Vars.UI_t_Playerm) { Modules.UI_Vars.UI_t_Playerm = false; }
                    if (Modules.UI_Vars.UI_t_Townm) { Modules.UI_Vars.UI_t_Townm = false; }
                    if (Modules.UI_Vars.UI_t_Worldm) { Modules.UI_Vars.UI_t_Worldm = false; }
                    if (Modules.UI_Vars.UI_t_Miscm) { Modules.UI_Vars.UI_t_Miscm = false; }
                    break;
                case "World Manager": // Modules.UI_Vars.UI_t_Worldm
                    if (Modules.UI_Vars.UI_t_ESPm) { Modules.UI_Vars.UI_t_ESPm = false; }
                    if (Modules.UI_Vars.UI_t_Playerm) { Modules.UI_Vars.UI_t_Playerm = false; }
                    if (Modules.UI_Vars.UI_t_Townm) { Modules.UI_Vars.UI_t_Townm = false; }
                    if (Modules.UI_Vars.UI_t_Animalm) { Modules.UI_Vars.UI_t_Animalm = false; }
                    if (Modules.UI_Vars.UI_t_Miscm) { Modules.UI_Vars.UI_t_Miscm = false; }
                    break;
                case "Misc": // Modules.UI_Vars.UI_t_Miscm
                    if (Modules.UI_Vars.UI_t_ESPm) { Modules.UI_Vars.UI_t_ESPm = false; }
                    if (Modules.UI_Vars.UI_t_Playerm) { Modules.UI_Vars.UI_t_Playerm = false; }
                    if (Modules.UI_Vars.UI_t_Townm) { Modules.UI_Vars.UI_t_Townm = false; }
                    if (Modules.UI_Vars.UI_t_Animalm) { Modules.UI_Vars.UI_t_Animalm = false; }
                    if (Modules.UI_Vars.UI_t_Worldm) { Modules.UI_Vars.UI_t_Worldm = false; }
                    break;

                default:
                    break;
            }
        }
    }
}
