using UnityEngine;

public class Kamera : MonoBehaviour
{
    
    [SerializeField] Transform prati;
    public Vector3 po;


    // Update is called once per frame
    void Update()
    {
        transform.position = prati.transform.position + po;
    }

}
