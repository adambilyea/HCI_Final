﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;
using UnityEngine.UI;

public class GameSetup : MonoBehaviour
{
    public Text input;

    public InputField field;
    // Start is called before the first frame update
    void Start()
    {
        CreatPlayer();
        Debug.Log(QuickStartRoomController.option);
    }
    
    private void CreatPlayer()
    {
        if(QuickStartRoomController.option == 1)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Researcher"), new Vector3(0,1,0), Quaternion.identity);
        }
        else if(QuickStartRoomController.option == 2)
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Player"), new Vector3(5,1,5), Quaternion.identity);
            field.gameObject.SetActive(false);
        }
    }
}