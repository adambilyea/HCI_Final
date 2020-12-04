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


    private int randn1;
    private int randn2;
    private int randn3;
    private int randn4;
    private int randn5;
    private int randn6;
    private int randn7;
    private int randn8;

    private float timer = 0;

    //


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

         randn1 = Random.Range(200, 1000);
        randn2 = Random.Range(200, 1000);
        randn3 = Random.Range(200, 900);
        randn4 = Random.Range(200, 900);
        randn5 = Random.Range(200, 800);
        randn6 = Random.Range(200, 800);
        randn7 = Random.Range(100, 800);
        randn8 = Random.Range(100, 800);
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
         timer++;
        if (timer >= randn1)
        {
        Instantiate(game.car, game.loc1);
            randn1 = randn1 + Random.Range(200, 1000);
        }
        if (timer >= randn2)
        {
            Instantiate(game.car, game.loc2);
            randn2 = randn2 + Random.Range(200, 1000);
        }
        if (timer >= randn3)
        {
            Instantiate(game.car, game.loc3);
            randn3 = randn3 + Random.Range(200, 900);
        }
        if (timer >= randn4)
        {
            Instantiate(game.car, game.loc4);
            randn4 = randn4 + Random.Range(200, 900);
        }
        if (timer >= randn5)
        {
            Instantiate(game.car, game.loc5);
            randn5 = randn5 + Random.Range(200, 800);
        }
        if (timer >= randn6)
        {
            Instantiate(game.car, game.loc6);
            randn6 = randn6 + Random.Range(200, 800);
        }
        if (timer >= randn7)
        {
            Instantiate(game.car, game.loc7);
            randn7 = randn7 + Random.Range(100, 800);
        }
        if (timer >= randn8)
        {
            Instantiate(game.car, game.loc8);
            randn8 = randn8 + Random.Range(100, 800);
        }
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
