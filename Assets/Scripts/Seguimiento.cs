using UnityEngine;
using System.Collections;

public class Seguimiento : MonoBehaviour {

	public Transform player;
	public float separacion = 6f;


	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (player.position.x + separacion, transform.position.y, transform.position.z);
	}
}
