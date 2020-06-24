using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //TO-DO - wishlist
    //Generate food randomly 
    //Later into Development the food should be random sizes dependant on the size of the player
    //ie higher chance of smaller food to eat/ but smaller chance of bigger food that can devour the player
    //also brainstorm a better name than food for this type of object

    public GameObject Food;
    public float _Speed = 1f;

    void Start()
    {
        //invoke gen function 
        InvokeRepeating("FoodGeneration", 0, _Speed);

    }

    void FoodGeneration()
    {
       
        //get random x y coordinates    
        int x = Random.Range(0, Camera.main.pixelWidth);
        int y = Random.Range(0, Camera.main.pixelHeight);

        Vector3 Target = Camera.main.ScreenToWorldPoint(new Vector3(x, y, 0));

        Target.z = 0;

        Instantiate(Food, Target, Quaternion.identity);
    }
}
