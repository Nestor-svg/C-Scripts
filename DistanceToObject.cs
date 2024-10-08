using UnityEngine;

public class DistanceToObjects : MonoBehaviour
{
    // Variables para almacenar las referencias del cubo y el cilindro
    private GameObject cube;
    private GameObject cylinder;

    void Start()
    {
        // Buscar el cubo y el cilindro en la escena usando sus etiquetas
        cube = GameObject.FindWithTag("P2. Cube");
        cylinder = GameObject.FindWithTag("P2. Cylinder");

        // Verificar si los objetos fueron encontrados
        if (cube != null && cylinder != null)
        {
            // Obtener las posiciones de la esfera (este GameObject), el cubo y el cilindro
            Vector3 spherePosition = transform.position;
            Vector3 cubePosition = cube.transform.position;
            Vector3 cylinderPosition = cylinder.transform.position;

            // Calcular la distancia entre la esfera y el cubo
            float distanceToCube = Vector3.Distance(spherePosition, cubePosition);
            Debug.Log("Distancia de la esfera al cubo: " + distanceToCube);

            // Calcular la distancia entre la esfera y el cilindro
            float distanceToCylinder = Vector3.Distance(spherePosition, cylinderPosition);
            Debug.Log("Distancia de la esfera al cilindro: " + distanceToCylinder);
        }
        else
        {
            Debug.LogError("No se encontraron el cubo o el cilindro en la escena. Verifica las etiquetas.");
        }
    }
}
