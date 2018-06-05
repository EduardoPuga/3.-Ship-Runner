using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour {

	public int puntuacion = 0;
	public TextMesh marcadorDerecho;

	void start () {

		ActualizarMarcador ();

	}

	void OnTriggerEnter2D(Collider2D collider){
		/*print ("Trigger");
		print (other);*/

		puntuacion = puntuacion + 1;
		ActualizarMarcador ();
		Debug.Log (puntuacion);
		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}

	void ActualizarMarcador(){

		marcadorDerecho.text = puntuacion.ToString ();
	}
}
