using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(InputArbiter))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    // not filled due to discrepancy on which movement system to use.
}

// moves player, still need to decide whether system is going to by physics or animation driven. -for simplicity, probably animation driven.