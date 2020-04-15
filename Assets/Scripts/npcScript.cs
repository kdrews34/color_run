using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcScript : MonoBehaviour
{
    [SerializeField] public GameObject uiObject;

    private void OnTriggerEnter(Collider other) {
        uiObject.SetActive(true);
        GetComponent<AudioSource>().Play();
    }

    private void OnTriggerExit(Collider other) {
        GetComponent<AudioSource>().Stop();
        uiObject.SetActive(false);

    }
}
