using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstadoPersecusion : MonoBehaviour {

    private NavMeshAgent NMA;
    private VisionController visionController;

    // Start is called before the first frame update
    void Start() {
        visionController = GetComponent<VisionController>();
        NMA = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        
        NMA.speed = 2.5f;
        NMA.stoppingDistance = 1f;

        if (visionController.foundPlayer) {
            NMA.SetDestination(visionController.playerPos.position);
            if(NMA.remainingDistance <= NMA.stoppingDistance && !NMA.pathPending) {
                Debug.Log("ATACK");
            }
        }
        else {
            visionController.EstadoPatrulla();
        }
        
    }
}
