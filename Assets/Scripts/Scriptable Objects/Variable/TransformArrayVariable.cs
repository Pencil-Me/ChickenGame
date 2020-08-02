using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new TransformArrayVariable", menuName = "Variable/TransformArray")]
public class TransformArrayVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public Transform[] InitialValue;
    public Transform[] RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}