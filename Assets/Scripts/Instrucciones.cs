using UnityEngine;
using System.Collections;

public class Instrucciones : MonoBehaviour {
	
	void OnGUI (){
		
		if (GUI.Button (new Rect (Screen.width/100, Screen.height/10, Screen.width / 10, Screen.height/ 10), "(B)ACK") || Input.GetKeyDown(KeyCode.B)) {
			
			Application.LoadLevel("Menu");
		}

		if (GUI.Button (new Rect (Screen.width/1.125f, Screen.height/1.22f, Screen.width / 10, Screen.height/ 10), "(S)TART") || Input.GetKeyDown(KeyCode.S)) {
			
			Application.LoadLevel("Game");
		}
	}
}
