using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CharacterControl : NetworkBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;
    public int windSpeed = 5;
    //public GameObject cannon;
    //public GameObject bullet;

    public AudioSource chirp;
    public Material material1;
    public GameObject billboard1;
    public GameObject billboard2;
    public GameObject billboard3;
    public GameObject billboard4;
    public GameObject billboard5;
    public int boostCount = 0;

    Rigidbody rb;
    Transform t;

    public Vector3 windDirection;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();

        windDirection.Set(-1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        //GetComponent<Rigidbody>().velocity = x * 1;
        //rb.velocity += transform.TransformDirection(x) * 10 * Time.deltaTime;
        GetComponent<Rigidbody>().AddForce(windDirection * 1);

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
        {
            //rb.AddForce(t.up * force);
            chirp.Play();
        }

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
            chirp.Play();

            switch (boostCount)
            {
                case 0:
                    billboard1.GetComponent<MeshRenderer>().material = material1;
                    break;
                case 1:
                    billboard2.GetComponent<MeshRenderer>().material = material1;
                    break;
                case 2:
                    billboard3.GetComponent<MeshRenderer>().material = material1;
                    break;
                case 3:
                    billboard4.GetComponent<MeshRenderer>().material = material1;
                    break;
                default:
                    billboard5.GetComponent<MeshRenderer>().material = material1;
                    break;
            }
            boostCount++;
        }

        if (collision.gameObject.tag == "JumpZone")
        {
            rb.AddForce(transform.up * 3000);
        }

    }
}