using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {


	public GameObject [] obstaculo;
	public float tiempoMin = 1.5f;
	public float tiempoMax = 3f;


	// Use this for initialization
	void Start () {
		Generar();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Generar() {
		Instantiate(obstaculo[Random.Range(0,obstaculo.Length)], transform.position, Quaternion.identity);
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));
	}
}
