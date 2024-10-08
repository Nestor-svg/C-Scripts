using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    // Vector de desplazamiento configurado en el Inspector
    public Vector3 desplazamiento;

    // Posición original del objeto
    private Vector3 posicionOriginal;

    void Start()
    {
        // Guardar la posición original del objeto al inicio
        posicionOriginal = transform.position;
    }

    void Update()
    {
        // Detectar si se ha pulsado la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Mover el objeto a su nueva posición sumando el desplazamiento a la posición original
            transform.position = posicionOriginal + desplazamiento;
            Debug.Log(gameObject.name + " ha sido movido a la posición: " + transform.position);
        }
    }
}
