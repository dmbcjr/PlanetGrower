using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float _Speed;

    public GameObject _backGround;

    // Update is called once per frame
    void Update()
    {

        PlayerMove();

    }

    private void PlayerMove()
    {

        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Target.z = transform.position.z;

       // float dist = Vector2.Distance(transform.position, Target);
       // Debug.Log(dist);

        //if (dist < 2)
        //{
        //    _positionBarrier = 1.2f;

        //}
        //else if (dist < 1)
        //{
        //    _positionBarrier = 2;
        //}
        //else if (dist < .02)
        //{
        //    _positionBarrier = 10;
        //}
        //else if (dist < .005)
        //{
        //    _positionBarrier = 100;
        //}
        //else
        //{
        //    _positionBarrier = 1;
        //}

        transform.position = Vector3.MoveTowards(transform.position, Target, _Speed * Time.deltaTime / transform.localScale.x);

        //_backGround.transform.position = Vector3.MoveTowards(transform.position, Target, .1f * Time.deltaTime / transform.localScale.x );
    }

   
}
