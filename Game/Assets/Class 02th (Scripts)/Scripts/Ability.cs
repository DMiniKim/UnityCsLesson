using UnityEngine;

// �����͸� ������ ���� �� 0�Ǵ� 1�̷��� ��Ʈȭ �۾����� ����ȭ ��Ű�� ����
[System.Serializable]
public class Ability
{
    [SerializeField] private int strength = 10;

    public int Strength { get { return strength; } }
    public Ability()           // ������
    {       
        Debug.Log("Strength : " +  strength);
    }

    void Update()
    {
        
    }
}
