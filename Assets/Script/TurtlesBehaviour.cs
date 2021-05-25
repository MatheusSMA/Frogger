using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtlesBehaviour : MonoBehaviour
{


    Rigidbody rb;
    public int velocityTurtle;
    public Transform spawn;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update() {
        if (transform.position.x<-202||transform.position.x>186)
        {
            transform.position = spawn.position;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(velocityTurtle, 0, 0);
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collider.transform.parent = this.gameObject.transform;
            collider.GetComponent<PlayerController>().inPlataform = true;


        }
    }
    public void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.transform.parent = null;
            collider.GetComponent<PlayerController>().inPlataform = false;

        }
    }

}
