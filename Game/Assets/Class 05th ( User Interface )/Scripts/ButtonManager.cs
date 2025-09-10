using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button[] buttonList;
    string [] buttonNames = new string[] { "Start", "Option", "Quit" };
    void Start()
    {
       
        Action[] actions = { Execute, Option, Quit };
        for(int i = 0; i < buttonList.Length; i++)
        {            
            int index = i; // 클로저 문제 해결용 임시 변수
            buttonList[i].onClick.AddListener(() => actions[index]());
            //                                 람다로 임시함수 생성 후 actions[i]() 호출
            buttonList[i].GetComponentInChildren<Text>().text = buttonNames[i];
        }
        
    }
    public void Execute()
    {
        Debug.Log("Execute");
    }
    public void Option()
    {
        Debug.Log("Option");
    }
    public void Quit()
    {
        Debug.Log("Quit");
    }
}
