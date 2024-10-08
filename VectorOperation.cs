using UnityEngine;

public class VectorOperations : MonoBehaviour
{
    // Declaración de los vectores como variables públicas para editarlas desde el Inspector
    public Vector3 vectorA;
    public Vector3 vectorB;

    // Variables públicas para mostrar los resultados en el Inspector
    public float magnitudA;
    public float magnitudB;
    public float anguloEntreVectores;
    public float distanciaEntreVectores;
    public string mensajeAltura;

    void Start()
    {
        // Cálculo de la magnitud de cada vector
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;

        // Imprime la magnitud de cada vector en la consola
        Debug.Log("Magnitud del vector A: " + magnitudA);
        Debug.Log("Magnitud del vector B: " + magnitudB);

        // Cálculo del ángulo entre los dos vectores en grados
        anguloEntreVectores = Vector3.Angle(vectorA, vectorB);
        Debug.Log("Ángulo entre los vectores A y B: " + anguloEntreVectores + " grados");

        // Cálculo de la distancia entre los dos vectores
        distanciaEntreVectores = Vector3.Distance(vectorA, vectorB);
        Debug.Log("Distancia entre los vectores A y B: " + distanciaEntreVectores);

        // Comparar las alturas (componente Y) de los vectores
        if (vectorA.y > vectorB.y)
        {
            mensajeAltura = "El vector A está a una mayor altura que el vector B.";
        }
        else if (vectorA.y < vectorB.y)
        {
            mensajeAltura = "El vector B está a una mayor altura que el vector A.";
        }
        else
        {
            mensajeAltura = "Ambos vectores están a la misma altura.";
        }

        // Imprime el resultado de la comparación de altura en la consola
        Debug.Log(mensajeAltura);
    }
}
