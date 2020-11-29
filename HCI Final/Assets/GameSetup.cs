using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;



public class GameSetup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CreatPlayer();
    }

    private void CreatPlayer()
    {
        if(PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), new Vector3(0,1,0), Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), new Vector3(5,1,5), Quaternion.identity);
        }
    }
}
