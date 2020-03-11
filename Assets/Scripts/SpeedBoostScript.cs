using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpeedBoostScript : NetworkBehaviour
{
    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log("Destroyed Speed Boost");
    }

    public void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }
}
