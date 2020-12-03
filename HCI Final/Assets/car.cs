using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.eulerAngles.y == 270)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
        else if (gameObject.transform.eulerAngles.y == 90)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 0.1f, gameObject.transform.position.y, gameObject.transform.position.z);
        

        //OnCollisionEnter();
    }

    void OnCollisionEnter(Collision collision)
    {
      
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tunnel")
            Destroy(gameObject);
    }
}
