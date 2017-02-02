using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

	public GameObject UiOnOff;

	public float alcohol = 4.0f;
	public int hp = 5;

	public GameObject[] gauge = new GameObject[15];
	public GameObject[] life = new GameObject[5];

	void damaged()
	{

		if (hp <= 0)
			UiOnOff.SendMessage ("OnOff");

        if (hp <= 5)
        {
            for(int i = 0; i < 5; i++)
            {
                life[i].SetActive(false);
            }
            for (int i = 0; i < hp; i++)
                life[i].SetActive(true);
        }
        if (hp > 5)
            hp = 5;
    }

	void gaugeUpdate()
	{
		if (alcohol >= 15.0f)
			alcohol = 15.0f;

		for (int i = 0; i < 15; i++)
			gauge [i].SetActive (false);

		for (int i = 0; i < (int)alcohol; i++)
			gauge [i].SetActive (true);
	}


	// Update is called once per frame
	void Update () {
		damaged ();
		gaugeUpdate ();
	}
}
