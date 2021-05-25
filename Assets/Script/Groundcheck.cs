using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour {
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            GameManager.instance.grounded = true;
        }        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            GameManager.instance.grounded = false;
        }
    }
}
