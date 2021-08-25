using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EstadoAlerta : MonoBehaviour {

    private NavMeshAgent NMA;
    private VisionController visionController;
    
    public float alertTimer;
    private bool alerted = false;

    // Start is called before the first frame update
    void Start() {
        visionController = GetComponent<VisionController>();
        NMA = GetComponent<NavMeshAgent>();
        alertTimer = 3f;
    }

    // Update is called once per frame
    void Update() {
        if (!alerted) {
            alertTimer = 1.5f;
            alerted = true;
        }

        NMA.speed = 0f;

        if (alertTimer <= 0f) {
            CheckPlayerFounded();
        }
        else {
            alertTimer -= Time.deltaTime;
            transform.LookAt(visionController.playerPos);
        }
    }

    void CheckPlayerFounded() {
        
        if (visionController.foundPlayer) {
            alertTimer = 1.5f;
            visionController.EstadoPersecusión();
        }
        else {
            alertTimer = 1.5f;
            visionController.foundPlayer = false;
            visionController.EstadoPatrulla();
        }
    }
}
