using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 5;
	public bool isControl = true;
	Rigidbody rb;

	float currentTime = 0;
	float coolTime = .2f;
	float horRandom;
	float verRandom;


	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	void Update () {
		
		currentTime += Time.deltaTime;

		if (currentTime > coolTime) {
			horRandom = Random.Range (-3.0f, 3.0f);
			verRandom = Random.Range (-3.0f, 3.0f);
			currentTime = 0;

		}

		if (isControl)
		{
			PlayerMove();
		}

	}

	void PlayerMove()
	{
		float hor = Input.GetAxis("Horizontal");
		float ver = Input.GetAxis("Vertical");

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)) {			
			hor = (hor + horRandom) * 40 * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			ver = (ver + verRandom) * 40 * Time.deltaTime;
		}
		var moving = new Vector3(hor, 0, ver);
		rb.velocity = moving;

		float hor2 = Input.GetAxis("Horizontal");
		float ver2 = Input.GetAxis ("Vertical");

		var looking = new Vector3 (hor2, 0, ver2);

		var lookPos = transform.position + looking;
		transform.LookAt (lookPos);

}
}