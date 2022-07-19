using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dinkum.Modules
{
    class mDebug
    {
        private static Vector2 scrollPosition = Vector2.zero;
        private static List<GameObject> masterDebug = new List<GameObject>();
        public static void update()
        {

        }

        public static void debugWindow()
        {
            if (masterDebug.Count <= 0)
            {
                masterDebug = UnityEngine.GameObject.FindObjectsOfType<GameObject>().Distinct<GameObject>().ToList<GameObject>();
            }
            
            

        }

        
    }
}
