using UnityEngine;
using System.Collections;

public class ProgressScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		var fieldChange = GetComponent<FieldChange>();
		fieldChange.IsRunning = !fieldChange.IsRunning;
	}
}
