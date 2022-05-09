using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Animator Player, UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        Player.SetTrigger("Start");
        UI.SetTrigger("Start");
    } 

    public void Quit()
    {
        Application.Quit();
    }
}
