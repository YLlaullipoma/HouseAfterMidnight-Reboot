using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float lifePoints;
    public float jumpHeight;
    public float landingHeight;
    public float damageArea;

    public bool damageTaken;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }

    public void TakeDamage(float damagePoints) {
        lifePoints -= damagePoints;
        damageTaken = false;
    }

    private void OnCollisionExit(Collision collision) {
        


    }

    private void OnCollisionEnter(Collision collision) {



        if(collision.gameObject.tag == "Monster") {

        }
    }
}
