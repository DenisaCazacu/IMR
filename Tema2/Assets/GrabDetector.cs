using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GrabDetector : MonoBehaviour
{
    private XRDirectInteractor directInteractor;

    void Start()
    {
        directInteractor = GetComponent<XRDirectInteractor>();

        if (directInteractor != null)
        {
            Debug.Log(" GrabDetector: XRDirectInteractor gasit cu succes.");
            directInteractor.selectEntered.AddListener(OnGrabStart);
            directInteractor.selectExited.AddListener(OnGrabEnd);
        }
        else
        {
            Debug.LogWarning(" GrabDetector: Nu s-a gasit un XRDirectInteractor pe acest obiect!");
        }

        Debug.Log(" GrabDetector: Scriptul a fost initializat cu succes.");
    }

    private void OnGrabStart(SelectEnterEventArgs args)
    {
        Debug.Log(" GrabDetector: OnGrabStart apelat.");
        GameObject grabbedObject = args.interactableObject.transform.gameObject;
        Debug.Log($"Grab START → Ai apucat: {grabbedObject.name}");
    }

    private void OnGrabEnd(SelectExitEventArgs args)
    {
        GameObject releasedObject = args.interactableObject.transform.gameObject;
        Debug.Log($"Grab END → Ai eliberat: {releasedObject.name}");
    }
}
