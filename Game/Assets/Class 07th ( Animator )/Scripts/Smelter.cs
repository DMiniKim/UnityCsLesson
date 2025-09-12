using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float progress = 0.0f;
    [SerializeField] int acount = 0;
    public void Success()
    {
        Debug.Log("Smelting succeeded!");
    }
    public void Process(float progress)
    {

        this.progress += progress;

        Debug.Log("Progress : " + this.progress + " %");

        if (this.progress >= 100.0f)
        {         
            this.progress = 0.0f;
            acount++;
            this.Enhance(acount);
        }
        
    }
    public void Enhance ( int count )
    {       
        Debug.Log("Enhance : " + count);
    }
}
