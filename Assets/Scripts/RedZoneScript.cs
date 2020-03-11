using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RedZoneScript : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public RedScoreScript scoreManager;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");

        if (collision.gameObject.tag == "motherboard")
        {
            scoreManager.AddMotherboardPoint();
            Debug.Log("Motherboard here");
        }

        if (collision.gameObject.tag == "processor")
        {
            scoreManager.AddProcessorPoint();
            Debug.Log("Processor here");
        }

        if (collision.gameObject.tag == "memory")
        {
            scoreManager.AddMemoryPoint();
            Debug.Log("Memory here");
        }

        if (collision.gameObject.tag == "hardDrive")
        {
            scoreManager.AddHDDPoint();
            Debug.Log("Hard Drive here");
        }

        if (collision.gameObject.tag == "graphicsCard")
        {
            scoreManager.AddGPUPoint();
            Debug.Log("Graphics Card here");
        }
    }

}
