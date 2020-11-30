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


    // Start is called before the first frame update
    void Start()
    {
        tester = this.gameObject;
        game = FindObjectOfType<GameSetup>();
        variables = new object[2];
    
        variables[0] = 0;
        variables[1] = "Test";

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
        

        Debug.Log((float)(float) newVariables[0]);
    }


    void Update()
    {
        // if(!myPV.IsMine)
        // {
        //     speed = float.Parse(game.input.text);

        //     //speed = 10f;

        //     myName = "Adam";

        //     variables[0] = speed;
        //     variables[1] = myName;
            
        //     myPV.RPC("SetVariables", RpcTarget.OthersBuffered, variables);
        // }

        if(myPV.IsMine)
        {
            movePos();
        }
        
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
}
