using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour
{

    public GameObject myPrefabObject = null;


    // Start is called before the first frame update
    void Start()
    {


        Instantiate(myPrefabObject, transform.position, Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
