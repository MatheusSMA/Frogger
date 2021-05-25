using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public PlayerController pc;
    public bool grounded;

    public static GameManager instance;

    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void RespawnPLayer()
    {
        pc.transform.position = new Vector3(-5, 4.18f, -35.6f);
    }

    public void Win()
    {
        RespawnPLayer();

    }
}