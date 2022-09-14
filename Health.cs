using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    public event System.Action<DamageArgs> DamageEvent;
    public event System.Action<DamageArgs> DeathEvent;

    public void Damage(DamageArgs args) { }
    public void Die(DamageArgs args) { }
}

public struct DamageArgs
{
    public GameObject damager;
    public float damage;
}

// Manages health values, takes damage, and dies when appropriate.