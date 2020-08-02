using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new BoolVariable", menuName = "Variable/Bool")]
public class BoolVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public bool InitialValue;
    public bool RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
