using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pod0 : MonoBehaviour
{
    [SerializeField] private float vnut_diam = 25f;
    [SerializeField] private float vnesh_diam = 36f;
    [SerializeField] private Text text_diam;
    [SerializeField] private GameObject target1;
    [SerializeField] private GameObject target2;
    [SerializeField] private GameObject target3;
    
    [SerializeField] private float delta = 0.0001f;
        
    [SerializeField] private GameObject caliper1;
    [SerializeField] private GameObject caliper2;

    [SerializeField] private float dist1 = 0.2967307f;
    [SerializeField] private float dist2 = 0.3090649f;
    [SerializeField] private float dist3 = 0.5690671f;
    [SerializeField] private float dist4 = 0.5690671f;
    [SerializeField] private float pogresh1 = 35.7040992f;
    [SerializeField] private float pogresh2 = 0.5654f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            caliper1.active = !caliper1.active;
            caliper2.active = false;
        }

        if (Input.GetKeyDown(KeyCode.E)){
            caliper2.active = !caliper2.active;
            caliper1.active = false;
        }


        float dist = 0;
        int no_cal = 0;

        
        // if (dist <= 0.2595974 && dist >= 0.1957069){
            // if(dist > 0.524){
            //     target1.transform.position = new Vector3(target1.transform.position.x, target1.transform.position.y - delta*100, target1.transform.position.z);
            // }
            
        if (caliper1.active){ // внутренний
            no_cal = 1;
            dist = Vector3.Distance(target2.transform.position , target1.transform.position);
            text_diam.text = (vnut_diam - dist + pogresh1).ToString();
            
            if(Input.GetAxis("Mouse ScrollWheel") > 0 && Input.GetKey(KeyCode.LeftControl))  {
                float x1 = target1.transform.position.x;
                float y2 = target1.transform.position.y;
                float z3 = target1.transform.position.z;
                target1.transform.position = new Vector3(target1.transform.position.x, target1.transform.position.y + delta, target1.transform.position.z);
                if (dist < dist3){
                    target1.transform.position = new Vector3(x1, y2 - delta, z3);
                }
                
            }
            else if(Input.GetAxis("Mouse ScrollWheel") < 0 && Input.GetKey(KeyCode.LeftControl)) {
                float x = target1.transform.position.x;
                float y = target1.transform.position.y;
                float z = target1.transform.position.z;
                target1.transform.position = new Vector3(target1.transform.position.x, target1.transform.position.y - delta, target1.transform.position.z);
                if (dist > dist4){
                    target1.transform.position = new Vector3(x, y + delta, z);
                }
                
            }
        }

        else if (caliper2.active){ // внешний
            no_cal = 2;
            dist = Vector3.Distance(target3.transform.position, target2.transform.position);
            text_diam.text = (vnesh_diam - dist + pogresh2).ToString(); 

            if(Input.GetAxis("Mouse ScrollWheel") > 0 && Input.GetKey(KeyCode.LeftControl))  {

                float x = target3.transform.position.x;
                float y = target3.transform.position.y;
                float z = target3.transform.position.z;
                target3.transform.position = new Vector3(target3.transform.position.x, target3.transform.position.y + delta, target3.transform.position.z);
                if (dist < dist1){
                    target3.transform.position = new Vector3(x, y - delta, z);
                }
               
            }
            else if(Input.GetAxis("Mouse ScrollWheel") < 0 && Input.GetKey(KeyCode.LeftControl)) {
                float x = target3.transform.position.x;
                float y = target3.transform.position.y;
                float z = target3.transform.position.z;
                target3.transform.position = new Vector3(target3.transform.position.x, target3.transform.position.y - delta, target3.transform.position.z);
                if (dist > dist2){
                    target3.transform.position = new Vector3(x, y + delta, z);
                }
                
            }
        }
        else{
            text_diam.text= "";
        }

        Debug.Log("Caliper" + no_cal + " " + dist.ToString());

       


    }
}
