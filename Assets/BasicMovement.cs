using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float _speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(
            Input.GetAxis("Horizontal") * _speed,
            Input.GetAxis("Vertical") * _speed,
            0) * Time.deltaTime);
    }
}
