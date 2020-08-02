using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GameEvent myScript = (GameEvent)target;

        if (GUILayout.Button("Raise"))
        {
            myScript.Raise();
        }
    }
}