using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collecting : MonoBehaviour
{
    public GameObject Player;
    public GameObject nextColor;
    public GameObject colorSound;
    private string[] colors = new string[] {"red1", "red2", "red3", "red4", "blue1", "blue2", "blue3", "green1"};

    public string thisColor;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Player"){
            colorSound.GetComponent<AudioSource>().Play();
            foreach (string color in colors){
                if (thisColor == "blue")
                    GameObject.Find(color).GetComponent<colorSwitch>().blueEnabled = true;
                if (thisColor == "green")
                    GameObject.Find(color).GetComponent<colorSwitch>().greenEnabled = true;

                GameObject.Find(color).GetComponent<colorSwitch>().currentColor = GameObject.Find("red1").GetComponent<colorSwitch>().currentColor;
            }
            Destroy(this.gameObject);
            var tempColor = nextColor.GetComponent<RawImage>().color;
            tempColor.a = 0.4f;
            nextColor.GetComponent<RawImage>().color = tempColor;
        }
    }
}
