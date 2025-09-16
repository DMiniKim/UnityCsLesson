using System.Collections.Generic;
using Unity.VisualScripting;
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
    }
    private void Update()
    {
        float eventTime = 5.0f;
        time += Time.deltaTime;
        if (time >= eventTime)
        {
            Appear();
            time = 0.0f;
        }
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


}
