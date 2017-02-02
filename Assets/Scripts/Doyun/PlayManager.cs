using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour {

    PlayerManager pm;

    GameManager gm;

    PlayerController pc;

    public Text deadText;

    float currentTime = 0;
    float coolTime = 7;

    private void Start()
    {

        pm = FindObjectOfType<PlayerManager>();

        gm = FindObjectOfType<GameManager>();

        pc = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
        currentTime += Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.tag);
        if(collision.transform.tag == "Car")
        {
            pc.isControl = false;
            deadText.text = "당신은 차에 치여 죽었습니다.";
        }
        else if(collision.transform.tag == "Wall")
        {
            pm.hp--;
            if (pm.hp <= 0)
                deadText.text = "당신은 전봇대에 부딪혀 죽었습니다.";
                
        }
        else if(collision.transform.tag == "TrashCan" && currentTime > coolTime)
        {
            Debug.Log("1");
            switch (Random.Range(0, 100) % 2)
            {
                case 0:
                    gm.money += Random.Range(500, 1500) / 100 * 100;
                    break;
                case 1:
                    pm.hp -= 2;
                    if (pm.hp <= 0)
                        deadText.text = "사인 : 도박사";
                    break;
            }

            currentTime = 0;
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Alcohol")
        {
            pm.alcohol++;
            col.gameObject.SetActive(false);
        }
    }

}