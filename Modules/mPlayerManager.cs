using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dinkum.Modules
{
    class mPlayerManager
    {
        public static Vector3 flightVector;
        public static float flyZ;
        public static bool isFlying;
        public static bool closeFollowCamera = false;
        public static void update()
        {
            if (UI_Vars.UI_t_GodMode)
            {
                StatusManager.manage.nextDayReset();
            }

            if (Modules.UI_Vars.UI_t_PickupDropped)
            {
                foreach (DroppedItem entity in Hacks.DroppedItems)
                {
                    if (entity)
                    {
                        if (Vector3.Distance(entity.transform.position, Hacks.localPlayer.transform.position) <= 5f)
                        {
                            Inventory.inv.addItemToInventory(entity.myItemId, entity.stackAmount);
                            entity.pickUp();
                            Mirror.NetworkServer.UnSpawn(entity.transform.root.gameObject);
                            NetworkMapSharer.Destroy(entity.transform.root.gameObject);
                        }
                    }
                }
            }

            if (isFlying)
            {
                flightVector = new Vector3(Hacks.localPlayer.transform.position.x, flyZ, Hacks.localPlayer.transform.position.z);
                Hacks.localPlayer.transform.position = flightVector;
            }

            if (Modules.UI_Vars.UI_t_Fly)
            {
                flyZ = Hacks.localPlayer.transform.position.y;
                isFlying = true;
            }
            else
            {
                if (isFlying)
                {
                    isFlying = false;
                    flyZ = 0f;
                }
            }

            if (UI_Vars.UI_t_CloseFollow)
            {
                if (!CameraController.control.isInAimCam())
                {
                    CameraController.control.enterAimCamera();
                }
            }
            else
            {
                if (CameraController.control.isInAimCam())
                {
                    CameraController.control.exitAimCamera();;
                }
            }

        }
    }
}
