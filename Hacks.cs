using System;
using System.Threading;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Dinkum
{
    class Hacks : MonoBehaviour
    {
        public static Camera MainCamera = null;
        public static float Timer = 0f;

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
            if (Input.GetKeyDown(KeyCode.End)) // Kill hacks on "End" key pressed
            {
                Loader.unload();
            }

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                Modules.UI_Vars.t_MENU = !Modules.UI_Vars.t_MENU;
            }
            
            if (Modules.mPlayerManager.isFlying)
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
            if (Timer >= 5f) 
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

                Animals = GameObject.FindObjectsOfType<AnimalAI>().ToList<AnimalAI>();
                NPCS = GameObject.FindObjectsOfType<NPCAI>().ToList<NPCAI>();
                Players = GameObject.FindObjectsOfType<CharMovement>().ToList<CharMovement>();
                NetworkPlayers = NetworkPlayersManager.manage.connectedChars.ToList<CharMovement>();
                DroppedItems = GameObject.FindObjectsOfType<DroppedItem>().ToList<DroppedItem>();
            }

            Modules.mPlayerManager.update();
            Modules.mTownManager.update();
        }

        public void OnGUI()
        {
            Modules.UI.menu();
            Modules.ESP.updateESP();
            
            
        }

        

    }
}
