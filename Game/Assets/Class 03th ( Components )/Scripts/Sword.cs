using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();    
        
    }
    void Start()
    {
        meshRenderer.material.color = Color.magenta;
    }

    
    void Update()
    {
    }
}
