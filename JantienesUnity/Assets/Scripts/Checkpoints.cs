using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

    public List<GameObject> checkpoints;
    public GameObject currentCheckpoint;



    // Use this for initialization
    void Start()
    {
        currentCheckpoint = checkpoints[0];
    }

    public void SetCheckpoint(GameObject checkpoint)
    {
        if (checkpoints.IndexOf(checkpoint) > checkpoints.IndexOf(currentCheckpoint))
        {
            currentCheckpoint = checkpoint;
        }
    }

    public void Respawn()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        transform.position = currentCheckpoint.GetComponent<Checkpoint>().spawnPoint.position;
        rb.isKinematic = false;
    }
}
