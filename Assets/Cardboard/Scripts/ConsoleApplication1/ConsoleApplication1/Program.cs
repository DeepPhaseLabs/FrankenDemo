
/*function Start () {
var newVertices;// = Vector3[];
var newUV;// = Vector2[];
var newTriangles;// : int[];

	var mesh : Mesh = new Mesh ();
	GetComponent.<MeshFilter>().mesh = mesh;
	mesh.vertices = newVertices;
	mesh.uv = newUV;
	mesh.triangles = newTriangles;
}*/
//just commented out for now in case I wreck the code
//commented fixed areas --note just removing errors, I'm unsure of the original code purpose...
using UnityEditor;
using System.Collections;

using UnityEngine;//necessary to access monobehavior, vectorx, etc
namespace Start
{//start is a namespace
    class PURPLE//need class, methods
    {
        public static void main(string[] args)
        {
            GameObject x=GameObject.Find("Cube");
            Vector3[] newVertices = new[] { new Vector3(0f, 0f, 0f), new Vector3(1f, 1f, 1f), new Vector3(0f, 1f, 0f) };//changed initialization, it should work with colons but wasn't for me so will solve later.     
            //var newVertices : Vector3[];
            Vector2[] newUV = new[] { new Vector2(0f, 0f), new Vector2(1f, 1f),new Vector2(0f,1f) };
            //var newUV : Vector2;
            int[] newTriangles={0,1,2};
            //var newTriangles : int[];
            // Mesh mesh = new Mesh();
            //var mesh : Mesh = new Mesh ();
            Mesh mesh;
            MeshFilter objectmesh = x.GetComponent<MeshFilter>();// (MeshFilter.mesh.get);
            mesh = objectmesh.sharedMesh;
            //GetComponent.<MeshFilter>().mesh = mesh;
            mesh.vertices = newVertices;
            mesh.uv = newUV;
            mesh.triangles = newTriangles;
        }
    }
}

