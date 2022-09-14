using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Objects/Game Data/Game Generator")]
public class GameGenerator : ScriptableObject
{
    public GameData gameData;
    public List<RoomGroup> roomGroups;

    public void GenerateGame () { }
}

[System.Serializable]
public class RoomGroup
{
    public int selectionCount;
    public List<SceneInstance> rooms;
}

// Propogates GameData's list of scenes with the current runs scenes.