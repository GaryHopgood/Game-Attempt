using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }

    float fireRate = 0.1f;
    float nextShot = 0.0f;
    // Update is called once per frame
    void Update() {


        float speed;
        speed = 6;

        transform.rotation = Quaternion.Euler(-90.0f, 270.0f, -90.0f);

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(-60, 270.0f, -90.0f);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1.0f, 0.0f, 0.0f) * speed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(-120, 270.0f, -90.0f);
        }

        if (Input.GetKey(KeyCode.Space) && (Time.time > nextShot))
        {
            Instantiate(GameObject.Find("Bullet"), transform.position, transform.rotation);
            nextShot = Time.time + fireRate;
        }

       
    }
}
