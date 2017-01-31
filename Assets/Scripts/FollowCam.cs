using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour 
{
	public Transform player;
	Vector3 offset;

	void Start(){
		offset = player.position - transform.position;
	}
	void LateUpdate(){
		transform.position = player.position - offset;
	}
}