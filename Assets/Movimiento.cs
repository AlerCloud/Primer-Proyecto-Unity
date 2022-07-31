using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{   
    [SerializeField]private Vector3 movimiento;
    [SerializeField]private Transform posicion;
    [SerializeField]private int Correr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
      float x = Input.GetAxis("Horizontal"); 
      float y = Input.GetAxis("Vertical");
      movimiento.x = x;
      movimiento.y = y;
    if (Input.GetKey(KeyCode.LeftShift)) {
      posicion.position += (movimiento*Correr) * Time.deltaTime;
      //Debug.Log("si");
    }
    else {
      posicion.position += movimiento * Time.deltaTime;
    }
      
      
     
    }
}
