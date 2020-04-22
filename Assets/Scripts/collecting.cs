using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collecting : MonoBehaviour
{
    public GameObject Player;
    public GameObject nextColor;
    public GameObject colorSound;
    private string[] colors = new string[] {"lvl1_red1", "lvl1_red2", "lvl1_red3", "lvl1_red4", "lvl2_red1", "lvl2_red2", "lvl2_red3", "lvl2_red4", "lvl2_blue1", "lvl2_blue2", "lvl2_blue3", "lvl3_blue1", "lvl3_blue2", "lvl3_blue3", "lvl3_green1", "lvl3_green2", "lvl3_green3", "lvl3_green4", "lvl3_green5", "lvl3_green6", "lvl3_red1", "lvl3_red2", "lvl3_red3", "lvl3_red4", "lvl3_red5"};

    public string thisColor;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Player"){
            colorSound.GetComponent<AudioSource>().Play();
            foreach (string color in colors){
                if (thisColor == "blue")
                    GameObject.Find(color).GetComponent<colorSwitch>().blueEnabled = true;
                if (thisColor == "green")
                    GameObject.Find(color).GetComponent<colorSwitch>().greenEnabled = true;

                GameObject.Find(color).GetComponent<colorSwitch>().currentColor = GameObject.Find("lvl1_red1").GetComponent<colorSwitch>().currentColor;
            }
            Destroy(this.gameObject);
            var tempColor = nextColor.GetComponent<RawImage>().color;
            tempColor.a = 0.4f;
            nextColor.GetComponent<RawImage>().color = tempColor;
        }
    }
}
