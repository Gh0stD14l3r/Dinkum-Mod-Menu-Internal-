using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dinkum.Modules
{
    class mWorldManager
    {
        public static float viewDist = (float)NewChunkLoader.loader.getChunkDistance();
        public static void update()
        {
            if (UI_Vars.UI_t_Pause)
            {
                if (Time.timeScale == 1f)
                {
                    Time.timeScale = 0f;
                }
            }
            else
            {
                if (Time.timeScale != 1f)
                {
                    Time.timeScale = 1f;
                }
            }
        }

        
    }
}
