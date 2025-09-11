using UnityEngine;
using UnityEngine.UI;

public class Seletable : MonoBehaviour
{
    [SerializeField] Text buttonText;
    
    private void Awake()
    {
        buttonText = gameObject.GetComponentInChildren<Text>();
    }
    
    // Cashing : 자주 사용하는 컴포넌트를 미리 변수에 저장해두는 것
    public void Enter()
    {
        buttonText.fontSize = 100;
    }
    public void Exit()
    {
        buttonText.fontSize = 75;
    }
    public void Down()
    {
        buttonText.fontSize = 50;
    }
}
