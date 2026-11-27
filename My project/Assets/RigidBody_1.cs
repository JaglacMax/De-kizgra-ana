using UnityEngine;

public class RigidBody_1 : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Start()
    {
        //rb.AddForce(Vector3.left*2000);
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"{other.gameObject.name} is inside the block");
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"{other.gameObject.name} has not left the block");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log($"{other.gameObject.name} has left the block");
        }
    }
}
