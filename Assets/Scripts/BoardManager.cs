using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoardManager : MonoBehaviour {

	private PlayerManager pm;
	private GameManager gm;
	public Text money;
	public Text alcoholPer;
	public Text score;

	void Start()
	{
        pm = FindObjectOfType<PlayerManager>();
        gm = FindObjectOfType<GameManager>();
		money.text = gm.money + "Won";
        float alcoholpercent = Mathf.Round((pm.alcohol * (2f / 150f)) * 100.0f);
        alcoholpercent = alcoholpercent / 100f;
        alcoholPer.text = " : "+ alcoholpercent + "%";
		score.text = " : 0";
	}
}
