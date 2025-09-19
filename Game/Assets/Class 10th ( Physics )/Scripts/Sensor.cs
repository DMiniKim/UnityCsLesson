using UnityEngine;

public class Sensor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {        
        Debug.Log("Trigger Entered by : " + other.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Staying by : " + other.name);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Authorize"))
        {
            other.GetComponent<Control>().SetOriginalPosition();
        }
        Debug.Log("Trigger Exited by : " + other.name);
    }
}
