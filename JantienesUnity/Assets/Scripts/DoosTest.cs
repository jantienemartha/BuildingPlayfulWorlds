using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoosTest : MonoBehaviour {

    public GameObject doos;

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            doos.GetComponent<Doos>().OpenDoos();
        }
	}
}
