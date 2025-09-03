using UnityEngine;

public class Sheep : MonoBehaviour
{
    Ability ability;

    private void Awake()
    {
        // Awake : ��ü�� ������ �� ȣ��Ǵ� �Լ���,
        //         ��ü�� ��Ȱ��ȭ �Ǿ����� ������ ȣ��Ǹ� �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ�.

        Debug.Log("Awake");
        ability  = new Ability();
    }
    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start : ��ü�� �����Ǿ��� �� ȣ��Ǹ� , �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("Start");

    }
    private void FixedUpdate()
    {
        // FixedUpdate : Time Step�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("FixedUpdate");
    }


    void Update()
    {
        // Update : ��ü�� Ȱ��ȭ�Ǵ� ����, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ�.
        Debug.Log("LateUpdate");
    }
}
