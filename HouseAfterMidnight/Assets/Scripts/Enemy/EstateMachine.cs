using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstateMachine : MonoBehaviour {
    [Header("Estados")]
    public EstadoAlerta estadoAlerta;
    public EstadoPatrulla estadoPatrulla;
    public EstadoPersecusion estadoPersecusión;
    public EstadoTransformado estadoTransformando;
    public EstadoAtaque estadoAtaque;

    public MonoBehaviour estadoActual;
    public MonoBehaviour estadoInicial;

    void Awake() {
        estadoAlerta = GetComponent<EstadoAlerta>();
        estadoPatrulla  = GetComponent<EstadoPatrulla>();
        estadoPersecusión = GetComponent<EstadoPersecusion>();
        estadoTransformando = GetComponent<EstadoTransformado>();
        estadoAtaque = GetComponent<EstadoAtaque>();
    }

    // Start is called before the first frame update
    void Start()
    {
        ActivarEstado(estadoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarEstado(MonoBehaviour nuevoEstado) {
        if (estadoActual != null) {
            estadoActual.enabled = false;
        }
        estadoActual = nuevoEstado;
        estadoActual.enabled = true;
    }
}
