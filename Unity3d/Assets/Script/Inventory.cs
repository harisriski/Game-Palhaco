using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static bool[] keys = new bool[5];

    void Start()
    {
        keys[0] = true;
    }
}
