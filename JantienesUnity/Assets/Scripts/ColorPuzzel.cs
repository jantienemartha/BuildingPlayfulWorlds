using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPuzzel : MonoBehaviour {

    public List<GameObject> colorCubes;
    public List<GameObject> box;
    bool boxOpen = false;
    public Animator animatie;
    public AudioClip amazing;

	
	// Update is called once per frame
	void Update () {
        if (puzzelComplete() && !boxOpen)
        {
            foreach (GameObject wand in box)
            {
                wand.GetComponent<Rigidbody>().isKinematic = false;
                wand.GetComponent<DoosWand>().Open();
                
            }
            animatie.SetTrigger("TaartTrigger");
            StartCoroutine(CustomAudio.instance.PlayOneShot(amazing));
            boxOpen = true;
        }
	}

    bool puzzelComplete()
    {
        bool puzzelComplete = true;
        foreach (GameObject colorCube in colorCubes)
        {
            if (!colorCube.GetComponent<ColorCube>().VergelijkKleur())
            {
                puzzelComplete = false;
                break;
            }
        }
        return puzzelComplete;
    }
}
