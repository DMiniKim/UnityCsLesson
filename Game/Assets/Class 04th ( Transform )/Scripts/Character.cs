using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Move))]
public class Character : MonoBehaviour
{
    [SerializeField] Move move;
    private void Awake()
    {
        move = GetComponent<Move>();        
    }
    private void Start()
    {
        move.speed = 15.0f;

        transform.position.Set(1,1,1);                
    }
    private void Update()
    {
       move.OnMove(new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical")));
    }
    

}
