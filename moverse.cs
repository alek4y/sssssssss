using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverse : MonoBehaviour
{
    //movimiento
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float velocidadDeMovimiento = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento
        movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadDeMovimiento;
        movimientoEjeY = Input.GetAxis("Vertical") * Time.deltaTime * velocidadDeMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, 0);

    }
}
