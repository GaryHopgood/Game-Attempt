using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
    }

    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(0.0f, 0.0f, 2.0f) * 6 * Time.deltaTime;
        if ("Bullet(Clone)" == gameObject.name)
        { 
        Destroy(gameObject, 2.0f);
        }
    }

}
