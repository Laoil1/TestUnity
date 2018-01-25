using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_meshGenerator : MonoBehaviour {

	public MeshFilter meshFilter;
	public MeshRenderer meshRendrer;

	public Vector3[] myVertices;
	public int[] myTriangles;

	void Start  (){
		myVertices = new Vector3[4];

		myVertices [0] = new Vector3 (-1, 1, 0);
		myVertices [1] = new Vector3 (1, 1, 0);
		myVertices [2] = new Vector3 (-1, -1, 0);
		myVertices [3] = new Vector3 (1, -1, 0);

		myTriangles = new int[] {
			0, 1, 2,
			2, 1, 3
		};

		Mesh myMesh = new Mesh ();

		myMesh.vertices = myVertices;
		myMesh.triangles = myTriangles;

		meshFilter.mesh = myMesh;

	}

}
