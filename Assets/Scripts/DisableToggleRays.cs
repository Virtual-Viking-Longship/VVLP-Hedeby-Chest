using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableToggleRays : MonoBehaviour
{
    [SerializeField] private GameObject leftRay;
    [SerializeField] private GameObject rightRay;

    
    private ToggleRay leftToggleRay;
    private ToggleRay rightToggleRay;

    void Start()
    {
     
        leftToggleRay = leftRay.GetComponent<ToggleRay>();
        rightToggleRay = rightRay.GetComponent<ToggleRay>();

       
    }

    public void ToggleDisable()
    {
       
    //     if (leftToggleRay != null){
    //         leftToggleRay.enabled = false;

    //     }
         
    //     if (rightToggleRay != null){
    //         rightToggleRay.enabled = false;

    //     }

        leftToggleRay.enabled = false;
        rightToggleRay.enabled = false;
    }
}






