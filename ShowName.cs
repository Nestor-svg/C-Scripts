using UnityEngine;

public class ShowNameScript : MonoBehaviour
{
    // Este método se ejecuta cuando el objeto es activado en la escena
    void Start()
    {
        // Imprime el nombre del GameObject en la consola
        Debug.Log("El nombre de este objeto es: " + gameObject.name);
    }
}
