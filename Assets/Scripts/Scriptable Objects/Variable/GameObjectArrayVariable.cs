using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new GameObjectArrayVariable", menuName = "Variable/GameObjectArray")]
public class GameObjectArrayVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public GameObject[] InitialValue;
    public GameObject[] RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
