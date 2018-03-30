using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doos : MonoBehaviour {

    public List<GameObject> wanden;

    public void OpenDoos()
    {
        foreach (GameObject wand in wanden)
        {
            wand.GetComponent<DoosWand>().Open();
        }
    }
}
