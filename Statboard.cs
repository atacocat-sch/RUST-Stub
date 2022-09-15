using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
public class Statboard : MonoBehaviour
{
    public List<Stat> stats;
    public List<Artifact> artifacts;

    public Stat GetStat(string statKey) { }
}

[System.Serializable]
public class Stat
{
    public string key;
    public float baseValue;

    public Stat() { }

    public float Calculate (GameObject ctx, List<Artifact> artifacts) { }
}