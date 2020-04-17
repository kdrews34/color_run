using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorSwitch : MonoBehaviour
{
    public GameObject Player;
    public GameObject RedUI;
    public GameObject BlueUI;
    public GameObject GreenUI;

    public Material grayMat;
    private Material baseMat;

    public bool blueEnabled;
    public bool greenEnabled;

    public string currentColor;
    public string baseColor;
    Color gray;
    Color red;
    Color blue;

    // Start is called before the first frame update
    void Start()
    {
        currentColor = "red";
        blueEnabled = false;
        greenEnabled = false;

        if (baseColor == "red"){
            GetComponent<Collider>().isTrigger = false;
            baseMat = GetComponent<Renderer>().material;
        }
        else {
            GetComponent<Collider>().isTrigger = true;
            baseMat = GetComponent<Renderer>().material;
            GetComponent<Renderer>().material = grayMat;
        }
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            string nextColor = getNextColor();
            if (nextColor == "red" && baseColor == "red")
                turnRedOn();
            else if (nextColor == "gray")
                turnRedOff();
            else if (nextColor == "red" && baseColor == "blue" && blueEnabled)
                turnBlueOff();
            else if (nextColor == "blue" && baseColor == "blue")
                turnBlueOn();
            else if (nextColor == "blue" && baseColor == "red")
                turnRedOff();
            else if (nextColor == "blue" && baseColor == "green" && greenEnabled){
                Debug.Log("calling turngreenoff");
                turnGreenOff();
            }
            else if (nextColor == "green" && baseColor == "green"){
                Debug.Log("calling turngreenon");
                turnGreenOn();
            }
            else if (nextColor == "green" && baseColor == "red")
                turnRedOff();
            else if (nextColor == "green" && baseColor == "blue")
                turnBlueOff();
            else{
                Debug.Log("Undefined state");
            }
            currentColor = nextColor;
        }
    }

    private string getNextColor(){
        if (currentColor == "red" && blueEnabled)
            return "blue";
        if (currentColor == "red" && !blueEnabled)
            return "gray";
        if (currentColor == "blue" && greenEnabled)
        {
            Debug.Log("returning green");
            return "green";
        }
        if (currentColor == "blue" && !greenEnabled)
            return "red";
        if (currentColor == "green")
            return "red";
        if (currentColor == "gray")
            return "red";
        else{
            Debug.Log("SHOULDNT GET HERE");
            return "gray";
        }
    }

    public void turnRedOn(){
        GetComponent<AudioSource>().Play();
        GetComponent<Collider>().isTrigger = false;
        GetComponent<Renderer>().material = baseMat;
        var tempColor = RedUI.GetComponent<RawImage>().color;
        tempColor.a = 1f;
        RedUI.GetComponent<RawImage>().color = tempColor;
    }

    public void turnRedOff(){
        GetComponent<AudioSource>().Play();
        GetComponent<Collider>().isTrigger = true;
        GetComponent<Renderer>().material = grayMat;
        var tempColor = RedUI.GetComponent<RawImage>().color;
        tempColor.a = 0.4f;
        RedUI.GetComponent<RawImage>().color = tempColor;
    }

    public void turnBlueOn(){
        GetComponent<AudioSource>().Play();
        GetComponent<Collider>().isTrigger = false;
        GetComponent<Renderer>().material = baseMat;
        var tempColor = BlueUI.GetComponent<RawImage>().color;
        tempColor.a = 1f;
        BlueUI.GetComponent<RawImage>().color = tempColor;
    }

    public void turnBlueOff(){
        GetComponent<AudioSource>().Play();
        GetComponent<Collider>().isTrigger = true;
        GetComponent<Renderer>().material = grayMat;
        var tempColor = BlueUI.GetComponent<RawImage>().color;
        tempColor.a = 0.4f;
        BlueUI.GetComponent<RawImage>().color = tempColor;
    }

    public void turnGreenOn(){
        Debug.Log("turning green on");
        var tempColor = GreenUI.GetComponent<RawImage>().color;
        tempColor.a = 1f;
        GreenUI.GetComponent<RawImage>().color = tempColor;
    }

    public void turnGreenOff(){
        Debug.Log("turning green off");
        var tempColor = GreenUI.GetComponent<RawImage>().color;
        tempColor.a = 0.4f;
        GreenUI.GetComponent<RawImage>().color = tempColor;
    }
}
