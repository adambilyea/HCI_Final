using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Move : MonoBehaviour
{   
    private PhotonView myPV;
    private GameObject player;
    public float speed = 1.0f;
    public string myName = "Test";
    private object[] variables;


    private GameSetup game;
    public Camera researchCam;
    public Camera testerCam;
    private GameObject tester;

    private car car;
    public float carSpeed;
    private bool pausegame;

    private float timer = 0;

    //


    // Start is called before the first frame update
    void Start()
    {
        tester = this.gameObject;
        game = FindObjectOfType<GameSetup>();
        car = FindObjectOfType<car>();
        variables = new object[4];
    
        variables[0] = 0;
        variables[1] = "Test";
        variables[2] = 0.0f;
        variables[3] = false;

        if (QuickStartRoomController.option == 1)
        {
            researchCam.enabled = true;
            testerCam.enabled = false;
        }
        if (QuickStartRoomController.option == 2)
        {
            researchCam.enabled = false;
            testerCam.enabled = true;
        }        

        player = this.gameObject;
        myPV = GetComponent<PhotonView>();

    }

    
    // [PunRPC] void SetVariables(object[] newVariables)
    // {   
    //     GetVariables(newVariables);
    // }

    
    public void GetVariables(object[] newVariables)
    {
        speed = (float)(float) newVariables[0];
        myName = (string)(string) newVariables[1];
        carSpeed = (float)(float) newVariables[2];
        pausegame = (bool)(bool)newVariables[3];
    }


    void Update()
    {
        if(myPV.IsMine)
        {
            movePos();
        }

        //if(pausegame == true)
        //{
        //    Time.timeScale = 0;
        //}
        //else
        //{
        //    Time.timeScale = 1;
        //}
    }

    void movePos()
    {
        if(Input.GetKey(KeyCode.W))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z + (0.1f * speed));
        }
        if(Input.GetKey(KeyCode.S))
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z - (0.1f * speed));
        }
        if(Input.GetKey(KeyCode.A))
        {
            player.transform.position = new Vector3(player.transform.position.x - (0.1f * speed), player.transform.position.y, player.transform.position.z);
        }
        if(Input.GetKey(KeyCode.D))
        {
            player.transform.position = new Vector3(player.transform.position.x + (0.1f * speed), player.transform.position.y, player.transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {
            gameObject.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (other.gameObject.tag == "Goal")
        {
            gameObject.transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
        }
    }


}
