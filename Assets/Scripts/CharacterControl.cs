using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterControl : NetworkBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;
    //public GameObject cannon;
    //public GameObject bullet;

    Rigidbody rb;
    Transform t;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            //rb.velocity += this.transform.forward * speed * Time.deltaTime;
            t.rotation *= Quaternion.Euler(-rotationSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S)) {
            //rb.velocity -= this.transform.forward * speed * Time.deltaTime;
            t.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
            t.rotation *= Quaternion.Euler(0, 0, -rotationSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            t.rotation *= Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            t.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(t.up * force);

        /*
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 15;
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 750);
        }
        */
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SpeedBoost")
        {
            speed = speed + 5;
            Debug.Log("Speed Boost");
            Debug.Log("Speed: " + speed);
        }
    }
}