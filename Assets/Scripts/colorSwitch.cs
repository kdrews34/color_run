using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitch : MonoBehaviour
{
    public GameObject Player;

    private bool redblue;
    public string baseColor;
    Color gray;
    Color red;
    Color blue;

    // Start is called before the first frame update
    void Start()
    {
        gray = Color.gray;
        red = Color.red;
        blue = Color.blue;
        if (baseColor == "blue"){
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material.color = gray;
        }
        else {
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material.color = red;
        }
        
        redblue = true;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (redblue && baseColor == "red"){
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = true;
                GetComponent<Renderer>().material.color = gray;
                redblue = false;
            }
            else if (!redblue && baseColor == "red"){
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = false;
                GetComponent<Renderer>().material.color = red;
                redblue = true;
            }
            else if (!redblue && baseColor == "blue"){
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = true;
                GetComponent<Renderer>().material.color = gray;
                redblue = true;
            }
            else if (redblue && baseColor == "blue"){
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = false;
                GetComponent<Renderer>().material.color = blue;
                redblue = false;
            }
        }
        // else if (Input.GetKeyDown(KeyCode.R) && baseColor == "blue") {
        // GetComponent<AudioSource>().Play();

        //     if (redblue){
        //         GetComponent<AudioSource>().Play();
        //         GetComponent<Collider>().isTrigger = true;
        //         GetComponent<Renderer>().material.color = gray;
        //         redblue = false;
        //     }
        //     else{
        //         GetComponent<AudioSource>().Play();
        //         GetComponent<Collider>().isTrigger = false;
        //         GetComponent<Renderer>().material.color = blue;
        //         redblue = true;
        //     }
        // }
    }
}
