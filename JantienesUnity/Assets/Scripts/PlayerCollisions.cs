using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

    public AudioClip dangerClip;

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Checkpoint")
        {
            GetComponent<Checkpoints>().SetCheckpoint(hit.gameObject);
        }
        if (hit.gameObject.tag == "Danger")
        {
            StartCoroutine(CustomAudio.instance.PlayOneShot(dangerClip));
            Respawn();
        }
    }

    private void OnCollisionStay(Collision hit)
    {
        if (hit.gameObject.tag == "Danger")
        {
            StartCoroutine(CustomAudio.instance.PlayOneShot(dangerClip));
            Respawn();
        }
    }

    //Werkt om een of andere reden niet.
    public void Respawn()
    {
        transform.position = GetComponent<Checkpoints>().currentCheckpoint.transform.position;
        //gameObject.transform.position = spawnpoint;
    }

}
