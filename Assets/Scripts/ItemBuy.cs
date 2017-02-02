using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemBuy : MonoBehaviour {

    private Text textName;

    GameManager gm;

    public GameObject question;

    PlayerController pc;

    PlayerManager pm;

    public string name = null;
    public int price = -1;
    public int code = -1;

    private int item;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        pc = FindObjectOfType<PlayerController>();
        pm = FindObjectOfType<PlayerManager>();
        textName = GetComponentInChildren<Text>();
        textName.text = name + " : " + price + "원";
    }

    public void Buy()
    {
        var qs = question.gameObject.GetComponent<BuyQuestion>();
        qs.name = name;
        qs.price = price;
        qs.code = code;

        if (gm.money < price)
            return;
        switch (code)
        {
            case 1 :
                pm.alcohol--;
                gm.money -= price;
                break;
            case 2 :
                pm.alcohol -= 2;
                gm.money -= price;
                break;
            case 3 :
                pm.hp++;
                gm.money -= price;
                break;
            case 4 :
                pm.hp += 2;
                gm.money -= price;
                break;
            case 5 :
                pc.speed += 10;
                gm.money -= price;
                break;
            case 6 :
                pc.speed += 20;
                gm.money -= price;
                break;
            case 7 :
                gm.money -= price;
                gm.money += Random.Range(0, 700) / 100 * 100;
                break;
            case 8 :
                gm.money += Random.Range(0, 3500) / 100 * 100;
                gm.money -= price;
                break;
                
        }

        question.SetActive(true);

        /*
        gameManager = GameObject.Find("GameManager");

        var gm = gameManager.gameObject.GetComponent<GameManager>();
        money = gm.money;
        item = gm.item[code];

        if (money >= price)
        {
            money -= price;
            gm.money -= price;
            gm.item[code] += 1;
        }
        else
        {
            Debug.Log("" + gm.money + " / " + money);
        }*/
    }
}
