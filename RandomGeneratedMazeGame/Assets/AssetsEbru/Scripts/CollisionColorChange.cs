using UnityEngine;
using System.Collections;

public class CollisionColorChange : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

     void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="Untagged")
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[2];
        }
    }

}
