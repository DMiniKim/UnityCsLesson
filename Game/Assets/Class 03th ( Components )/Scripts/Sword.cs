using UnityEngine;

public class Sword : Item
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
    public override void Activate()
    {
        Debug.Log("Sword Activated");
    }
}
