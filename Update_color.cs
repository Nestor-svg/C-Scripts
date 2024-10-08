using UnityEngine;

public class RandomColorChanger : MonoBehaviour
{
    // Parámetro para determinar la cantidad de frames a esperar antes de cambiar el color (configurable desde el inspector)
    [SerializeField] private int framesWait = 120;

    // Vector de 3 posiciones que representa el color en formato RGB
    private Vector3 colorVector;

    // Contador de frames
    private int frameCounter = 0;

    // Referencia al componente Renderer del objeto para cambiar su color
    private Renderer objectRenderer;

    void Start()
    {
        // Inicializa el colorVector con valores aleatorios entre 0.0 y 1.0
        colorVector = new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        // Obtén el componente Renderer del objeto para poder cambiar su color
        objectRenderer = GetComponent<Renderer>();

        // Asigna el color inicial al objeto
        UpdateObjectColor();
    }

    void Update()
    {
        // Incrementa el contador de frames
        frameCounter++;

        // Si el contador de frames llega al valor configurado en framesWait
        if (frameCounter >= framesWait)
        {
            // Resetea el contador de frames
            frameCounter = 0;

            // Cambia un valor aleatorio del vector de color
            int randomIndex = Random.Range(0, 3); // Índice aleatorio entre 0 y 2
            colorVector[randomIndex] = Random.Range(0.0f, 1.0f); // Asigna un nuevo valor aleatorio entre 0.0 y 1.0

            // Actualiza el color del objeto
            UpdateObjectColor();
        }
    }

    // Método para actualizar el color del objeto en base al colorVector
    private void UpdateObjectColor()
    {
        // Convierte el vector a un color RGB
        Color newColor = new Color(colorVector.x, colorVector.y, colorVector.z);

        // Asigna el nuevo color al material del objeto
        if (objectRenderer != null)
        {
            objectRenderer.material.color = newColor;
        }
    }
}
