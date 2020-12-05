using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class car : MonoBehaviour
{
    public float speed;
    private Researcher researcher;
    private Move move;
    private GameSetup game;
    private bool playerJoined = false;
    // Start is called before the first frame update
    void Start()
    {
        researcher = GameObject.Find("Researcher(Clone)").GetComponent<Researcher>();
        move = GameObject.Find("Player(Clone)").GetComponent<Move>();
        game = FindObjectOfType<GameSetup>();
    }

    // Update is called once per frame
    void Update()
    {
        if(QuickStartRoomController.option == 2)
        {
        if (gameObject.transform.eulerAngles.y == 270)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - (move.carSpeed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
        else if (gameObject.transform.eulerAngles.y == 90)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + (move.carSpeed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
        }

        if(QuickStartRoomController.option == 1)
        {
        if (gameObject.transform.eulerAngles.y == 270)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - (researcher.carSpeed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
        else if (gameObject.transform.eulerAngles.y == 90)
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + (researcher.carSpeed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
        }
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
