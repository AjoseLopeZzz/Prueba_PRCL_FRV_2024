using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPokeToFingerAttachPoint : MonoBehaviour
{
    public Transform PokeAttachPoint;

    private XRPokeInteractor Pokeinteractor;
    // Start is called before the first frame update
    void Start()
    {
        Pokeinteractor = transform.parent.GetComponentInChildren<XRPokeInteractor>();
    }

    void SetPokeAttachPoint()
    {
        if (Pokeinteractor == null) 
        {
            Debug.Log("Poke Attach Point is null"); return;
        }

        if (Pokeinteractor == null) 
        {
            Debug.Log("XR Poke Interactor is null"); return;
        }

        Pokeinteractor.attachTransform = PokeAttachPoint;
    }
}
