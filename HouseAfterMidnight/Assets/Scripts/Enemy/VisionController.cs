using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionController : MonoBehaviour {

    private EstateMachine stMachine;
    private GameObject playerTransform;
    private GettingLighting lighting;

    public Transform playerPos;
    
    private float playerDistance;
    
    public bool foundPlayer;
    public bool canAtack;

    // Start is called before the first frame update
    void Start() {
        stMachine = GetComponent<EstateMachine>();
        lighting = GetComponent<GettingLighting>();
        playerTransform = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {

        playerPos = playerTransform.transform;

    }
    public void EstadoPatrulla() {
        stMachine.ActivarEstado(stMachine.estadoPatrulla);
    }

    public void EstadoAlerta() {
        stMachine.ActivarEstado(stMachine.estadoAlerta);
    }

    public void EstadoPersecusión() {
        stMachine.ActivarEstado(stMachine.estadoPersecusión);
    }

    public void EstadoTransformado() {
        stMachine.ActivarEstado(stMachine.estadoTransformando);
    }
}
