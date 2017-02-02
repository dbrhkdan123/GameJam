using UnityEngine;
using System.Collections;

public class Esc : MonoBehaviour {

    public GameObject UI;
    public GameObject Shop;
    
    bool shopOn = false;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(shopOn);
            if (shopOn)
            {
                Shop.SetActive(false);
                Debug.Log("1");
                shopOn = false;
                UI.SetActive(true);
            }
            else if(!shopOn)
            {
                Shop.SetActive(true);
                shopOn = true;
                UI.SetActive(false);
            }
        }
            
	}
}
