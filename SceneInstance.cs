using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Scriptable Objects/Scene Managment/Scene Instance")]
public class SceneInstance : ScriptableObject
{
    public int buildIndex;
}

// A reference solution to unity's abhorrent buildIndex scene loading.