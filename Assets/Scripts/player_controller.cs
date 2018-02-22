using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_controller : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText; 
	private Rigidbody rb;
	private int count;


	void Start(){
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	public void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVeritcal = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVeritcal);

		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			count = count + 1; 
			SetCountText ();
		}
	}

	void SetCountText () {
		countText.text = "Score: " + count.ToString ();
		if (count >= 2) { 
			winText.text = "Winner!";
		}
	}

	void End(){
		
	}
}
		

