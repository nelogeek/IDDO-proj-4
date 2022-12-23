using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wide : MonoBehaviour
{
    

    [SerializeField] private GameObject calip;
    public static float d = 0;
    public static string name = "";
    void Start()
    {
        
    }

    
    void Update()
    {
        //Ray ray = new Ray(calip.transform.position, calip.transform.forward);
        //RaycastHit hit;
        //Debug.DrawRay(transform.position, Ray, Color.green);


        //Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        //Debug.DrawRay(transform.position, forward, Color.green);


        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
        
        if (Physics.Raycast(ray, out hit))
        {
            d = hit.distance;
            name = hit.collider.name;
        }
    }
}
