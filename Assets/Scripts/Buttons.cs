using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public Color layer_blue, layer_red;
    public GameObject sMusicOn;
    public GameObject sMusicOff;
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = layer_red;
    }
    private void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().color = layer_blue;
    }
    private void OnMouseUpAsButton()
    {
        switch (gameObject.name) {
            case "Play":
                Application.LoadLevel("play");
                break;
            case "Rating":
                Application.OpenURL("http://google.com");
                break;
            case "Facebook":
                Application.OpenURL("http://facebook.com");
                break;
            case "Replay":
                Application.LoadLevel("play");
                break;
            case "Home":
                Application.LoadLevel("main");
                break;
            case "How To":
                Application.LoadLevel("howTo");
                break;
            case "Back":
                Application.LoadLevel("main");
                break;
            case "Music":
                if (sMusicOn.active)
                {
                    sMusicOn.SetActive(false);
                    sMusicOff.SetActive(true);
                }
                else
                {
                    sMusicOff.SetActive(false);
                    sMusicOn.SetActive(true);
                }
                break;
        }
    }
}
