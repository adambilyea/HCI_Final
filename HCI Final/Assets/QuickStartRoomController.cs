using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class QuickStartRoomController : MonoBehaviourPunCallbacks
{
    static public int option = 0;
    public Text choosen;
    [SerializeField]
    private int multiplayerSceneIndex;

    public override void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    public override void OnJoinedRoom()
    {
        StartGame();
        Debug.Log("Joined Room");
    }    

    private void StartGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Starting Game");
            PhotonNetwork.LoadLevel(multiplayerSceneIndex);
        }
    }

    public void Researcher()
    {
        option = 1;
        choosen.text = "Researcher";
    }

    public void Tester()
    {
        option = 2;
        choosen.text = "Tester";
    }

}
