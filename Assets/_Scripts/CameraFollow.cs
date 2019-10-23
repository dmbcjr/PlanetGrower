using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
  
    public GameObject _player;
    public float _Speed;

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        CameraMove();

    }

    private void CameraMove()
    {

        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, Target, _Speed * Time.deltaTime / _player.transform.localScale.x);
    }
}
