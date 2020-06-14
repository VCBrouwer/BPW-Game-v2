using System.Collections;
using UnityEngine;

public class BlueCollision : MonoBehaviour
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


void OnCollisionEnter (Collision hit)
{
    if (hit.gameObject.tag == "Doos2")
    {
        rend.sharedMaterial = material [1];
    }
}
    
}
