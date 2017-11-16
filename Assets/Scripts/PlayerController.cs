using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float moveSpeed;

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizInput = Input.GetAxisRaw ("Horizontal");
		if(horizInput > 0.5f || horizInput < -0.5f){
			transform.Translate (new Vector3 (horizInput * moveSpeed * Time.deltaTime, 0f, 0f));
		}
		float vertInput = Input.GetAxisRaw ("Vertical");
		if(vertInput > 0.5f || vertInput < -0.5f){
			transform.Translate (new Vector3 (0f, vertInput * moveSpeed * Time.deltaTime, 0f));
		}

		anim.SetFloat ("MoveX", horizInput);
		anim.SetFloat ("MoveY", vertInput);
	}
}
