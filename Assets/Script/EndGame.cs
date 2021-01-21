using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [SerializeField] private string loadLevel;
    private GameObject kill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kill = GameObject.FindGameObjectWithTag("Key");
            DestroyObject(kill);
            SceneManager.LoadScene(loadLevel);
            
        }
    }
}