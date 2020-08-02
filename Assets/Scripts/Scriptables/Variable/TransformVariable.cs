using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new TransformVariable", menuName = "Variable/Transform")]
public class TransformVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public Transform InitialValue;
    public Transform RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
