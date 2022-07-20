using Mirror;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

namespace Dinkum.Modules
{
    class mDebug
    {
        private static Vector2 scrollPosition = Vector2.zero;
        private static bool canSpawn = false;
        private static AssetBundle assetBundleCreateRequest;
        private static GameObject prefab;
        public static void update()
        {

        }

        public static void debugWindow()
        {
            bool addCollider = true;
            bool addGravity = true;

            string assetBundleName = "wp_asset";
            string assetName = "chair_4 Variant";

            string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "AssetBundles");
            filePath = System.IO.Path.Combine(filePath, assetBundleName);

            var assetBundleCreateRequest = AssetBundle.LoadFromFile(filePath);
            if (assetBundleCreateRequest == null)
            {
                return;
            }
            
            GameObject prefab = assetBundleCreateRequest.LoadAsset<GameObject>(assetName);
            GameObject go = GameObject.Instantiate(prefab, Hacks.localPlayer.transform.position, Hacks.localPlayer.transform.rotation);

            if (addCollider)
            {
                go.AddComponent<CapsuleCollider>();
                go.GetComponent<CapsuleCollider>().enabled = true;
                go.AddComponent<TerrainCollider>();
                go.GetComponent<TerrainCollider>().enabled = true;

            }
            if (addGravity)
            {
                go.AddComponent<Rigidbody>();
                go.GetComponent<Rigidbody>().useGravity = true;
                go.GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
                go.GetComponent<Rigidbody>().detectCollisions = true;
                go.GetComponent<Rigidbody>().detectCollisions = true;
            }

            go.AddComponent<CharInteract>();
            go.AddComponent<NavMeshAgent>();
            GameObject.Destroy(assetBundleCreateRequest);
        }

        

    }
}
