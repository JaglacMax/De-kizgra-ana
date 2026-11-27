using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Zadatak2 : MonoBehaviour
{
    Rigidbody rb;
    public float mass;
    Key kinematika = Key.K;
    Key gravitacija = Key.G;
    Key forward = Key.W;
    Key back = Key.S;
    Key left = Key.A;
    Key right = Key.D;


    void Awake()
    {
        gameObject.AddComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }


    void Start()
    {
        var gravitationOffAtStart = false;
        rb.useGravity = gravitationOffAtStart;
    }

    
    void Update()
    {
        if (Keyboard.current[gravitacija].wasPressedThisFrame)
            rb.useGravity = !rb.useGravity;
        if (Keyboard.current[kinematika].wasPressedThisFrame)
            rb.isKinematic = !rb.isKinematic;
        if (Keyboard.current[forward].isPressed)
            rb.AddForce(Vector3.forward * 0.0001f * Time.deltaTime);
        if (Keyboard.current[back].isPressed)
            rb.AddForce(Vector3.back * 0.0001f * Time.deltaTime);
        if (Keyboard.current[left].isPressed)
            rb.AddForce(Vector3.left * 0.0001f * Time.deltaTime);
        if (Keyboard.current[right].isPressed)
            rb.AddForce(Vector3.right * 0.0001f * Time.deltaTime);
    }
}
