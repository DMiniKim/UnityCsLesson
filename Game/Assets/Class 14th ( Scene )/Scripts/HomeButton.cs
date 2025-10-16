
using UnityEngine;
using UnityEngine.InputSystem.Composites;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    GameObject sceneryManager;
    Button button;

    private void Awake()
    {
        sceneryManager = GameObject.Find("SceneryManager");
        //sceneryManager.GetComponent<SceneryManager>();
        button = GetComponent<Button>();
    }

    private void Start()
    {        
        button.onClick.AddListener(sceneryManager.GetComponent<SceneryManager>().HomeButton);
    }
}
