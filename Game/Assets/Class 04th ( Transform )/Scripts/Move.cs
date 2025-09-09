using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public void OnMove(Vector3 vector3)
    {
        direction = vector3;
        
        direction.Normalize();

        transform.position += direction * Time.deltaTime * speed;
    }
    


}
