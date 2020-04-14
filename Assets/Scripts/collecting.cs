using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collecting : MonoBehaviour
{
    public GameObject Player;
    public GameObject nextColor;
    public GameObject colorSound;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Player"){
            colorSound.GetComponent<AudioSource>().Play();
            Destroy(this.gameObject);
            var tempColor = nextColor.GetComponent<RawImage>().color;
            tempColor.a = 0.4f;
            nextColor.GetComponent<RawImage>().color = tempColor;
            
        }
    }
}
