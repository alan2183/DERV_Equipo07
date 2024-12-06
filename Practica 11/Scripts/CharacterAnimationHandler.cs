using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAnimationHandler : MonoBehaviour
{
    [SerializeField] private List<GameObject> personajes; // Lista de personajes
    [SerializeField] private List<Button> botonesAnimacion; // Lista de botones de animación
    
    private int indicePersonajeActual = 0;
    private Animator animadorActual;

    // Diccionario de animaciones por personaje
    private Dictionary<int, List<string>> animacionesPersonaje = new Dictionary<int, List<string>>()
    {
        { 0, new List<string> { "Body Block", "Northern Soul Spin", "Waving" } },
        { 1, new List<string> { "Idle", "Sad Idle", "Twist Dance" } },
        { 2, new List<string> { "Sitting Disapproval", "Sitting Angry", "Twist Dance" } }
    };

    void Start()
    {
        EstablecerPersonaje(indicePersonajeActual);
        AsignarEventosBotones();
    }

    private void EstablecerPersonaje(int indice)
    {
        // Desactivar todos los personajes y activar solo el actual
        foreach (var personaje in personajes)
            personaje.SetActive(false);

        personajes[indice].SetActive(true);
        animadorActual = personajes[indice].GetComponent<Animator>();

        if (animadorActual == null)
            Debug.LogWarning($"No se encontró Animator para el personaje en índice {indice}");

        ActualizarEtiquetasBotones(indice);
    }

    private void AsignarEventosBotones()
    {
        for (int i = 0; i < botonesAnimacion.Count; i++)
        {
            int indiceAnimacion = i;
            botonesAnimacion[i].onClick.AddListener(() => ReproducirAnimacion(indiceAnimacion));
        }
    }

    private void ActualizarEtiquetasBotones(int indicePersonaje)
    {
        for (int i = 0; i < botonesAnimacion.Count; i++)
        {
            botonesAnimacion[i].GetComponentInChildren<Text>().text = animacionesPersonaje[indicePersonaje][i];
        }
    }

    private void ReproducirAnimacion(int indiceAnimacion)
    {
        string nombreAnimacion = animacionesPersonaje[indicePersonajeActual][indiceAnimacion];
        Debug.Log($"Reproduciendo animación: {nombreAnimacion} para personaje índice: {indicePersonajeActual}");

        // Reproducir la animación
        animadorActual.Play(nombreAnimacion);
    }

    public void SiguientePersonaje()
    {
        indicePersonajeActual = (indicePersonajeActual + 1) % personajes.Count;
        EstablecerPersonaje(indicePersonajeActual);
    }
}
