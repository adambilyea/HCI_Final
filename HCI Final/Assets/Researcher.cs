using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Researcher : MonoBehaviour
{
    private float speed;
    private string myName;

    private PhotonView myPV;
    private object[] variables;

    private Move move;
    // Start is called before the first frame update
    void Start()
    {
        myPV = GetComponent<PhotonView>();
        move = FindObjectOfType<Move>();

        if(myPV.IsMine)
        {
            myPV.RPC("SetVariable", RpcTarget.OthersBuffered, variables);
        }

        variables[0] = speed;
        variables[1] = myName;
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
