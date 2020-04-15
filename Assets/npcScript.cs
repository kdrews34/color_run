using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit(Collider other) {
        GetComponent<AudioSource>().Stop();
    }
}
