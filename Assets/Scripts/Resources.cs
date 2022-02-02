using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    [SerializeField] public int pollen;

    public bool haveEnoughPollen(int pollenRequired)
    {
        if (pollen >= pollenRequired)
        {
            this.pollen -= pollenRequired;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void addPollen(int n)
    {
        this.pollen += n;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.pollen = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
