using UnityEngine;

public class EsferaManager : MonoBehaviour
{
    // Referencia al cubo
    public GameObject cube;

    // Color para la esfera más lejana cuando se presione espacio
    public Color colorForFarthestSphere = Color.red;

    // Para asegurarse de que la altura solo aumente una vez
    private GameObject ultimaEsferaCercana = null;

    void Update()
    {
        // Buscar todas las esferas con etiqueta "Type2"
        GameObject[] esferasTipo2 = GameObject.FindGameObjectsWithTag("Type2");

        if (esferasTipo2.Length == 0) return;

        // Variables para almacenar la esfera más cercana y más lejana
        GameObject esferaMasCercana = null;
        GameObject esferaMasLejana = null;
        float minDistancia = Mathf.Infinity;
        float maxDistancia = 0f;

        // Posición del cubo
        Vector3 posicionCubo = cube.transform.position;

        // Buscar la esfera más cercana y más lejana al cubo
        foreach (GameObject esfera in esferasTipo2)
        {
            float distancia = Vector3.Distance(esfera.transform.position, posicionCubo);

            // Encontrar la más cercana
            if (distancia < minDistancia)
            {
                minDistancia = distancia;
                esferaMasCercana = esfera;
            }

            // Encontrar la más lejana
            if (distancia > maxDistancia)
            {
                maxDistancia = distancia;
                esferaMasLejana = esfera;
            }
        }

        // Aumentar la altura de la esfera más cercana solo si es diferente de la última modificada
        if (esferaMasCercana != null && esferaMasCercana != ultimaEsferaCercana)
        {
            Vector3 posicionEsfera = esferaMasCercana.transform.position;
            posicionEsfera.y += 1f;  // Aumentar la altura en 1 unidad
            esferaMasCercana.transform.position = posicionEsfera;

            // Actualizar referencia a la última esfera modificada
            ultimaEsferaCercana = esferaMasCercana;
        }

        // Cambiar el color de la esfera más lejana al pulsar espacio
        if (Input.GetKeyDown(KeyCode.Space) && esferaMasLejana != null)
        {
            Renderer renderer = esferaMasLejana.GetComponent<Renderer>();
            renderer.material.color = colorForFarthestSphere;
            Debug.Log("La esfera más lejana ha cambiado de color.");
        }
    }
}
