using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorSwitch : MonoBehaviour
{
    public GameObject Player;
    public GameObject RedUI;
    public GameObject BlueUI;

    public Material grayMat;
    private Material baseMat;

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
            baseMat = GetComponent<Renderer>().material;
            GetComponent<Renderer>().material = grayMat;
        }
        else {
            GetComponent<Collider>().isTrigger = false;
            baseMat = GetComponent<Renderer>().material;
        }
        
        redblue = true;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            if (redblue && baseColor == "red"){ //turn red off
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = true;
                GetComponent<Renderer>().material = grayMat;
                var tempColor = RedUI.GetComponent<RawImage>().color;
                tempColor.a = 0.4f;
                RedUI.GetComponent<RawImage>().color = tempColor;
                redblue = false;
            }
            else if (!redblue && baseColor == "red"){ //turn red on
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = false;
                GetComponent<Renderer>().material = baseMat;
                var tempColor = RedUI.GetComponent<RawImage>().color;
                tempColor.a = 1f;
                RedUI.GetComponent<RawImage>().color = tempColor;
                redblue = true;
            }
            else if (!redblue && baseColor == "blue"){ //turn blue off
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = true;
                GetComponent<Renderer>().material = grayMat;
                var tempColor = BlueUI.GetComponent<RawImage>().color;
                tempColor.a = 0.4f;
                BlueUI.GetComponent<RawImage>().color = tempColor;
                redblue = true;
            }
            else if (redblue && baseColor == "blue"){ //turn blue on;
                GetComponent<AudioSource>().Play();
                GetComponent<Collider>().isTrigger = false;
                GetComponent<Renderer>().material = baseMat;
                var tempColor = BlueUI.GetComponent<RawImage>().color;
                tempColor.a = 1f;
                BlueUI.GetComponent<RawImage>().color = tempColor;
                redblue = false;
            }
        }
    }
}
