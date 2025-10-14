using UnityEngine;
using UnityEngine.Video;

public class DataManager : MonoBehaviour
{
    [SerializeField] int channel;
    Television television;
    void Awake()
    {
        //television = GetComponentInParent<Television>();
        channel = PlayerPrefs.GetInt("Channel", 0);
        PlayerPrefs.SetInt("Channel", channel);
        Save();
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
