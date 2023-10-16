using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class JugadorController : MonoBehaviour
{
    public float velocidad;
    private int contador;
    public Text textoContador, textoGanar;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        
    }
    private void FixedUpdate()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoH,0.0f,movimientoV);
        rb.AddForce(movimiento);
    }
    // Update is called once per frame
    void Update()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);
        rb.AddForce(movimiento*velocidad);
    }

    void setTextoContador() {
        textoContador.text = "Puntaje: " + contador.ToString();
        if (contador >= 12)
            textoGanar.text = "Ganaste!";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable")) {
            other.gameObject.SetActive(false);
            contador++;
            setTextoContador();
            
        }
    }
}