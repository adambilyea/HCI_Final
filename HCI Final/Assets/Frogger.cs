using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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


    private int randn1;
    private int randn2;
    private int randn3;
    private int randn4;
    private int randn5;
    private int randn6;
    private int randn7;
    private int randn8;

    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        randn1 = Random.Range(200, 1000);
        randn2 = Random.Range(200, 1000);
        randn3 = Random.Range(200, 900);
        randn4 = Random.Range(200, 900);
        randn5 = Random.Range(200, 800);
        randn6 = Random.Range(200, 800);
        randn7 = Random.Range(100, 800);
        randn8 = Random.Range(100, 800);
        //private WaitForSeconds asd = 10f;
    }


    // Update is called once per frame

    void Update()
    {
        // timer++;
        // if (timer >= randn1)
        // {
        // Instantiate(car, loc1);
        //     randn1 = randn1 + Random.Range(200, 1000);
        // }
        // if (timer >= randn2)
        // {
        //     Instantiate(car, loc2);
        //     randn2 = randn2 + Random.Range(200, 1000);
        // }
        // if (timer >= randn3)
        // {
        //     Instantiate(car, loc3);
        //     randn3 = randn3 + Random.Range(200, 900);
        // }
        // if (timer >= randn4)
        // {
        //     Instantiate(car, loc4);
        //     randn4 = randn4 + Random.Range(200, 900);
        // }
        // if (timer >= randn5)
        // {
        //     Instantiate(car, loc5);
        //     randn5 = randn5 + Random.Range(200, 800);
        // }
        // if (timer >= randn6)
        // {
        //     Instantiate(car, loc6);
        //     randn6 = randn6 + Random.Range(200, 800);
        // }
        // if (timer >= randn7)
        // {
        //     Instantiate(car, loc7);
        //     randn7 = randn7 + Random.Range(100, 800);
        // }
        // if (timer >= randn8)
        // {
        //     Instantiate(car, loc8);
        //     randn8 = randn8 + Random.Range(100, 800);
        // }

    }
}
