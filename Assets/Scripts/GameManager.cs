using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    
    public int money = 1000;
    public int[] item = new int[10];

    public void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void RefreshMoney(int m)
    {
        money -= m;        
    }
}
