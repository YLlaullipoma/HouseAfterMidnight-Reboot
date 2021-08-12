using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternShoot : MonoBehaviour {

    public Light lanternLight;
    public float normalIntensity;
    public float shootIntensity;
    public float normalSpot;
    public float shootSpot;
    public float normalInner;
    public float shootInner;

    // Start is called before the first frame update
    void Start() {
        lanternLight.innerSpotAngle = normalInner;
        lanternLight.spotAngle = normalSpot;
        lanternLight.intensity = normalIntensity;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            LightingMonster();
        }
        if (Input.GetMouseButtonUp(0)) {
            NormalLighting();
        }
    }

    void LightingMonster() {
        lanternLight.innerSpotAngle = shootInner;
        lanternLight.spotAngle = shootSpot;
        lanternLight.intensity = shootIntensity;
    }

    void NormalLighting() {
        lanternLight.innerSpotAngle = normalInner;
        lanternLight.spotAngle = normalSpot;
        lanternLight.intensity = normalIntensity;
    }
}
