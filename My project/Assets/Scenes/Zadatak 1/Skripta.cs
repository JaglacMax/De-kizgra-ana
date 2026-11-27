using UnityEngine;
using UnityEngine.InputSystem;

public class Skripta : MonoBehaviour
{
    Rigidbody rb;
    Key gravitacija = Key.Space;
    Key otkljucavanje = Key.U;
    Key zakljucavanje = Key.F;
    Key explosion = Key.B;
    Vector3 pointOfExplosion = new Vector3(5, 5, 5);

    void Awake()
    {
        
            rb = GetComponent<Rigidbody>();
        
    }

    void Start()
    {

        rb.AddForce(Vector3.right * 20);
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ;
    }

   
    void Update()
    {
        if (Keyboard.current[gravitacija].wasPressedThisFrame)
        {
            rb.useGravity = !rb.useGravity;
        }
        if (Keyboard.current[otkljucavanje].wasPressedThisFrame)
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        if (Keyboard.current[zakljucavanje].wasPressedThisFrame)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }
        //rb.AddForce(Vector3.right * 20);
        /*if (Keyboard.current[explosion].wasPressedThisFrame)
        {
            rb.AddExplosionForce(2000, pointOfExplosion, 0, 3.0f);
        }*/
        Collider[] colliders = Physics.OverlapSphere(pointOfExplosion, 20000);
        if (Keyboard.current[explosion].wasPressedThisFrame)
            foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(2000, pointOfExplosion, 0, 3.0F);
        }

    }
}
