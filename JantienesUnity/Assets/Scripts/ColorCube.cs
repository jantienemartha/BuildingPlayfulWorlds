using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour {

    List<Color> colors;
    Renderer r;
    public Color huidigeKleur;
    public GameObject cpPost;

    int currentColor = 0;
	// Use this for initialization
	void Start () {
        r = GetComponent<Renderer>();
        colors = new List<Color>();
        colors.Add(Color.blue);
        colors.Add(Color.red);
        colors.Add(Color.green);
        colors.Add(Color.magenta);
        r.material.color = colors[currentColor];
        huidigeKleur = r.material.color;
	}

    private void OnCollisionEnter(Collision collision)
    {
        currentColor = (currentColor + 1) % colors.Count;
        r.material.color = colors[currentColor];
        huidigeKleur = r.material.color;
    }

    public bool VergelijkKleur()
    {
        return cpPost.GetComponent<CheckpointPost>().color == huidigeKleur;
    }

}
