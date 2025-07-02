using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TuningForkAudioController : MonoBehaviour
{
    private AudioSource strikeAudio;
    private AudioSource ringAudio;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab;

    void Awake()
    {
        AudioSource[] sources = GetComponents<AudioSource>();
        strikeAudio = sources[0]; // first = strike
        ringAudio = sources[1];   // second = ring
        grab = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
    }

    void OnEnable()
    {
        grab.selectEntered.AddListener(PlayStrikeAndRing);
        grab.selectExited.AddListener(StopRinging); // optional stop
    }

    void OnDisable()
    {
        grab.selectEntered.RemoveListener(PlayStrikeAndRing);
        grab.selectExited.RemoveListener(StopRinging);
    }

    void PlayStrikeAndRing(SelectEnterEventArgs args)
    {
        if (!strikeAudio.isPlaying)
            strikeAudio.Play();

        // Ring after delay
        if (!ringAudio.isPlaying)
            ringAudio.PlayDelayed(0.2f); // slight delay for realism
    }

    void StopRinging(SelectExitEventArgs args)
    {
        if (ringAudio.isPlaying)
            ringAudio.Stop(); // stop when released
    }
}
