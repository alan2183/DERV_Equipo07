using UnityEngine;

public class Grito : MonoBehaviour
{
    public AudioClip screamSound; // Variable para almacenar el sonido del grito
    private AudioSource audioSource; // Componente AudioSource

    void Start()
    {
        // Obtén el componente AudioSource del objeto
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = screamSound; // Asigna el clip de audio
    }

    private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Jugador"))
    {
        Debug.Log("Jugador tocado"); // Mensaje para verificar la colisión
        audioSource.Play(); // Reproduce el sonido
    }
}


    
}
