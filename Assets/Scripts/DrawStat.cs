using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DrawStat : MonoBehaviour {

    private GameObject gameManager;

    public Text text;

    private void Start()
    {
        text = GetComponent<Text>();

        gameManager = GameObject.Find("GameManager");

//        var gm = gameManager.gameObject.GetComponent<GameManager>();
    }

    private void Update()
    {
        //text.text ="지갑 : " + gameManager.gameObject.GetComponent<GameManager>().money+ "원";
        text.text = gameManager.gameObject.GetComponent<GameManager>().money + "원";
    }
}
