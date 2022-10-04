using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Landing : MonoBehaviour
{
    public BoxCollider collider;

    [SerializeField] public Resources beeResources;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter()
    {
        if (beeResources.haveEnoughPollen(20))
        {
            //pop message - thank you for trying our games' pre alpha demo
            //quit game after pressing escape
            SceneManager.LoadScene("testworld");
        }
        else
        {
            beeResources.resetStaminaPoints();
        }
    }
}
