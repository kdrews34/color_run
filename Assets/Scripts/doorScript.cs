using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    Animator anim;

    private bool isOpen = false;

    void Start(){
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.name == "Player" && !isOpen){
            anim.enabled = true;
            Debug.Log("Opening Door");
            anim.SetTrigger("OpenDoor");
            isOpen = true;
        }
    }

    private void Pause(){
        anim.enabled = false;
    }

    // private void OnTriggerExit(Collider other) {
    //     if (other.gameObject.name == "Player" && isOpen){
    //         Debug.Log("Closing Door");
    //         anim.SetTrigger("CloseDoor");
    //         isOpen = false;
    //     }
    // }

}
