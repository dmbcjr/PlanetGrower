using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseUV : MonoBehaviour
{
    public float _parallax = 2f;
    // Update is called once per frame
    void Update()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();

        Material mat = mr.material;

        Vector2 offset = mat.mainTextureOffset;
         
        offset.x = transform.position.x / transform.localScale.x / _parallax;
        offset.y = transform.position.y / transform.localScale.y / _parallax; 

        mat.mainTextureOffset = offset;

        
    }
}
