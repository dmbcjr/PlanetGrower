using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSelection : MonoBehaviour
{
    public List<Material> _colourList = new List<Material>();

    int index;

    private void Awake()
    {
        index = Random.Range(0, _colourList.Count);

        GetComponent<Renderer>().material = _colourList[index];
    }
}
