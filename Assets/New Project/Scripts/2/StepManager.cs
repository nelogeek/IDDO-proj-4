using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine.UI;

public class StepManager : MonoBehaviour
{
    

    #region variable

    RaycastHit hit;
    Ray ray;

    public int step;

    int fon_color = 1;
    

    public GameObject fon;

    public GameObject MainMenu;

    public static bool key;
    public static int num;
    public static float timer;
    public static bool even;
    public static int step_count;

    //--------GAME VAR--------------
    
    public GameObject Controller;
    public GameObject manager;

    public GameObject Camera0;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;
    public GameObject Camera7;
    public GameObject Camera8;

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


    //------------------------------

    #endregion



    void Start()
    {
        step_count = 1;
        key = false;
        timer = 6;
        even = false;

        
        
    }

    void Fon()
        {
            if (fon_color == 1)
            {
                fon.GetComponent<Animator>().Play("Osvetlenie");
                fon_color = 0;
            }
            if (fon_color == 0)
            {
                fon.GetComponent<Animator>().Play("Zatemnenie");
                fon_color = 1;
        }
        }

void Update()
    {
       
        

            step = step_count;
        if (!InputManager.isPaused)
        {
            if (key)
            {
                timer -= Time.deltaTime;
                if (timer <= 0)
                {
                    key = false;
                    Step();
                }
            }

            //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit, 3f))
            //{
            //
            //    if (Input.GetKeyDown(KeyCode.Mouse0))
            //    {
            //        hit.collider.gameObject.SetActive(false);
            //
            //    }
            //
            //}

            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Fon();

            }
            
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Cho0se_Cameras.index == 0)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera0_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera0_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera0_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }

            if (Cho0se_Cameras.index == 1)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera1_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera1_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera1_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }

            if (Cho0se_Cameras.index == 2)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera2_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera2_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera2_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }
if (Cho0se_Cameras.index == 3)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera3_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera3_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    
                }

            }

if (Cho0se_Cameras.index == 4)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera4_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera4_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera4_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }

if (Cho0se_Cameras.index == 5)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera5_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera5_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera5_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }

if (Cho0se_Cameras.index == 6)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera6_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera6_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera6_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }

if (Cho0se_Cameras.index == 7)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera7_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera7_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera7_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }


if (Cho0se_Cameras.index == 8)
            {
                
                
                if (Physics.Raycast(ray, out hit, 3f))
                {
                    if (hit.collider.gameObject.name.Equals("1"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera8_1.active = true;
                            manager.active = !manager.active;

                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("2"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera8_2.active = true;
                            manager.active = !manager.active;


                        }
                    }
                    else if (hit.collider.gameObject.name.Equals("3"))
                    {
                        if (Input.GetKeyDown(KeyCode.Mouse0))
                        {
                            Controller.active = !Controller.active;
                            Camera8_3.active = true;
                            manager.active = !manager.active;


                        }
                    }
                }

            }









        }

        
    }







    














    bool IsCouldUse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if(Physics.Raycast(ray, out hit, 15))
        {
               
            return true;
        }
        
        return false;
    }




    public void Step()
    {
        even = false;
        InputManager.isStopedController = false;
        //Time.timeScale = 1f;
        timer = 6;
        
        step_count = 7 + num;
    }

    public void Again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
