using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Photon.Pun;
using UnityEngine.UI;
using TMPro;

public class GameSetup : MonoBehaviour
{
    public Text input;
    public Text carSpeedInput;
    public Canvas Researcher;
    public Toggle checkbox;
    public Text randomness;
    public InputField field;
    public TMP_Text notes;

    private bool playerJoined = false;


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
            Researcher.enabled = false;
        }
    }

    public void saveNotes()
    {

    }

  
    public void WriteString()
    {
        string path = "Assets/Resources/test.txt";

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, false);
        writer.WriteLine("PlayerSpeed: "+ input.text.ToString());
        writer.WriteLine("CarSpeed: " + carSpeedInput.text.ToString() + "\n");
        writer.WriteLine("Notes: \n" + notes.text.ToString());

        writer.Close();

        //Print the text from the file
    }

}
