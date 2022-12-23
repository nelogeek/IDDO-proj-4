using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cho0se_Cameras : MonoBehaviour
{
    public GameObject Controller;
    public GameObject manager;

    

    public GameObject pod0;
    public GameObject pod1;
    public GameObject pod2;
    public GameObject pod3;
    public GameObject pod4;
    public GameObject pod5;
    public GameObject pod6;
    public GameObject pod7;
    public GameObject pod8;

    public GameObject Camera0_1;
    public GameObject Camera0_2;
    public GameObject Camera0_3;

    public GameObject Camera1_1;
    public GameObject Camera1_2;
    public GameObject Camera1_3;

    public GameObject Camera2_1;
    public GameObject Camera2_2;
    public GameObject Camera2_3;

    public GameObject Camera3_1;
    public GameObject Camera3_2;

    public GameObject Camera4_1;
    public GameObject Camera4_2;
    public GameObject Camera4_3;

    public GameObject Camera5_1;
    public GameObject Camera5_2;
    public GameObject Camera5_3;

    public GameObject Camera6_1;
    public GameObject Camera6_2;
    public GameObject Camera6_3;

    public GameObject Camera7_1;
    public GameObject Camera7_2;
    public GameObject Camera7_3;

    public GameObject Camera8_1;
    public GameObject Camera8_2;
    public GameObject Camera8_3;

    public static int index;

    

    void Start()
    {
        System.Random rnd = new System.Random();
        index = rnd.Next(8);

        //index = 8; // 0 1 3 4 5 6 7 8

        if (index == 0)
        {
            pod0.active = true;
        }

        else if (index == 1)
        {
            pod1.active = true;
        }

        else if (index == 2)
        {
            pod2.active = true;
        }

        else if (index == 3)
        {
            pod3.active = true;
        }

        else if (index == 4)
        {
            pod4.active = true;
        }

        else if (index == 5)
        {
            pod5.active = true;
        }

        else if (index == 6)
        {
            pod6.active = true;
        }

        else if (index == 7)
        {
            pod7.active = true;
        }

        else if (index == 8)
        {
            pod8.active = true;
        }
    }


        
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            Controller.active = true;
            manager.active = true;
            

            Camera0_1.active = false;
            Camera0_2.active = false;
            Camera0_3.active = false;

            Camera1_1.active = false;
            Camera1_2.active = false;
            Camera1_3.active = false;

            Camera2_1.active = false;
            Camera2_2.active = false;
            Camera2_3.active = false;

            Camera3_1.active = false;
            Camera3_2.active = false;

            Camera4_1.active = false;
            Camera4_2.active = false;
            Camera4_3.active = false;

            Camera5_1.active = false;
            Camera5_2.active = false;
            Camera5_3.active = false;

            Camera6_1.active = false;
            Camera6_2.active = false;
            Camera6_3.active = false;

            Camera7_1.active = false;
            Camera7_2.active = false;
            Camera7_3.active = false;

            Camera8_1.active = false;
            Camera8_2.active = false;
            Camera8_3.active = false;

        }

    
    }
}
