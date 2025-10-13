using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] float maxDistance = 100f;
    [SerializeField] RaycastHit rayCastHit;
    [SerializeField] LayerMask layerMask;
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red,3f);
            if ( Physics.Raycast(ray, out rayCastHit, maxDistance,layerMask))
            {
               rayCastHit.collider.GetComponent<HealthBar>().Damage(50f);
            }
            
        }
    } 
}
