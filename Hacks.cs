using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Runtime.InteropServices;

namespace Dinkum
{
    class Hacks : MonoBehaviour
    {
        public static Camera MainCamera = null;
        public static float Timer = 0f;
        public static bool nextPause = false;

        public static List<AnimalAI> Animals = new List<AnimalAI>();
        public static List<NPCAI> NPCS = new List<NPCAI>();
        public static List<GameObject> TreeEntity = new List<GameObject>();
        public static List<GameObject> BuriedEntity = new List<GameObject>();
        public static List<CharMovement> Players = new List<CharMovement>();
        public static List<CharMovement> NetworkPlayers = new List<CharMovement>();
        public static List<DroppedItem> DroppedItems = new List<DroppedItem>();
        
        public static float ESPDistance = 80f;

        public static CharMovement localPlayer = NetworkMapSharer.share.localChar;


        public void Start()
        {
            
        }

        public void Update()
        {
            if (Modules.UI.m_title != "\x44\x69\x6e\x6b\x75\x6d\x20\x4d\x6f\x64\x20\x4d\x65\x6e\x75\x20\x2d\x20\x47\x68\x30\x73\x74" && !Inventory.inv.menuOpen) { Modules.UI.m_title = "\x44\x69\x6e\x6b\x75\x6d\x20\x4d\x6f\x64\x20\x4d\x65\x6e\x75\x20\x2d\x20\x47\x68\x30\x73\x74"; }

            if (Input.GetKeyDown(KeyCode.End)) // Kill hacks on "End" key pressed
            {
                Loader.unload();
            }

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                Modules.UI_Vars.t_MENU = !Modules.UI_Vars.t_MENU;
            }

            if (Input.GetKeyDown(KeyCode.F5))
            {
                if (Time.timeScale == 1f)
                {
                    nextPause = true;
                }
                else
                {
                    nextPause = false;
                    Time.timeScale = 1f;
                }
                
            }

            

            if (Modules.mPlayerManager.isFlying && NetworkMapSharer.share.localChar)
            {
                if (Input.GetKey(KeyCode.KeypadPlus))
                {
                    Modules.mPlayerManager.flyZ += 0.1f;
                }
                if (Input.GetKey(KeyCode.KeypadMinus))
                {
                    Modules.mPlayerManager.flyZ -= 0.1f;
                }
            }

            // 5 Second timer to loop entities and objects to return to lists
            Timer += Time.deltaTime; 
            if (Timer >= 5f && NetworkMapSharer.share.localChar) 
            {
                Timer = 0f;
                
                MainCamera = Camera.main;
                
                if (Modules.UI_Vars.UI_t_ESPTrees)
                {
                    TreeEntity = UnityEngine.GameObject.FindObjectsOfType<GameObject>().Where<GameObject>(s => (s.name.ToLower().Contains("clone") && s.name.ToLower().Contains("tree") && !s.name.ToLower().Contains("gum"))).ToList();
                }
                if (Modules.UI_Vars.UI_t_ESPBuried)
                {
                    BuriedEntity = UnityEngine.GameObject.FindObjectsOfType<GameObject>().Where<GameObject>(s => (s.name.ToLower().Contains("buried"))).ToList();
                }
                if (Modules.UI_Vars.UI_t_Locator)
                {
                    if (Modules.UI.eLocate != "")
                    {
                        Modules.ESP.LocateEntity = UnityEngine.GameObject.FindObjectsOfType<GameObject>().Where<GameObject>(s => (s.name.ToLower().Contains(Modules.UI.eLocate.ToLower()))).ToList();
                    }
                }

                Animals = GameObject.FindObjectsOfType<AnimalAI>().ToList<AnimalAI>();
                NPCS = GameObject.FindObjectsOfType<NPCAI>().ToList<NPCAI>();
                Players = GameObject.FindObjectsOfType<CharMovement>().ToList<CharMovement>();
                NetworkPlayers = NetworkPlayersManager.manage.connectedChars.ToList<CharMovement>();
                DroppedItems = GameObject.FindObjectsOfType<DroppedItem>().ToList<DroppedItem>();

                localPlayer = NetworkMapSharer.share.localChar;

            }
            
            if (NetworkMapSharer.share.localChar)
            {
                Modules.mPlayerManager.update();
                Modules.mTownManager.update();
                Modules.mWorldManager.update();
            }

            if (Inventory.inv.isMenuOpen())
            {
                if (Modules.UI.m_title != "\x44\x69\x6e\x6b\x75\x6d\x20\x49\x6e\x76\x65\x6e\x74\x6f\x72\x79\x20\x4d\x65\x6e\x75\x20\x2d\x20\x47\x68\x30\x73\x74") { Modules.UI.m_title = "\x44\x69\x6e\x6b\x75\x6d\x20\x49\x6e\x76\x65\x6e\x74\x6f\x72\x79\x20\x4d\x65\x6e\x75\x20\x2d\x20\x47\x68\x30\x73\x74"; }

            }
            //ParticleManager.manage.emitParticleAtPosition(ParticleManager.manage.fireStatusParticle, localPlayer.transform.position, UnityEngine.Random.Range(1, 2));
            //ParticleManager.manage.fireStatusGlowParticles.Emit(3);
            
        }

        public void OnGUI()
        {
            if (NetworkMapSharer.share.localChar)
            {
                Modules.UI.menu();
                Modules.ESP.updateESP();
            }
            else
            {
                GUI.Box(new Rect(5f, 5f, 300f, 30f), "Menu will load in game");
            }
            
            if (nextPause)
            {
                GUIStyle style = new GUIStyle();
                style.fontSize = 30;
                GUI.Box(new Rect(500f, 500f, (float)Screen.width - 1000, (float)Screen.height - 1000f), "");
                GUI.Label(new Rect(((float)Screen.width / 2) - 100, ((float)Screen.height / 2) - 100, 200, 200), "Game Paused", style);
                Time.timeScale = 0f;
            }
            
        }

        

    }
}
