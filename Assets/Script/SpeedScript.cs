using UnityEngine;
using System.Collections;

public class SpeedScript : MonoBehaviour {

	public bool Up = false;
	public GUIStyle Style;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		var fieldChange = GameObject.Find("Animal_Green").GetComponent<FieldChange>();
		if (Up)
			fieldChange.Speed = fieldChange.Speed + 5;
		else
			fieldChange.Speed = fieldChange.Speed - 5;
	}

	void OnGUI () {
		if (Up){
			var fieldChange = GameObject.Find("Animal_Green").GetComponent<FieldChange>();
			GUI.Label(new Rect (0, 0, 100, 30), "Speed:" + fieldChange.Speed.ToString(), Style);
		}
	}

}
