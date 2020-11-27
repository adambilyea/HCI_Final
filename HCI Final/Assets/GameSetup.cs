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
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonPlayer"), Vector3.zero, Quaternion.identity);
    }
}
