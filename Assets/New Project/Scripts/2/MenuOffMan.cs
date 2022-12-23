using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOffMan : MonoBehaviour
{
    public GameObject Cam_n_game_manager;
    public GameObject MainMenu;
    public GameObject zatemnenie;

    void Update()
    {
        Cam_n_game_manager.active = !MainMenu.active;
        zatemnenie.active = !MainMenu.active;
    }
}
