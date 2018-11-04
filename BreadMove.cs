using UnityEngine;
using System.Collections;

public class BreadMove : MonoBehaviour {

	public int speed = 0;
	
	void Update () {
		transform.Translate(Vector3.down * speed * Time.deltaTime);
	}

	void OnBecameInvisible() {
        Destroy(gameObject);
    }
}
