using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;

	private Animator anim;

	private bool playerMoving;
	private Vector2 lastMove;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		playerMoving = false;
		float horizInput = Input.GetAxisRaw ("Horizontal");
		float vertInput = Input.GetAxisRaw ("Vertical");

		if(horizInput > 0.5f || horizInput < -0.5f){
			transform.Translate (new Vector3 (horizInput * moveSpeed * Time.deltaTime, 0f, 0f));
			playerMoving = true;
			lastMove = new Vector2 (horizInput, 0f);
		}
		if(vertInput > 0.5f || vertInput < -0.5f){
			transform.Translate (new Vector3 (0f, vertInput * moveSpeed * Time.deltaTime, 0f));
			playerMoving = true;
			lastMove = new Vector2 (0f, vertInput);
		}

		anim.SetFloat ("MoveX", horizInput);
		anim.SetFloat ("MoveY", vertInput);
		anim.SetBool ("PlayerMoving", playerMoving);
		anim.SetFloat ("LastMoveX", lastMove.x);
		anim.SetFloat("LastMoveY", lastMove.y);
	}
}
