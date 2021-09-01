using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickBoxes : MonoBehaviour {

    public GameObject handsPoint;
    public GameObject picketObjetc = null;
    public GameObject lanternHand;

    // Update is called once per frame
    void Update() {
        if(picketObjetc != null) {
            if (Input.GetKey("r")) {
                picketObjetc.GetComponent<Rigidbody>().useGravity = true;
                picketObjetc.GetComponent<Rigidbody>().isKinematic = false;
                picketObjetc.transform.SetParent(null);
                picketObjetc.transform.localScale = new Vector3(1f, 1f, 1f);
                picketObjetc.GetComponent<BoxCollider>().enabled = true;
                picketObjetc = null;
                lanternHand.SetActive(true);
            }
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Box") {
            if (Input.GetKey("e") && picketObjetc == null) {
                lanternHand.SetActive(false);
                other.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                other.GetComponent<Rigidbody>().useGravity = false;
                other.GetComponent<Rigidbody>().isKinematic = true;
                other.GetComponent<BoxCollider>().enabled = false;
                other.transform.position = handsPoint.transform.position;
                other.gameObject.transform.SetParent(handsPoint.gameObject.transform);
                picketObjetc = other.gameObject;
            }
        }
    }
}
