using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collecting : MonoBehaviour
{
    public GameObject Player;
    public GameObject nextColor;
    public GameObject colorSound;
    public string[] colors = new string[] {"red1", "red2", "red3", "red4", "blue1", "blue2", "blue3", "green1"};

    public string thisColor;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Player"){
            colorSound.GetComponent<AudioSource>().Play();
            for (int i = 0; i < 7; i++){
                if (thisColor == "blue")
                    GameObject.Find(colors[i]).GetComponent<colorSwitch>().blueEnabled = true;
                if (thisColor == "green")
                    GameObject.Find(colors[i]).GetComponent<colorSwitch>().greenEnabled = true;

                GameObject.Find(colors[i]).GetComponent<colorSwitch>().currentColor = GameObject.Find("red1").GetComponent<colorSwitch>().currentColor;
            }
            Destroy(this.gameObject);
            var tempColor = nextColor.GetComponent<RawImage>().color;
            tempColor.a = 0.4f;
            nextColor.GetComponent<RawImage>().color = tempColor;
        }
    }
}
