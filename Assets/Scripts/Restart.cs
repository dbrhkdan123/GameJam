using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour {
    PlayerManager pm;
    Finish fm;
    void Start()
    {
        pm = FindObjectOfType<PlayerManager>();
        fm = FindObjectOfType<Finish>();
    }
    void Update()
    {
        if(pm.hp == 0 && Input.GetMouseButtonDown(0) || fm.finish == true )
        {
            SceneManager.LoadScene("Menu");
        }

    }
}


