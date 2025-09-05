using System;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] Item[] gameObjects;
   
    [SerializeField] private int weaponIndex = 0;
    private void Start()
    {
        
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].transform.gameObject.SetActive(false);
            //Debug.Log(gameObjects[i].name);

        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Swap();
        if (Input.GetMouseButtonDown(0)) gameObjects[weaponIndex].Activate();
    }

    void Swap()
    {

        if (gameObjects[weaponIndex].transform.gameObject.active == false)
        {
            gameObjects[weaponIndex].transform.gameObject.active = true;
        }
        else
        {
            gameObjects[weaponIndex++].transform.gameObject.SetActive(false);
            weaponIndex %= gameObjects.Length;
            gameObjects[weaponIndex].transform.gameObject.SetActive(true);
        }
        

    }
    
}
