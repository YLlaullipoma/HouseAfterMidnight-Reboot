using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanterMoveAnim : MonoBehaviour {

    public PlayerMovement player;
    public LanternShoot lanterShoot;
    public PickBoxes pB;

    public Vector3 lightingTransform;

    public float anchoCiclo, altoCiclo, frecuencia1, frecuencia2, speedLanternMove, speedLanterRotation;
    float cX, contadorx, xSen;
    float cY, contadorY, ySen;

    // Start is called before the first frame update
    void Start() {
        cX = transform.position.x;
        cY = transform.position.y;
    }

    // Update is called once per frame
    void Update() {

        if (pB.picketObjetc == null) {
            if (lanterShoot.shooting) {
                transform.rotation = Quaternion.Euler(0, 14f, 0);
                //transform.position = new Vector3(-1.5f, 0, transform.position.z);
                MoviendoMano(-1.5f, cY);
            }
            else {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                //transform.position = new Vector3(0, 0, transform.position.z);
                MoviendoMano(cX, cY);
            }
        }
        else {
            transform.position = new Vector3(cX, cY - 10f, transform.position.z);
        }

    }

    public void MoviendoMano(float centerX, float centerY) {
        if (player.isMoving) {
            contadorx = contadorx + (frecuencia1 / 100);
            xSen = Mathf.Sin(contadorx);
            contadorY = contadorY + (frecuencia2 / 100);
            ySen = Mathf.Sin(contadorY);
            transform.position = new Vector3(centerX + (xSen * anchoCiclo), centerY + (ySen * anchoCiclo), transform.position.z);
            if (contadorx > 6.28f) {
                contadorx = 0;
            }
            if (contadorY > 6.28f) {
                contadorY = 0;
            }
        }
        else {
            contadorY = contadorY + (frecuencia2 / 300);
            ySen = Mathf.Sin(contadorY);
            transform.position = new Vector3(centerX, centerY + (ySen * anchoCiclo), transform.position.z);
            
            if (contadorY > 6.28f) {
                contadorY = 0;
            }
        }
    }
}
