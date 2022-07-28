using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionReceptor : MonoBehaviour
{
    public GameObject InteractionTarget;
    public Text Dialog;

    public void Interaction(GameObject interactionTarget)
    {
        InteractionTarget ??= interactionTarget;
        Dialog.text = $"Object name: {interactionTarget.name}";
    }
}
