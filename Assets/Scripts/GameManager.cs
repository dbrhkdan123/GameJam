using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public int money = 1000;
    public int[] item = new int[10];
	public Text tx;
	void Start()
	{
		tx.text = "= " + money;
	}

    public void RefreshMoney(int m)
    {
        money -= m;

        Debug.Log("RefreshMoney : " + money);
    }
}
