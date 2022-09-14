using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Objects/Game Data/Game Data")]
public class GameData : ScriptableObject
{
    public List<SceneInstance> levelList;
    public int currentLevel;

    public void LoadNextLevel ();
}

// Holds data pertaining to the current run.