using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liftbal : MonoBehaviour {

    public Vector3 pos1;
    public Vector3 pos2;
    public float speed;

	// Use this for initialization
	void Start () {
        transform.position = pos1 + Vector3.up;
        StartCoroutine(Move(pos2));
	}
	


    IEnumerator Move(Vector3 target)
    {
        while (Mathf.Abs((target - transform.localPosition).y) > 0.20f)
        {
            Vector3 direction = target.y == pos2.y ? Vector3.up : Vector3.down;
            transform.localPosition += direction * Time.deltaTime * speed;

            yield return null;
        }

        yield return new WaitForSeconds(0.5f);

        Vector3 newTarget = target.y == pos1.y ? pos2 : pos1;

        StartCoroutine(Move(newTarget));
    }

}
