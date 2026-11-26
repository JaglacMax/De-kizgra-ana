using UnityEngine;
using UnityEngine.InputSystem;

public class Skript : MonoBehaviour
{
    public GameObject djuro;
    public float moveSpeed = 5;
    public float runBoost = 1f;
    bool isActive;
    public Key left = Key.A;
    public Key right = Key.D;
    public Key forward = Key.W;
    public Key backward = Key.S;
    public Key up = Key.Space;
    public Key down = Key.LeftCtrl;
    public Key yawLeft = Key.Q;
    public Key yawRight = Key.E;
    public Key run = Key.LeftShift;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[run].isPressed)
        {
            runBoost = 2f;
        }
        else
        {
            runBoost = 1f;
        }
        if (Keyboard.current[left].isPressed)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Keyboard.current[right].isPressed)
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }
        if (Keyboard.current[up].isPressed)
        {
            transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
        if (Keyboard.current[down].isPressed)
        {
            transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }
        if (Keyboard.current[forward].isPressed)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * runBoost);
        }
        if (Keyboard.current[backward].isPressed)
        {
            transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Keyboard.current[yawLeft].isPressed)
        {
            transform.Rotate(0, -45 * Time.deltaTime * moveSpeed, 0);
        }
        if (Keyboard.current[yawRight].isPressed)
        {
            transform.Rotate(0, 45 * Time.deltaTime * moveSpeed, 0);
        }



    }
}
