using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark_Pod : MonoBehaviour
{
    public GameObject txt1;
    public GameObject txt2;
    public GameObject txt3;
    public GameObject txt4;
    public GameObject txt5;
    public GameObject txt6;
    public GameObject txt7;
    public GameObject txt8;
    public GameObject txt9;


    public GameObject cal_1_1;
    public GameObject cal_1_2;
    public GameObject cal_1_3;
    public GameObject cal_2_1;
    public GameObject cal_2_2;
    public GameObject cal_2_3;
    public GameObject cal_3_1;
    public GameObject cal_3_2;
    public GameObject cal_3_3;
    public GameObject cal_4_1;
    public GameObject cal_4_2;
    public GameObject cal_4_3;
    public GameObject cal_5_1;
    public GameObject cal_5_2;
    public GameObject cal_5_3;
    public GameObject cal_6_1;
    public GameObject cal_6_2;
    public GameObject cal_6_3;
    public GameObject cal_7_1;
    public GameObject cal_7_2;
    public GameObject cal_7_3;
    public GameObject cal_8_1;
    public GameObject cal_8_2;
    public GameObject cal_8_3;
    public GameObject cal_9_1;
    public GameObject cal_9_2;
    public GameObject cal_9_3;


    public bool bcal_1_1;
    public bool bcal_1_2;
    public bool bcal_1_3;
    public bool bcal_2_1;
    public bool bcal_2_2;
    public bool bcal_2_3;
    public bool bcal_3_1;
    public bool bcal_3_2;
    public bool bcal_3_3;
    public bool bcal_4_1;
    public bool bcal_4_2;
    public bool bcal_4_3;
    public bool bcal_5_1;
    public bool bcal_5_2;
    public bool bcal_5_3;
    public bool bcal_6_1;
    public bool bcal_6_2;
    public bool bcal_6_3;
    public bool bcal_7_1;
    public bool bcal_7_2;
    public bool bcal_7_3;
    public bool bcal_8_1;
    public bool bcal_8_2;
    public bool bcal_8_3;
    public bool bcal_9_1;
    public bool bcal_9_2;
    public bool bcal_9_3;

    void Start()
    {
        bcal_1_1 = false;
        bcal_1_2 = false;
        bcal_1_3 = false;
        bcal_2_1 = false;
        bcal_2_2 = false;
        bcal_2_3 = false;
        bcal_3_1 = false;
        bcal_3_2 = false;
        bcal_3_3 = false;
        bcal_4_1 = false;
        bcal_4_2 = false;
        bcal_4_3 = false;
        bcal_5_1 = false;
        bcal_5_2 = false;
        bcal_5_3 = false;
        bcal_6_1 = false;
        bcal_6_2 = false;
        bcal_6_3 = false;
        bcal_7_1 = false;
        bcal_7_2 = false;
        bcal_7_3 = false;
        bcal_8_1 = false;
        bcal_8_2 = false;
        bcal_8_3 = false;
        bcal_9_1 = false;
        bcal_9_2 = false;
        bcal_9_3 = false;

    }

    
    void Update()
    {
        if (bcal_1_1 & bcal_1_2 & bcal_1_3)
        {
            txt1.SetActive(true);
        }
        if (bcal_2_1 & bcal_2_2 & bcal_2_3)
        {
            txt2.SetActive(true);
        }
        if (bcal_3_1 & bcal_3_2 & bcal_3_3)
        {
            txt3.SetActive(true);
        }
        if (bcal_4_1 & bcal_4_2 & bcal_4_3)
        {
            txt4.SetActive(true);
        }
        if (bcal_5_1 & bcal_5_2 & bcal_5_3)
        {
            txt5.SetActive(true);
        }
        if (bcal_6_1 & bcal_6_2 & bcal_6_3)
        {
            txt6.SetActive(true);
        }
        if (bcal_7_1 & bcal_7_2 & bcal_7_3)
        {
            txt7.SetActive(true);
        }
        if (bcal_8_1 & bcal_8_2 & bcal_8_3)
        {
            txt8.SetActive(true);
        }
        if (bcal_9_1 & bcal_9_2 & bcal_9_3)
        {
            txt9.SetActive(true);
        }

        if (cal_1_1.activeInHierarchy)
        {
            bcal_1_1 = true;
        }
        if (cal_1_2.activeInHierarchy)
        {
            bcal_1_2 = true;
        }
        if (cal_1_3.activeInHierarchy)
        {
            bcal_1_3 = true;
        }
        if (cal_2_1.activeInHierarchy)
        {
            bcal_2_1 = true;
        }
        if (cal_2_2.activeInHierarchy)
        {
            bcal_2_2 = true;
        }
        if (cal_2_3.activeInHierarchy)
        {
            bcal_2_3 = true;
        }
        if (cal_3_1.activeInHierarchy)
        {
            bcal_3_1 = true;
        }
        if (cal_3_2.activeInHierarchy)
        {
            bcal_3_2 = true;
        }
        if (cal_3_3.activeInHierarchy)
        {
            bcal_3_3 = true;
        }
        if (cal_4_1.activeInHierarchy)
        {
            bcal_4_1 = true;
        }
        if (cal_4_2.activeInHierarchy)
        {
            bcal_4_2 = true;
        }
        if (cal_4_3.activeInHierarchy)
        {
            bcal_4_3 = true;
        }
        if (cal_5_1.activeInHierarchy)
        {
            bcal_5_1 = true;
        }
        if (cal_5_2.activeInHierarchy)
        {
            bcal_5_2 = true;
        }
        if (cal_5_3.activeInHierarchy)
        {
            bcal_5_3 = true;
        }
        if (cal_6_1.activeInHierarchy)
        {
            bcal_6_1 = true;
        }
        if (cal_6_2.activeInHierarchy)
        {
            bcal_6_2 = true;
        }
        if (cal_6_3.activeInHierarchy)
        {
            bcal_6_3 = true;
        }
        if (cal_7_1.activeInHierarchy)
        {
            bcal_7_1 = true;
        }
        if (cal_7_2.activeInHierarchy)
        {
            bcal_7_2 = true;
        }
        if (cal_7_3.activeInHierarchy)
        {
            bcal_7_3 = true;
        }
        if (cal_8_1.activeInHierarchy)
        {
            bcal_8_1 = true;
        }
        if (cal_8_2.activeInHierarchy)
        {
            bcal_8_2 = true;
        }
        if (cal_8_3.activeInHierarchy)
        {
            bcal_8_3 = true;
        }
        if (cal_9_1.activeInHierarchy)
        {
            bcal_9_1 = true;
        }
        if (cal_9_2.activeInHierarchy)
        {
            bcal_9_2 = true;
        }
        if (cal_9_3.activeInHierarchy)
        {
            bcal_9_3 = true;
        }










    }
}
