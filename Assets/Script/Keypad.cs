using UnityEngine;
using System.Collections;
 
public class Keypad : MonoBehaviour {
 
    public string curPassword = "12345";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
    public Transform doorHinge;
 
    void OnTriggerEnter(Collider other)
    {
        onTrigger = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        onTrigger = false;
        keypadScreen = false;
        input = "";
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
 
    void Update()
    {
        if(input == curPassword)
        {
            doorOpen = true;
        }
 
        if(doorOpen)
        {
            var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 250);
            doorHinge.rotation = newRot;
        }
    }
 
    void OnGUI()
    {
        if(!doorOpen)
        {
            if(onTrigger)
            {
                GUI.Box(new Rect(585, 300, 200, 30), "Press 'E' to open keypad");
 
                if(Input.GetKeyDown(KeyCode.E))
                {
                    keypadScreen = true;
                    onTrigger = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                }
            }
 
            if(keypadScreen)
            {
                GUI.Box(new Rect(530, 100, 320, 490), "");
                GUI.Box(new Rect(535, 105, 310, 50), input);
 
                if(GUI.Button(new Rect(535, 165, 100, 100), "1"))
                {
                    input = input + "1";
                }
 
                if(GUI.Button(new Rect(640, 165, 100, 100), "2"))
                {
                    input = input + "2";
                }
 
                if(GUI.Button(new Rect(745, 165, 100, 100), "3"))
                {
                    input = input + "3";
                }
 
                if(GUI.Button(new Rect(535, 270, 100, 100), "4"))
                {
                    input = input + "4";
                }
 
                if(GUI.Button(new Rect(640, 270, 100, 100), "5"))
                {
                    input = input + "5";
                }
 
                if(GUI.Button(new Rect(745, 270, 100, 100), "6"))
                {
                    input = input + "6";
                }
 
                if(GUI.Button(new Rect(535, 375, 100, 100), "7"))
                {
                    input = input + "7";
                }
 
                if(GUI.Button(new Rect(640, 375, 100, 100), "8"))
                {
                    input = input + "8";
                }
 
                if(GUI.Button(new Rect(745, 375, 100, 100), "9"))
                {
                    input = input + "9";
                }

                if(GUI.Button(new Rect(535, 480, 100, 100), "*"))
                {
                    input = input + "*";
                }
 
                if(GUI.Button(new Rect(640, 480, 100, 100), "0"))
                {
                    input = input + "0";
                }

                if(GUI.Button(new Rect(745, 480, 100, 100), "#"))
                {
                    input = input + "#";
                }
            }
        }
    }
}