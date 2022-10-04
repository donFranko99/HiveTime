using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    [SerializeField] private int pollen = 0;
    [SerializeField] private int stamina = 100;


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

    public void resetStaminaPoints()
    {
        this.stamina = 100;
    }

    public void addStamina(int n)
    {
        stamina += n;
        if (stamina > 100)
            stamina = 100;
    }

    public void addPollen(int n)
    {
        this.pollen += n;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            
        }
    }
}
