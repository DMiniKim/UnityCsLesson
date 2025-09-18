using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveforce = 0.0f;
    [SerializeField] Vector3 direction;
 
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        direction.z = Input.GetAxis("Vertical");
        direction.x = Input.GetAxis("Horizontal");

        direction.Normalize();

        // 1. 스페이스바를 누르고 있는 동안 힘을 모읍니다.
        if (Input.GetKey(KeyCode.Space))
        {
            moveforce += Time.deltaTime * 2.0f;
        }

        // 2. 스페이스바에서 손을 떼는 순간 (단 한 번만 실행)
        if (Input.GetKeyUp(KeyCode.Space))
        {

            Vector3 launchDirection = direction;



            rb.AddForce(launchDirection * moveforce, ForceMode.Impulse);

            
            Debug.Log("Jumped with force : " + moveforce);

            
            moveforce = 0.0f;
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction , ForceMode.Force);
    }
}
