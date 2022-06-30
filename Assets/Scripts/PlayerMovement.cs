using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float horMove;
    public float verMove;
    //public AudioSource footSteps;
    
    void Update()
    {
        Movement();
        //InstantiateSound();
    }

    void Movement()
    {
        horMove = Input.GetAxis("Horizontal");
        verMove = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horMove,0,verMove) * playerSpeed * Time.deltaTime);
    }
/*
    void InstantiateSound()
    {
        if (horMove != 0 || verMove != 0)
        {
            Instantiate(footSteps);
        }
        else
        {
            Destroy(footSteps);
        }
    }
    */
}
