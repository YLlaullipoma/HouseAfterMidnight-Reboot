using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstadoPatrulla : MonoBehaviour {

    private NavMeshAgent NMA;
    private VisionController visionController;
    public Transform[] WayPoint;
    public int nextPoint;

    // Start is called before the first frame update
    void Start() {
        NMA = GetComponent<NavMeshAgent>();
        visionController = GetComponent<VisionController>();
    }

    // Update is called once per frame
    void Update() {
        
        NMA.speed = 2f;
        NMA.stoppingDistance = 0f;

        NMA.SetDestination(WayPoint[nextPoint].position);

        if (NMA.remainingDistance <= NMA.stoppingDistance && !NMA.pathPending) {
            nextPoint = (nextPoint + 1) % WayPoint.Length;
        }

        if (visionController.foundPlayer) {
            visionController.EstadoAlerta();
        }
    }
}
