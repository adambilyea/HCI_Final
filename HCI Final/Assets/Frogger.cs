using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using System.Linq;
public class Frogger : MonoBehaviour
{
    public GameObject car;
    public Transform loc1;
    public Transform loc2;
    public Transform loc3;
    public Transform loc4;
    public Transform loc5;
    public Transform loc6;
    public Transform loc7;
    public Transform loc8;
    private Move move;


    private float randn1;
    private float randn2;
    private float randn3;
    private float randn4;
    private float randn5;
    private float randn6;
    private float randn7;
    private float randn8;

    private bool playerJoined;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        move = GameObject.Find("Player(Clone)").GetComponent<Move>();

        randn1 = Random.Range(200, 1000 - move.randomness);
        randn2 = Random.Range(200, 1000 - move.randomness);
        randn3 = Random.Range(200, 900 - move.randomness);
        randn4 = Random.Range(200, 900 - move.randomness);
        randn5 = Random.Range(200, 800 - move.randomness);
        randn6 = Random.Range(200, 800 - move.randomness);
        randn7 = Random.Range(100, 800 - move.randomness);
        randn8 = Random.Range(100, 800 - move.randomness);
        //private WaitForSeconds asd = 10f;

    }


    // Update is called once per frame

    void Update()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 2 && playerJoined == false)
        {
            move = GameObject.Find("Player(Clone)").GetComponent<Move>();
            playerJoined = true;
        }

        if (PhotonNetwork.CurrentRoom.PlayerCount == 2 && playerJoined == false)
        {
            move = GameObject.Find("Player").GetComponent<Move>();
            playerJoined = true;
        }
        Debug.Log(move.randomness);
        if (QuickStartRoomController.option == 2 && playerJoined == true)
        {
            timer++;
            if (timer >= randn1)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc1.position, loc1.rotation);
                randn1 = randn1 + Random.Range(200, 1000 - move.randomness);
            }
            if (timer >= randn2)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc2.position, loc2.rotation);
                randn2 = randn2 + Random.Range(200, 1000 - move.randomness);
            }
            if (timer >= randn3)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc3.position, loc3.rotation);
                randn3 = randn3 + Random.Range(200, 900 - move.randomness);
            }
            if (timer >= randn4)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc4.position, loc4.rotation);
                randn4 = randn4 + Random.Range(200, 900 - move.randomness);
            }
            if (timer >= randn5)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc5.position, loc5.rotation);
                randn5 = randn5 + Random.Range(200, 800 - move.randomness);
            }
            if (timer >= randn6)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc6.position, loc6.rotation);
                randn6 = randn6 + Random.Range(200, 800 - move.randomness);
            }
            if (timer >= randn7)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc7.position, loc7.rotation);
                randn7 = randn7 + Random.Range(100, 800 - move.randomness);
            }
            if (timer >= randn8)
            {
                PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "Car"), loc8.position, loc8.rotation);
                randn8 = randn8 + Random.Range(100, 800 - move.randomness);
            }
        }
    }
}
