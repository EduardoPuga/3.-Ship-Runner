using UnityEngine;
using System.Collections;

public class Pared : MonoBehaviour {
	
	public void OnTriggerEnter2D(Collider2D other){
		/*print ("Trigger");
		print (other);*/
		
		Destroy (other.gameObject);

		/*public void OnCollisionEnter2D(Collision2D coll){
		print (coll);*/
	}
}
