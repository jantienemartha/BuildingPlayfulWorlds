using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePlatform : MonoBehaviour {

    public float downTime;
    public float dangerTime;
    public bool danger;
    GameObject gevaarReep;
    GameObject veiligeReep;

	// Use this for initialization
	void Start () {
        gevaarReep = transform.GetChild(0).gameObject;
        veiligeReep = transform.GetChild(1).gameObject;
        StartCoroutine(dangerOff());
        Debug.Log(transform.childCount);
        
    }
	

    IEnumerator dangerOn()
    {

        danger = true;
        veiligeReep.SetActive(false);
        gevaarReep.SetActive(true);
        yield return new WaitForSeconds(dangerTime);
        StartCoroutine(dangerOff());
    }

    IEnumerator dangerOff()
    {
        danger = false;
        veiligeReep.SetActive(true);
        gevaarReep.SetActive(false);
        
        yield return new WaitForSeconds(downTime);
        StartCoroutine(dangerOn());    
    }

    private void OnCollisionStay(Collision collision)
    {
        if (danger)
        {
            if (collision.transform.tag=="Player")
            {
                //doe iets gevaarlijks
                Debug.Log("Boem je bent dood");
            }
        }
    }


}
