#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class DynamicPrefabSaver : MonoBehaviour
{
    [SerializeField] private string prefabPath = "Assets/Prefabs/DynamicMeshPrefab.prefab";
    [SerializeField] private bool savePrefab = false;

#if UNITY_EDITOR
    void Update()
    {
        if (savePrefab)
        {
            PrefabUtility.SaveAsPrefabAsset(gameObject, prefabPath);
            Debug.Log("Prefab saved at: " + prefabPath);

            savePrefab = false;
        }
    }
#endif
}
