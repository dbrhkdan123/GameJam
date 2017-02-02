using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 5;
	public bool isControl = true;
	Rigidbody rb;

    PlayerManager pm;

	float currentTime = 0;
	float coolTime = .2f;
	float horRandom;
	float verRandom;


	void Start () {
        pm = FindObjectOfType<PlayerManager>();
		rb = GetComponent<Rigidbody>();
	}
	void Update () {
		
		currentTime += Time.deltaTime;

		if (currentTime > coolTime) {
			horRandom = Random.Range (-1f - pm.alcohol / 20f, 1f + pm.alcohol / 20f);
			verRandom = Random.Range (-1f - pm.alcohol / 20f, 1f + pm.alcohol / 20f);
			currentTime = 0;

		}

		if (isControl)
		{
			PlayerMove();
		}

	}

	void PlayerMove()
	{
		float hor = -1 * Input.GetAxis("Horizontal");
		float ver = -1 * Input.GetAxis("Vertical");

		if (Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)) {			
			hor = (hor + horRandom) * speed * Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.LeftArrow)) {
			ver = (ver + verRandom) * speed * Time.deltaTime;
        }
		var moving = new Vector3(hor, 0, ver);
		rb.velocity = moving;

		float hor2 = -1 * Input.GetAxis("Horizontal");
		float ver2 = -1 * Input.GetAxis ("Vertical");

		var looking = new Vector3 (hor2, 0, ver2);

		var lookPos = transform.position + looking;
		transform.LookAt (lookPos);
    }

    void PlayerStop()
    {
        isControl = false;
    }
    void PlayerContinue()
    {
        isControl = true;
    }
}