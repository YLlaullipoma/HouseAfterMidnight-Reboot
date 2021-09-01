using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAnimations : MonoBehaviour {

    [Header ("Light Reference")]
    public Light lightAnim;

    [Header("Anim Parameters")]
    public float animDuration;
    public float animCounter = 0f;
    public bool lightOn;
    
    // Start is called before the first frame update
    void Start() {
        lightAnim = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update() {

        if (!lightOn) {
            lightAnim.enabled = false;
            animCounter += Time.deltaTime;
            if(animCounter >= animDuration) {
                lightOn = true;
            }
        }

        if (lightOn) {
            lightAnim.enabled = true;
            animCounter -= Time.deltaTime;
            if (animCounter <= 0f) {
                lightOn = false;
            }
        }

    }
}
