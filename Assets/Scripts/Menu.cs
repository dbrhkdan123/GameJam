using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
  
	public void GameStart()
    {
        Application.LoadLevel("Stage1");
        
    }

    public void GameShop()
    {
        Application.LoadLevel("Shop");
    }

    public void GameQuit()
    {
        Application.Quit();
    }
}
