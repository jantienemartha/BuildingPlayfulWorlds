using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    int leeftijd = 2;
    LineRenderer r;
    Vector3 lijnEind;

    private void Start()
    {
        Destroy(gameObject, 2);
        r = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            lijnEind = hit.point;
        }
        else
        {
            lijnEind = new Vector3(transform.position.x, transform.position.y - 10, transform.position.z);
        }
        
        Vector3[] positions = { transform.position, lijnEind };
        r.SetPositions(positions);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
