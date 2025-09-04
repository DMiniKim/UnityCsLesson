using System;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    private int weaponIndex = 0;
    private void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
            //Debug.Log(gameObjects[i].name);

        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObjects[weaponIndex].active == false)
            {
                gameObjects[weaponIndex].active = true;
            }
            else
            {
                gameObjects[weaponIndex++].SetActive(false); 
                weaponIndex %= 5;
                gameObjects[weaponIndex].SetActive(true);
            }
        }
    }

}
