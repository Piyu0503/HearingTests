using UnityEngine;

public class SanitizerSound : MonoBehaviour
{
    private AudioSource squirtAudio;

    void Start()
    {
        // Get AudioSource from parent
        squirtAudio = GetComponentInParent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!squirtAudio.isPlaying)
        {
            squirtAudio.Play();
        }
    }
}
