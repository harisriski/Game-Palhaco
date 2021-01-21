using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public Image noteImage;

    public GameObject hideNoteButton;

    public AudioClip pickUpSound;
    public AudioClip putAwaySound;
    // Start is called before the first frame update
    void Start()
    {
        noteImage.enabled = false;
        hideNoteButton.SetActive(false);
    }

    // Update is called once per frame
    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(pickUpSound);

        hideNoteButton.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);

        hideNoteButton.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
}
