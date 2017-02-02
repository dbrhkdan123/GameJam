using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {

    public GameObject finishUI;
    public GameObject ui;
    public bool finish=false;
    void OnTriggerEnter()
    {
        ui.SetActive(false);
        finishUI.SetActive(true);
        finish = true;
    }
}
