using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Move : MonoBehaviour
{   
    private PhotonView myPV;
    private GameObject player;
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        myPV = GetComponent<PhotonView>();
    }

    void Update()
    {
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
