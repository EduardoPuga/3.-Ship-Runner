using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private float verticalSpeed = 0.3f;
	private float horizontalSpeed = 0.15f;
	
	public Sprite inicio;
	public Sprite [] muerte;

	private int runIndex;
	private int tick;
	private int skipRun = 8;
	
	private int estado = 0; // 0 = circulando - 1 = moviendose - 2 = muerto

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tick++;
		
		if (tick > 2000) {
			tick = 0;
		}
		
		gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2 (horizontalSpeed, 0);

		if (Input.GetKey (KeyCode.UpArrow)){
			estado = 1;
			gameObject.GetComponent<Rigidbody2D>().velocity += new Vector2 (0, verticalSpeed);
		}
		
		if (Input.GetKey (KeyCode.DownArrow)){
			estado = 1;
			gameObject.GetComponent<Rigidbody2D>().velocity -= new Vector2 (0, verticalSpeed);
		}
		if (estado == 2){
			Muerte();
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		estado = 2;
		Muerte();
	}

	public void Final(){
		Application.LoadLevel ("Final");
	}

	public void Muerte(){
		if (estado == 2 && (tick % skipRun==0)){
			gameObject.GetComponent<SpriteRenderer> ().sprite = muerte [runIndex];
			runIndex++;
			if (runIndex > 7 || estado != 2) {
				runIndex = 0;
				
				Destroy (gameObject);
				Final ();
			}
		}
	}
}