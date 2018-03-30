using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointPost : MonoBehaviour {

    public Color color;
    Renderer r;
	// Use this for initialization
	void Start () {
        r = GetComponent<Renderer>();
        r.material.color = color;
	}
}
