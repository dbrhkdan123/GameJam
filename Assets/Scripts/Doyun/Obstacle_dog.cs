using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Obstacle_dog : MonoBehaviour {

    GameObject player;

    PlayerManager pm;

    public Animator anim_dog;

    float currentTime = 0;
    float coolTime = 10;

    public Text deadText;

    private void Start()
    {
        pm = FindObjectOfType<PlayerManager>();

        player = GameObject.Find("Player");

    }

    private void Update()
    {
        var distance = Vector3.Distance(gameObject.transform.position, player.transform.position);

        if (distance < 1.5f)
        {
            anim_dog.SetBool("IsNear", true);
            if (currentTime > coolTime)
            {
                pm.hp -= 2;
                if (pm.hp <= 0)
                    deadText.text = "당신은 개에 물려 죽었습니다.";
                currentTime = 0;
            }
        }
        else
        {
            anim_dog.SetBool("IsNear", false);
        }
        currentTime += Time.deltaTime;
    }
}
