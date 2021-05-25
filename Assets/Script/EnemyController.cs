using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    Rigidbody rb;
    public int velocity;
    public GameObject Enemy;
    public Transform SpawnPoint;


    void Start ()
    {
        rb = GetComponent < Rigidbody>();
      
    }
    void Update() {
        if (transform.position.x < -202 || transform.position.x > 186)
        {
            transform.position = SpawnPoint.position;
        }
    }
	
	void FixedUpdate ()
    {
        rb.velocity = new Vector3(velocity, 0, 0);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.RespawnPLayer();
        }

        if (other.transform.tag == "Limits")
        {
            this.transform.position = SpawnPoint.transform.position;
        }
    }

    
}
