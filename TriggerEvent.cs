using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
public class TriggerEvent : MonoBehaviour
{
    public LayerMask mask;

    [Space]
    public UnityEvent TriggerEnteredEvent;
}

// Just needs to call TriggerEnteredEvent when the OnTriggerEntered message is called.