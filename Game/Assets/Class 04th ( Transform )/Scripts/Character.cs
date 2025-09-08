using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed ;
    private void Start()
    {
        speed = 15.0f;
        transform.position = new Vector3(1, 1, 1);
    }
    private void Update()
    {
        Direction();
    }
    void Direction()
    {
        direction.x = Input.GetAxisRaw("Horizontal"); 
        
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
        // Time.deltaTime
        // 한 프레임 당 실행하는 시간
        transform.position += direction * Time.deltaTime * speed;

        Debug.Log(transform.position);
        Debug.Log(Camera.main);
    }

}
