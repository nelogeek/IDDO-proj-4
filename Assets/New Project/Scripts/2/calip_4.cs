using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calip_4 : MonoBehaviour
{
    
    [SerializeField] private Text text_diam;
    [SerializeField] private GameObject caliper1;
    [SerializeField] private GameObject caliper2;
    [SerializeField] private GameObject caliper3;
    [SerializeField] private GameObject target4;
    [SerializeField] private float cf = 40;
    [SerializeField] private float shirina = 80;
    [SerializeField] private float pogr = 0.81674f;
    [SerializeField] private float delta = 0.0001f;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.T)){
            caliper3.active = !caliper3.active;
            caliper1.active = false;
            caliper2.active = false;
        }

        int no_cal = 0;
        if (caliper3.active){
            no_cal = 3;
            
            text_diam.text = (shirina + cf*Wide.d - pogr).ToString(); 

            if(Input.GetAxis("Mouse ScrollWheel") > 0 && Input.GetKey(KeyCode.LeftControl))  {

                float x = target4.transform.position.x;
                float y = target4.transform.position.y;
                float z = target4.transform.position.z;
                target4.transform.position = new Vector3(target4.transform.position.x- delta, target4.transform.position.y, target4.transform.position.z );
                if (Wide.d > 0.3 ){
                    target4.transform.position = new Vector3(x + delta, y , z);
                }
               
            }
            else if(Input.GetAxis("Mouse ScrollWheel") < 0 && Input.GetKey(KeyCode.LeftControl)) {
                float x = target4.transform.position.x;
                float y = target4.transform.position.y;
                float z = target4.transform.position.z;
                target4.transform.position = new Vector3(target4.transform.position.x + delta, target4.transform.position.y , target4.transform.position.z);
                if (Wide.d < 0.01934278){
                    target4.transform.position = new Vector3(x- delta, y , z );
                }
                
            }
        }

        else{
            text_diam.text= "";
        }

        //Debug.Log("Caliper" + no_cal + " " + dist.ToString());
        Debug.Log("Caliper" + no_cal + " " + Wide.d.ToString());
    }
}
