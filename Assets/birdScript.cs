using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive=false;
    public AudioSource crash;
    public PipeSpwanScript pipeSpwan;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
            StartScreen();

        if (transform.position.y>=11.5||transform.position.y<=-10.5)
        {
            endGame();
        }
        if (Input.GetKeyDown(KeyCode.Space)==true && birdIsAlive==true)
        {
        myRigidbody.velocity = Vector2.up * flapStrength;
        }

        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        endGame();
    }
    public void endGame()
    {
        crash.Play();
        logic.gameOver();
        birdIsAlive = false;
    }
    public void StartScreen()
    {
       
            logic.StartGame();
        birdIsAlive=true;
        myRigidbody.gravityScale = 1;
        pipeSpwan.isStarted = true;
        

    }
}
