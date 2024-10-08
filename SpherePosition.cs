using UnityEngine;

public class DisplaySpherePosition : MonoBehaviour
{
    // Variable que almacenará la posición de la esfera
    private Vector3 spherePosition;

    void Update()
    {
        // Actualiza la posición de la esfera cada frame utilizando la propiedad 'transform.position'
        spherePosition = transform.position;
    }

    void OnGUI()
    {
        // Muestra en pantalla la posición de la esfera
        GUI.Label(new Rect(10, 10, 300, 20), "Posición de la esfera: " + spherePosition.ToString());
    }
}
