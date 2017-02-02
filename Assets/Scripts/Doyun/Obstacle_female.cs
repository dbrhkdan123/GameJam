using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle_female : MonoBehaviour {

    GameObject player;
    PlayerController pc;
    PlayerManager pm;

    public Text deadText;

    private void Start()
    {
        pm = FindObjectOfType<PlayerManager>();
        pc = FindObjectOfType<PlayerController>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        var distance = Vector3.Distance(gameObject.transform.position, player.transform.position);
        
        if(distance < 1)
        {
            pc.isControl = false;
            pm.hp = 0;
            deadText.text = "당신은 성추행범으로 몰렸습니다.";
        }
    }

}