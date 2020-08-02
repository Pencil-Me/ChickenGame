using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new GameObjectVariable", menuName = "Variable/GameObject")]
public class GameObjectVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public GameObject InitialValue;
    public GameObject RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
