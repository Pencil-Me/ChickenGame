using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Vector3Variable", menuName = "Variable/Vector3")]
public class Vector3Variable : ScriptableObject, ISerializationCallbackReceiver
{
    public Vector3 InitialValue;
    public Vector3 RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
