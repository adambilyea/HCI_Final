using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frogger : MonoBehaviour
{
    public GameObject car;
    public Transform loc1;
    public Transform loc2;

    private int randn1;
    private int randn2;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        randn1 = Random.Range(200, 1000);
        randn2 = Random.Range(200, 1000);

        //private WaitForSeconds asd = 10f;
    }


    // Update is called once per frame

    void Update()
    {
        timer++;
        if (timer >= randn1)
        {
        Instantiate(car, loc1);
            randn1 = randn1 + Random.Range(200, 1000);
        }
        if (timer >= randn2)
        {
            Instantiate(car, loc2);
            randn2 = randn2 + Random.Range(200, 1000);
        }
 

    }
}
