using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GeneratePyramid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = CreatePyramidMesh();
    }

    // Update is called once per frame
    private Mesh CreatePyramidMesh()
    {
        var mesh = new Mesh()
        {
            name = "Pyramid"
        };
        
        mesh.SetVertices(new[]
        {
            // front
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(-1.0f,-1.0f, -1.0f),
            new Vector3(1.0f,-1.0f, -1.0f),
            
            // back
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(-1.0f,-1.0f, 1.0f),
            new Vector3(1.0f,-1.0f, 1.0f),
            
            // left
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(-1.0f,-1.0f, 1.0f),
            new Vector3(-1.0f,-1.0f, -1.0f),
            
            // right 
            new Vector3(0.0f, 1.0f, 0.0f),
            new Vector3(1.0f,-1.0f, 1.0f),
            new Vector3(1.0f,-1.0f, -1.0f),
            
            // bottom
            new Vector3(-1.0f,-1.0f,-1.0f),
            new Vector3(1.0f,-1.0f,1.0f),
            new Vector3(-1.0f,-1.0f,1.0f),
            
            new Vector3(-1.0f,-1.0f,-1.0f),
            new Vector3(1.0f,-1.0f,1.0f),
            new Vector3(1.0f,-1.0f,-1.0f),
            
        });
        
        mesh.SetColors(new[]
        {
            Color.cyan,
            Color.cyan,
            Color.cyan,

            Color.red,
            Color.red,
            Color.red,

            Color.blue,
            Color.blue,
            Color.blue,

            Color.magenta, 
            Color.magenta,
            Color.magenta, 
            
            Color.yellow, 
            Color.yellow, 
            Color.yellow, 
            
            Color.yellow, 
            Color.yellow, 
            Color.yellow,

        });
        
        var indices = Enumerable.Range(0, mesh.vertices.Length).ToArray();
        mesh.SetIndices(indices, MeshTopology.Triangles, 0);
        
        return mesh;
    }
}
