using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveforce = 0.0f;
    [SerializeField] Vector3 direction;
    [SerializeField] Vector3 originalPosition;

    private void Awake()
    {
        originalPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        direction.z = Input.GetAxis("Vertical");
        direction.x = Input.GetAxis("Horizontal");

        direction.Normalize();
                
        if (Input.GetKey(KeyCode.Space))
        {
            moveforce += Time.deltaTime * 2.0f;
        }
                
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 launchDirection = direction;

            rb.AddForce(launchDirection * moveforce, ForceMode.Impulse);
                        
            //Debug.Log("Jumped with force : " + moveforce);
                        
            moveforce = 0.0f;
        }
    }
    private void FixedUpdate()
    {
        rb.AddForce(direction , ForceMode.Force);
    }

    public Vector3 GetOriginalPosition()
    {
        return originalPosition;
    }
    public void SetOriginalPosition()
    {
        rb.position = originalPosition;

        rb.linearVelocity = Vector3.zero;

        rb.angularVelocity = Vector3.zero;
    }
}
