using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class Jumper : Agent
{
    [SerializeField] private float jumpForce;
    [SerializeField] private KeyCode jumpKey;

    private bool jumpIsReady = true;
    private Rigidbody rBody;
    private Vector3 startingPosition;
    private int score = 0;
    public event Action OnReset;
    private int divideByThree = 0;

    public override void Initialize()
    {
        rBody = GetComponent<Rigidbody>();
        startingPosition = transform.position;
    }

    private void FixedUpdate()
    {
        if(jumpIsReady)
            RequestDecision();
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        if (Mathf.FloorToInt(vectorAction[0]) == 1)
            Jump();
    }

    public override void OnEpisodeBegin()
    {
        Reset();
    }

    public override void Heuristic(float[] actionsOut)
    {
        actionsOut[0] = 0;
        if (Input.GetKey(jumpKey))
            actionsOut[0] = 1;
    }

    private void Jump()
    {
        if (jumpIsReady)
        {
            rBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.VelocityChange);
            jumpIsReady = false;
        }
    }


    private void Reset()
    {
        score = 0;
        jumpIsReady = true;

        //Reset Movement and Position
        transform.position = startingPosition;
        rBody.velocity = Vector3.zero;

        OnReset?.Invoke();
    }

    private void OnCollisionEnter(Collision collidedObj)
    {
        if (collidedObj.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("INSIDE ENEMY");
            AddReward(-1.0f);
            Debug.Log(GetCumulativeReward());
            score = 0;
            ScoreCounter.Instance.ResetScore();
            EndEpisode();

        }
        if (collidedObj.gameObject.CompareTag("Floor"))
        {
            Debug.Log("INSIDE FLOOR");
            jumpIsReady = true;
        }

        
            
    }

    private void OnTriggerEnter(Collider collidedObj)
    {

        if (collidedObj.gameObject.CompareTag("Score"))
        {
            divideByThree++;
            if (divideByThree % 3 == 0)
            {
                AddReward(0.1f);
                Debug.Log(GetCumulativeReward());
                score++;
                ScoreCounter.Instance.AddScore(score);
            }
            
        }
    }
}
