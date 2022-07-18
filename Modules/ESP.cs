using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dinkum.Modules
{
    class ESP
    {
        public static void updateESP()
        {
            if (Modules.UI_Vars.UI_t_ESPAnimals)
            {
                foreach (AnimalAI entity in Hacks.Animals)
                {
                    
                    if (!entity.isDead())
                    {
                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.animalName.Replace("(Clone)", "")}", Color.white);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Lib.NuColor.RGBtoColor(255, 180, 0));
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Lib.NuColor.RGBtoColor(255, 180, 0));
                            }
                        }
                    }
                }
            }

            if (Modules.UI_Vars.UI_t_ESPNPCs)
            {
                foreach (NPCAI entity in Hacks.NPCS)
                {
                    if (entity)
                    {
                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.myId.name}", Color.yellow);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Color.cyan);
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Color.cyan);
                            }
                        }
                    }
                }
            }

            if (Modules.UI_Vars.UI_t_ESPTrees)
            {
                foreach (GameObject entity in Hacks.TreeEntity)
                {
                    if (entity)
                    {
                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.name.Replace("(Clone)", "")}", Color.white);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Color.red);
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Color.red);
                            }
                        }
                    }
                }
            }

            if (Modules.UI_Vars.UI_t_ESPPlayers)
            {
                foreach (CharMovement entity in Hacks.Players)
                {
                    if (entity)
                    {
                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.name}", Color.green);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Color.yellow);
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Color.yellow);
                            }
                        }
                    }
                }

                foreach (CharMovement entity in Hacks.NetworkPlayers)
                {

                    if (entity)
                    {
                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.name}", Color.magenta);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Color.magenta);
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Color.magenta);
                            }
                        }
                    }
                }
            }

            if (Modules.UI_Vars.UI_t_ESPBuried)
            {
                foreach (GameObject entity in Hacks.BuriedEntity)
                {
                    if (entity)
                    {

                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.name.Replace("(Clone)", "")}", Color.white);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Color.red);
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Color.red);
                            }
                        }
                    }
                }
            }

            if (Modules.UI_Vars.UI_t_ESPDropped)
            {
                foreach (DroppedItem entity in Hacks.DroppedItems)
                {
                    if (entity)
                    {
                        Vector3 pivotPos = entity.transform.position;
                        Vector3 playerFootPos; playerFootPos.x = pivotPos.x; playerFootPos.z = pivotPos.z; playerFootPos.y = pivotPos.y - 1f;
                        Vector3 playerHeadPos; playerHeadPos.x = playerFootPos.x; playerHeadPos.z = playerFootPos.z; playerHeadPos.y = playerFootPos.y + 1f;

                        Vector3 w2s_playerFoot = Hacks.MainCamera.WorldToScreenPoint(playerFootPos);
                        Vector3 w2s_playerHead = Hacks.MainCamera.WorldToScreenPoint(playerHeadPos);

                        if (w2s_playerFoot.z > 0f && w2s_playerFoot.z <= Hacks.ESPDistance)
                        {
                            if (Modules.UI_Vars.UI_t_ESPLabels)
                            {
                                DrawText(w2s_playerFoot, w2s_playerHead, $"{entity.name.Replace("(Clone)", "")}", Color.white);
                            }
                            if (Modules.UI_Vars.UI_t_ESPLines)
                            {
                                DrawLine(w2s_playerFoot, Color.red);
                            }
                            if (Modules.UI_Vars.UI_t_ESPBoxes)
                            {
                                DrawESP(w2s_playerFoot, w2s_playerHead, Color.red);
                            }
                            
                        }
                    }
                }
            }
        }

        private static void DrawESP(Vector3 objfootPos, Vector3 objheadPos, Color objColor)
        {
            //Draw Basic ESP Method from Vector3 W2S input
            float height = objheadPos.y - objfootPos.y;
            float widthOffset = 2f;
            float width = height / widthOffset;

            Render.DrawBox(objfootPos.x - (width / 2), (float)Screen.height - objfootPos.y - (height * 2f), width, height, objColor, 2f);
        }
        private static void DrawText(Vector3 objfootPos, Vector3 objheadPos, String name, Color color)
        {
            float height = objheadPos.y - objfootPos.y;
            float widthOffset = 2f;
            float width = height / widthOffset;

            Render.DrawString(new Vector2(objfootPos.x - (width / 2), (float)Screen.height - objfootPos.y - (height / 2)), $"{name}", color);
        }
        private static void DrawLine(Vector3 entPos, Color color)
        {
            Render.DrawLine(new Vector2((float)Screen.width / 2, (float)Screen.height), new Vector2(entPos.x, (float)Screen.height - entPos.y), color, 1);
        }
    }
}
