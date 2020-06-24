using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devour : MonoBehaviour
{
    public string Tag;

    public float sizeIncrease = .1f;
    float perc;
    float lerpTime = 1f;
    float currentLerpTime;
    bool canGrow;
    Vector3 sizeToGrow;
    Vector3 sizeTemp;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            currentLerpTime = 0f;
            
            Destroy(other.gameObject);
            sizeTemp = transform.localScale;

            sizeToGrow = sizeTemp;
            
            
            sizeToGrow += new Vector3(sizeIncrease, sizeIncrease, sizeIncrease);
            sizeTemp = sizeToGrow;
            canGrow = true;
        }
    }

    private void Update()
    {

        
            GrowPlayer();
        Debug.Log("Size temp: "+sizeTemp);
        Debug.Log("Size grow: " + sizeToGrow);


    }
    private void GrowPlayer()
    {


        //increment timer once per frame
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime)
        {

            currentLerpTime = lerpTime;

        }
     
        perc = currentLerpTime / lerpTime;

        if (canGrow)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, sizeToGrow, perc);
            if (currentLerpTime == 1f)
            {
                canGrow = false;
            }
        }
        


        
    }
}
