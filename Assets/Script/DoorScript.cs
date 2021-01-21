using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int index = -1;
    public bool open = false;
    public float doorOpenAngel = 90f;
    public float doorCloseAngel = 0f;
    public float smooth = 2f; 

    public void ChangeDoorState()
    {
        open = !open;
    }

    void Update()
    {
        if(open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngel, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorCloseAngel, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
    }
}
