using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomAudio : MonoBehaviour {

    AudioSource source;
    public AudioClip background;
    public bool isPlaying = false;

    public static CustomAudio instance;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        source.clip = background;
        source.Play();
	}

    public IEnumerator PlayOneShot(AudioClip clip)
    {
        if (!isPlaying)
        {
            isPlaying = true;
            source.PlayOneShot(clip);
            yield return new WaitForSeconds(clip.length);
            isPlaying = false;
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
