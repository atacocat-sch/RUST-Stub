using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
public class InputArbiter : MonoBehaviour, IController
{
    // This will most likley change a lot during production depending on what input we require.
    // In that case, press/release actions will use events, and continuous values will be a getter.

    public Vector3 MovementDirection { get; }
    
    public event System.Action<float> JumpEvent;
    public event System.Action<float> LightAttackEvent;
    public event System.Action<float> HeavyAttackEvent;
}

// acts as arbiter between the new input system and genertic bipedal components.