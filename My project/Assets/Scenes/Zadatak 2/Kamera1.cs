using UnityEngine;

public class Kamera1 : MonoBehaviour
{
    [SerializeField] Transform follow;
    public Vector3 po;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = follow.transform.position + po;
    }
}
