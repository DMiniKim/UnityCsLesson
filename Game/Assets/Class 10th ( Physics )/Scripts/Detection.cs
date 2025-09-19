using UnityEngine;
using UnityEngine.Events;

public class Detection : MonoBehaviour
{
 
    [SerializeField] UnityEvent callBack;
    private void Awake()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Authorize"))
        {
            return;
        }        
        if (callBack != null)
        {
            callBack.Invoke();
        }

        Debug.Log("Collision Enter");
        
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Collision Stay");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Collision Exit");
    }

}
