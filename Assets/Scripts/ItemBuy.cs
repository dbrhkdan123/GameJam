using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemBuy : MonoBehaviour {

    private Text textName;

    private GameObject gameManager;

    public GameObject question;

    public string name = null;
    public int price = -1;
    public int code = -1;

    private int money;
    private int item;

    private void Start()
    {
        textName = GetComponentInChildren<Text>();
        textName.text = name + " : " + price + "원";
    }

    public void Buy()
    {
        var qs = question.gameObject.GetComponent<BuyQuestion>();
        qs.name = name;
        qs.price = price;
        qs.code = code;

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
