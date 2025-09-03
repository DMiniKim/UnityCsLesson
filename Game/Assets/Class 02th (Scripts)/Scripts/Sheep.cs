using UnityEngine;

public class Sheep : MonoBehaviour
{
    Ability ability;

    private void Awake()
    {
        // Awake : 객체가 생성될 때 호출되는 함수로,
        //         객체가 비활성화 되어있을 때에도 호출되며 단 한 번만 호출되는 이벤트 함수.

        Debug.Log("Awake");
        ability  = new Ability();
    }
    private void OnEnable()
    {
        // OnEnable : 객체가 활성화되었을 때 호출되는 이벤트 함수.
        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start : 객체가 생성되었을 때 호출되며 , 단 한 번만 호출되는 이벤트 함수.
        Debug.Log("Start");

    }
    private void FixedUpdate()
    {
        // FixedUpdate : Time Step에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수.
        Debug.Log("FixedUpdate");
    }


    void Update()
    {
        // Update : 객체가 활성화되는 동안, 매 프레임마다 호출되는 이벤트 함수.
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수.
        Debug.Log("LateUpdate");
    }
}
