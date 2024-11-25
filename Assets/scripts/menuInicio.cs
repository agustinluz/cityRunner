using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour
{
    // Función para cargar la escena de selección de personaje
    public void Jugar()
    {
        SceneManager.LoadScene("juego"); // Cambia a la escena de selección de personaje
    }

    // Función para salir del juego
    public void Salir()
    {
        Application.Quit(); // Cierra la aplicación
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Para cerrar en modo editor
        #endif
    }
}