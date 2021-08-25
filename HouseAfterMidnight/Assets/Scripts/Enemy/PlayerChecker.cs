using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    private VisionController visController;

    private void Awake() {
        visController = GetComponentInParent<VisionController>();
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player") {
            visController.foundPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") {
            visController.foundPlayer = false;
        }
    }
}
