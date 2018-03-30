using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public List<GameObject> lijst;  

    public GameObject bulletPrefab;


    // Use this for initialization
    void Start()
    {

        lijst = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        ControleerLijst();

        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.parent.GetComponent<Checkpoints>().Respawn();
        }

        if (lijst.Count < 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Quaternion angle = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
                GameObject bullet = Instantiate(bulletPrefab, transform.position + transform.forward, Quaternion.identity);
                Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();

                rigidbody.AddForce(transform.forward * 1000);
                lijst.Add(bullet);
                //StartCoroutine(VerwijderBal(bullet,2));
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (lijst.Count > 0)
            {
                GameObject laatsteBullet = lijst[lijst.Count - 1];
                transform.parent.transform.position = laatsteBullet.transform.position;
                //StartCoroutine(VerwijderBal(laatsteBullet, 0));
            }
        }

    }

    public void ControleerLijst()
    {
        for (int i = lijst.Count - 1; i >= 0; i--)
        {
            if (lijst[i] == null)
            {
                lijst.RemoveAt(i);
            }
        }
    }


}