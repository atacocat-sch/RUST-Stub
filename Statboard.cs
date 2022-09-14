using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[SelectionBase]
[DisallowMultipleComponent]
public class Statboard : MonoBehaviour
{
    public Stat GetStat(string statKey) { }
    public List<Artifact> GetArtifactList(string statKey);
    public void AddArtifact(string statKey, Artifact artifact);
}

[System.Serializable]
public class Stat
{
    public string key;
    public float baseValue;
    public List<Artifact> artifacts;

    public Stat() { }
}