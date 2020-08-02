using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new StringVariable", menuName = "Variable/String")]
public class StringVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public string InitialValue;
    public string RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
