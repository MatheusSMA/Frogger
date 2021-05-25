using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public int force;    
    public Transform checkground;
    bool grounded;
    public bool inPlataform;

    void Start ()
    {
        rb = GetComponent < Rigidbody>();
	}
	
	
	void Update ()
    {

        

        if (GameManager.instance.grounded == false)
        {
            return;
            //não andar mais

        }
        
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0, 0, force);
            }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.z > -35.6f)
        {
            if (inPlataform && transform.position.z < 45&&(transform.position.x<-84f||transform.position.x>105.8f))
            {
                return;
            }
            else
            {
                transform.position += new Vector3(0, 0, -force);
            }
        }
            if (Input.GetKeyDown(KeyCode.LeftArrow)&&(transform.position.x>-84f || inPlataform))
            {
                transform.position += new Vector3(-force, 0, 0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow) &&( transform.position.x < 105.8f || inPlataform))
            {
                transform.position += new Vector3(force, 0, 0);
            }
        
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(checkground.position,2);
        Gizmos.color = Color.red;
    }
}
