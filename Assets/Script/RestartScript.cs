using UnityEngine;
using System.Collections;

public class RestartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		GetComponent<FieldChange>().IsRunning = false;
		//Terrain terr = GetComponent<FieldChange>().terr as Terrain;
		//terr.
	}
}
