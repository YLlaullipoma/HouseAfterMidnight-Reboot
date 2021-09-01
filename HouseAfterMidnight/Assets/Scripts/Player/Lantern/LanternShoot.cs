using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternShoot : MonoBehaviour {

    [Header("Reference")]
    public Light lanternLight;
    public Transform originRayPoint;
    public Camera worldCam;

    [Header("Normal Lantern Atributes")]
    public float normalIntensity;
    public float normalSpot;
    public float normalInner;

    [Header("Shoot Lantern Atributes")]
    public float shootIntensity;
    public float shootSpot;
    public float shootInner;
    
    [Header("Atack Parameter")]
    public float lanterRange;
    public bool shooting;
    public bool shootingMonster;

    

    // Start is called before the first frame update
    void Start() {
        lanternLight.innerSpotAngle = normalInner;
        lanternLight.spotAngle = normalSpot;
        lanternLight.intensity = normalIntensity;
        shooting = false;
    }

    // Update is called once per frame
    void Update() {
        
        RaycastHit hit;
        if (Physics.Raycast(originRayPoint.transform.position, originRayPoint.transform.right, out hit, lanterRange)) {

            if (hit.collider.tag == "Monster" && shooting == true) {
                shootingMonster = true;
                Debug.Log("Transformando Monstruo");
            }
            else {
                shootingMonster = false;
            }
        }

        if (Input.GetMouseButtonDown(0)) {
            ShootingLight();
            
        }
        if (Input.GetMouseButtonUp(0)) {
            NormalLight();
        }

        
    }

    void ShootingLight() {
        lanternLight.innerSpotAngle = shootInner;
        lanternLight.spotAngle = shootSpot;
        lanternLight.intensity = shootIntensity;
        worldCam.fieldOfView = 30f;
        shooting = true;
    }

    void NormalLight() {
        lanternLight.innerSpotAngle = normalInner;
        lanternLight.spotAngle = normalSpot;
        lanternLight.intensity = normalIntensity;
        worldCam.fieldOfView = 60f;
        shooting = false;
    }

    void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(originRayPoint.transform.position, originRayPoint.transform.right * lanterRange);
    }
}
