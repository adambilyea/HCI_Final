using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Researcher : MonoBehaviour
{
    public float speed = 1.0f;
    public float carSpeed = 20f;
    public string myName = "Test";
    public bool pausegame = false;
    private PhotonView myPV;
    private object[] variables;

    private GameSetup game;
    private Move move;

    private Text input;
    private Text carSpeedInput;
    private Toggle checkbox;


    private bool playerJoined = false;
    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType<Move>();
        myPV = GetComponent<PhotonView>();
        game = FindObjectOfType<GameSetup>();
        input = game.input;
        carSpeedInput = game.carSpeedInput;
        checkbox = game.checkbox;
        variables = new object[4];
        variables[0] = 0;
        variables[1] = "Researcher";
        variables[2] = carSpeed;
        variables[3] = pausegame;
    }
    [PunRPC] void SetVariables(object[] newVariables)
    {   
        move.GetVariables(newVariables);
    }

    private void Update() 
    {
        if(PhotonNetwork.CurrentRoom.PlayerCount == 2 && playerJoined == false)
        {
            Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
            move = GameObject.Find("Player(Clone)").GetComponent<Move>();
            playerJoined = true;
            Debug.Log("they joined");
        }

        if(playerJoined == true)
        {
            //Debug.Log(float.Parse(input.text));
            speed = float.Parse(input.text);
            carSpeed = float.Parse(carSpeedInput.text);
            pausegame = checkbox.isOn;
            //speed = 10f;
            myName = "Adam";

            variables[0] = speed;
            variables[1] = myName;
            variables[2] = carSpeed;
            variables[3] = pausegame;
            
            myPV.RPC("SetVariables", RpcTarget.OthersBuffered, variables);
            Debug.Log("values sent");
        }
    }

    // [PunRPC]
    // void SetVariables(object[] newVariables)
    // {
    //     move.GetVariables(newVariables);
    // }
    // // Update is called once per frame
    // void Update()
    // {
    //     speed = speed + 0.1f;
    //     myName = "Adam";
    // }
}
