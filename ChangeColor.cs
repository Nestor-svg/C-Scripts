using UnityEngine;

public class ChangeColorOnInput : MonoBehaviour
{
    // Referencias a los objetos cubo y cilindro
    public GameObject cube;
    public GameObject cylinder;

    // Colores para cambiar
    public Color colorForCube = Color.green; // Color para el cubo cuando se pulse la flecha arriba
    public Color colorForCylinder = Color.blue; // Color para el cilindro cuando se pulse 'C'

    void Update()
    {
        // Cambiar el color del cilindro cuando se pulse la tecla C
        if (Input.GetKeyDown(KeyCode.C))
        {
            Renderer cylinderRenderer = cylinder.GetComponent<Renderer>();
            if (cylinderRenderer != null)
            {
                cylinderRenderer.material.color = colorForCylinder;
                Debug.Log("Se cambió el color del cilindro a: " + colorForCylinder);
            }
        }

        // Cambiar el color del cubo cuando se pulse la flecha arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Renderer cubeRenderer = cube.GetComponent<Renderer>();
            if (cubeRenderer != null)
            {
                cubeRenderer.material.color = colorForCube;
                Debug.Log("Se cambió el color del cubo a: " + colorForCube);
            }
        }
    }
}
