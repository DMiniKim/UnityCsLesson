using UnityEngine;

public class Seletable : MonoBehaviour
{
    ButtonManager buttonManager;
    void Start()
    {
        buttonManager = GetComponentInParent<ButtonManager>();
    }
    private void Update()
    {
        if (Input.mousePosition == buttonManager.transform.position)
        {
            Enter();
        }
        if (Input.GetMouseButtonDown(0))
        {
            Down();
        }
        if (Input.GetMouseButtonUp(0))
        {
            Exit();
        }
    }
    void Enter()
    {
        buttonManager.transform.localScale = Vector3.one * 1.2f;
    }
    void Exit()
    {
        buttonManager.transform.localScale = Vector3.one;
    }
    void Down()
    {
        buttonManager.transform.localScale = Vector3.one * 0.75f;
    }
}
