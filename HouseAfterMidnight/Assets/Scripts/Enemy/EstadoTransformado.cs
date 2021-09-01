using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EstadoTransformado : MonoBehaviour {

    private NavMeshAgent NMA;

    public Quaternion boxRotation;
    public Quaternion defaultRotation;
    public float rotatioSpeed;
    public float transformationTimer;

    // Start is called before the first frame update
    void Start() {
        NMA = GetComponent<NavMeshAgent>();
        defaultRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update() {
        NMA.speed = 0f;

        if (transformationTimer <= 0) {

        }
    }
}
