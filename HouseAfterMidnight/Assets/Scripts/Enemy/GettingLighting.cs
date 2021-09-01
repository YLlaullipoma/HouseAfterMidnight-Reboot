using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GettingLighting : MonoBehaviour
{
    private NavMeshAgent NMA;

    public float liveCounter = 3f;
    public bool transforming;

    [HideInInspector]
    public bool gettinLighting;

    // Start is called before the first frame update
    void Start() {
        NMA = GetComponent<NavMeshAgent>();
        gettinLighting = false;
    }

    // Update is called once per frame
    void Update() {

        if (liveCounter <= 0) {
            transforming = true;
        }
        else {
            liveCounter -= Time.deltaTime;
        }
        
    }
}
