using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public GameObject car;
    public Transform loc1;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        //private WaitForSeconds asd = 10f;
    }

    IEnumerator CarSpawner()
    {

        Debug.Log("aads");
        yield return new WaitForSeconds(5f);

    }

    // Update is called once per frame

    void Update()
    {
        timer++;
        if (timer >= Random.Range(200,400))
        {
        Instantiate(car, loc1);
            timer = 0;
        }
        //CarSpawner();
        //StartCoroutine("CarSpawner"); 

    }
}
