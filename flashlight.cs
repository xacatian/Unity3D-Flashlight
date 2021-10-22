using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    private bool aciksa;
    public GameObject flashlight1;

    private void Start()
    {
        aciksa = true;
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (aciksa)
            {
                flashlight1.GetComponent<Light>().enabled = false;
                aciksa = false;
            }
            else
            {
                flashlight1.GetComponent<Light>().enabled = true;
                aciksa = true;
            }
        }
    }
}
