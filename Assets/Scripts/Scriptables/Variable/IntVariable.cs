﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new IntVariable", menuName = "Variable/Int")]
public class IntVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public int InitialValue;
    public int RuntimeValue;

    public void OnAfterDeserialize()
    {
        RuntimeValue = InitialValue;
    }

    public void OnBeforeSerialize()
    {
    }
}
