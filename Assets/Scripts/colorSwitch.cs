using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitch : MonoBehaviour
{
    private bool on;
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
        GetComponent<Collider>().isTrigger = true;
        GetComponent<Renderer>().material.color = gray;
        on = false;
    }

    // Update is called once per frame
    void Update() {
    if (Input.GetKeyDown(KeyCode.E) && baseColor == "red") {
        GetComponent<AudioSource>().Play();


        if (on){
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material.color = gray;
            on = false;
        }
        else{
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material.color = red;
            on = true;
        }
    }
    else if (Input.GetKeyDown(KeyCode.R) && baseColor == "blue") {
      GetComponent<AudioSource>().Play();

        if (on){
            GetComponent<Collider>().isTrigger = true;
            GetComponent<Renderer>().material.color = gray;
            on = false;
        }
        else{
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Renderer>().material.color = blue;
            on = true;
        }
    }
}
}
