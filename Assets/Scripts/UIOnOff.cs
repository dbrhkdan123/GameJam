using UnityEngine;
using System.Collections;

public class UIOnOff : MonoBehaviour
{

    public GameObject[] ui = new GameObject[2];

    void OnOff()
    {
        ui[0].SetActive(true);
        ui[1].SetActive(false);
    }
}