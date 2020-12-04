using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class car : MonoBehaviour
{
    private Move move;
    private bool playerJoined = false;
    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType<Move>();
    }

    // Update is called once per frame
    void Update()
    {
         if(PhotonNetwork.CurrentRoom.PlayerCount == 2 && playerJoined == false)
        {
            move = GameObject.Find("Player(Clone)").GetComponent<Move>();
            playerJoined = true;
            Debug.Log("I am coming");
        }

        if (gameObject.transform.eulerAngles.y == 270)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - (move.carSpeed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
        else if (gameObject.transform.eulerAngles.y == 90)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + (move.carSpeed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
        

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
