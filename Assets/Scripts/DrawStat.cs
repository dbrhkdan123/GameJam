using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DrawStat : MonoBehaviour {

    private GameObject gameManager;

    public Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }

    private void Update()
    {
        gameManager = GameObject.Find("GameManager");

        var gm = gameManager.gameObject.GetComponent<GameManager>();

        text.text = gm.money + "원";
    }
}
