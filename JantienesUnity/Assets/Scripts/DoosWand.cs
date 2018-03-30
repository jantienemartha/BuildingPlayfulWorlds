using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoosWand : MonoBehaviour {

    public float force;
    public Transform forcePoint;
    public void Open()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddExplosionForce(force, forcePoint.position, 5);
    }
}
