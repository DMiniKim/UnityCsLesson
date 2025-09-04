using UnityEngine;

// 데이터를 서버로 보낼 떄 0또는 1이렇게 비트화 작업으로 직렬화 시키는 과정
[System.Serializable]
public class Ability
{
    [SerializeField] private int strength = 10;

    public int Strength { get { return strength; } }
    public Ability()           // 생성자
    {       
        Debug.Log("Strength : " +  strength);
    }

    void Update()
    {
        
    }
}
