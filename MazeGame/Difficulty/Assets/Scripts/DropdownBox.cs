using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownBox : MonoBehaviour
{
    public Dropdown dropdown;

    public GameObject player;

    public GameObject timer;

    public void EventListening()
    {

        switch (dropdown.value)
        {
            case 0:
                player.GetComponent<PlayerMovement>().SetMoveSpeed(80);
                timer.GetComponent<Timer>().SetTime(30);
                print("Easy");
                break;
            case 1:
                print("Medium");
                player.GetComponent<PlayerMovement>().SetMoveSpeed(40);
                timer.GetComponent<Timer>().SetTime(20);
                break;
            case 2:
                print("Hard");
                player.GetComponent<PlayerMovement>().SetMoveSpeed(30);
                timer.GetComponent<Timer>().SetTime(15);
                break;
            default:
                Debug.Log("Easy");
                player.GetComponent<PlayerMovement>().SetMoveSpeed(80);
                timer.GetComponent<Timer>().SetTime(30);
                break;
        }
    }
    
}