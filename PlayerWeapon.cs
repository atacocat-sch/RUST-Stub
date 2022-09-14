using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
[RequireComponent(typeof(InputArbiter))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerWeapon : MonoBehaviour
{
    public event System.Action<int> AttackStartEvent;
    public event System.Action<int, GameObject> HitEvent;
    public event System.Action<int> AttackEndEvent;
}