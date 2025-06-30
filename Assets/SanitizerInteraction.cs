using UnityEngine;

public class SanitizerInteraction : MonoBehaviour
{
    public GameObject textToShow;  // Drag your "Hands Sanitized" Text or Canvas here

    private void Start()
    {
        if (textToShow != null)
            textToShow.SetActive(false); // Hide it at start
    }

    private void OnMouseDown()
    {
        if (textToShow != null)
            textToShow.SetActive(true); // Show on click/tap
    }
}
