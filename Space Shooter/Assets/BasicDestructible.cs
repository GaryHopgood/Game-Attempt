using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicDestructible : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    float health = 50.0f;

	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bullet(Clone)")
        {
            Destroy(col.gameObject);
            health -= 2;
        }
    }
}
