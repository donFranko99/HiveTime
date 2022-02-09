using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wprowadzenie : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        { 
            
            uiObject.SetActive(false);
        }
    }
}
