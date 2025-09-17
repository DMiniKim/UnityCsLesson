using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;


public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] List<GameObject> unitlist;
    [SerializeField] int count = 0;
    [SerializeField] float time = 0.0f;


    private void Start()
    {
        Initialize();
        StartCoroutine(RandomIndex());
    }
    private void Update()
    {
       
    }

    void Appear()
    {
        for (int i = 0; i < unitlist.Count; i++)
        {
            if (unitlist[i].activeSelf == true) continue;
            else
            {
                unitlist[i].SetActive(true);
                Debug.Log("Unit Appear");
                break;
            }
        }

    }
    void Initialize()
    {
        unitlist.Capacity = 10;
        for (int i = 1; i < count; i++)
        {
            GameObject clone = Instantiate(prefab, gameObject.transform);
            clone.SetActive(false);
            unitlist.Add(clone);
        }
    }
    IEnumerator Coroutine()  // 코루틴 함수
    { 
        Debug.Log("Coroutine Start");

        yield return new WaitForSeconds(5.0f);

        Debug.Log("Coroutine End");
    }
    // 이걸 쓰기 위해선 DeleyedCallManager.cs 가 필요하다.
    // StartedCoroutine(Couroutine()); 이런 느낌.


    IEnumerator RandomIndex()
    {
        float cooltime = 1.0f + (time * 0.1f);
        
        WaitForSeconds wait = new WaitForSeconds(5.0f* cooltime);
        while (true)
        {
            yield return wait;

            int index = Random.Range(0, unitlist.Count);
            if (unitlist[index].activeSelf == true)
            { 
                index++;
                if (index >= unitlist.Count) index = 0;
                unitlist[index].SetActive(true);
            }
            else
            {
                unitlist[index].SetActive(true);
                Debug.Log("Unit Appear");
            }
            int count = 0;
            for (int i = 0; i < unitlist.Count; i++)
            {
                if (unitlist[i].activeSelf == true) count++;
            }
            if (count == unitlist.Count)
            {
                Debug.Log("All Unit Appear");
                yield break;
            }
        }
    }
}
// 5초마다 인덱스를 받음.
// 인덱스에 접근해서 활성화 
// 활성화 되있으면 인덱스 +1 활성화
// 전부 활성화 되어있을 시 반복문 종료 break;