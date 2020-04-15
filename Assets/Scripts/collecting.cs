using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collecting : MonoBehaviour
{
    public GameObject Player;
    public GameObject nextColor;
    public GameObject colorSound;

    public bool blueEnabled;

    void Start(){
        blueEnabled = false;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Player"){
            colorSound.GetComponent<AudioSource>().Play();
            GameObject.Find("red1").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("red2").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("red3").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("red4").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("blue1").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("blue2").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("blue3").GetComponent<colorSwitch>().blueEnabled = true;
            GameObject.Find("blue1").GetComponent<colorSwitch>().redblue = GameObject.Find("red1").GetComponent<colorSwitch>().redblue;
            GameObject.Find("blue2").GetComponent<colorSwitch>().redblue = GameObject.Find("red1").GetComponent<colorSwitch>().redblue;
            GameObject.Find("blue3").GetComponent<colorSwitch>().redblue = GameObject.Find("red1").GetComponent<colorSwitch>().redblue;
            Destroy(this.gameObject);
            var tempColor = nextColor.GetComponent<RawImage>().color;
            tempColor.a = 0.4f;
            nextColor.GetComponent<RawImage>().color = tempColor;
            blueEnabled = true;
        }
    }
}
