#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class DynamicMeshSaver : MonoBehaviour
{
    [SerializeField] private string meshPath = "Assets/Meshes/GeneratedMesh.asset";

    void Start()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[]
        {
            new Vector3(-1, 0, -1),
            new Vector3(-1, 0, 1),
            new Vector3(1, 0, -1),
            new Vector3(1, 0, 1),
            new Vector3(1, 2, -1),
            new Vector3(1, 2, 1),

            new Vector3(1, 0, -1),
            new Vector3(-1, 0, -1),
            new Vector3(1, 2, -1),

            new Vector3(-1, 0, 1),
            new Vector3(1, 0, 1),
            new Vector3(1, 2, 1)
        };

        int[] quads = new int[]
        {
            0, 2, 3, 1,
            2, 4, 5, 3,
            0, 1, 5, 4
        };

        int[] triangles = new int[]
        {
            6, 7, 8,
            9, 10, 11
        };

        mesh.vertices = vertices;

        mesh.subMeshCount = 2;
        mesh.SetIndices(quads, MeshTopology.Quads, 0);
        mesh.SetIndices(triangles, MeshTopology.Triangles, 1);

        mesh.RecalculateNormals();

#if UNITY_EDITOR
        AssetDatabase.CreateAsset(mesh, meshPath);
        AssetDatabase.SaveAssets();
#endif
    }
}
