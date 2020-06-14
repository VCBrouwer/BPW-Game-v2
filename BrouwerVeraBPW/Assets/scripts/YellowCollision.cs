using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCollision : MonoBehaviour
{
    public Material [] material;
    Renderer rend;

    public Transform Pilaar;

    // Start is called before the first frame update
    void Start()
    {
        rend = Pilaar.GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material [0];
        
    }


void OnCollisionEnter (Collision collision)
{
    Debug.Log("grond");
    if (collision.transform.tag == "Doos")
    {
        Debug.Log("materialswitch");
        rend.sharedMaterial = material [1];
    }
}
    
}