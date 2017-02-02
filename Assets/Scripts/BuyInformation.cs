using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BuyInformation : MonoBehaviour
{
    public string name = null;
    public int price = 0;
    public bool check = false;

    private Text text;

    private void Start()
    {
        text = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        //비논리적인거 아는데
        //코드를 잘못 수정해서
        //다시 타이핑하기 귀찮다
        //그냥 무시하고해

        if (check)
            text.text = name + "을(를)\n" + price + "원에 구매하셨습니다!";
        else
            text.text = "금액이 부족합니다!";
    }   

    public void Close()
    {
        check = false;
        this.gameObject.SetActive(false);
    }
}
