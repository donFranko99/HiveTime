using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    bool kwiatekzebrany = false;
  
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider player)
    {
            
        if (player.gameObject.tag == "Player" && kwiatekzebrany == false)
        {
            uiObject.SetActive(true);

        }
    }
    
    void OnTriggerStay(Collider player)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ScoreCount.instance.ScorePoint();
            Destroy(gameObject);
            uiObject.SetActive(false);
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(false);
        }
    }

}