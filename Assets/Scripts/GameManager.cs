using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public int money = 1000;
    public int[] item = new int[10];

    public void RefreshMoney(int m)
    {
        money -= m;

        Debug.Log("RefreshMoney : " + money);
    }
}
