﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetData", menuName = "Asset/Eyes Data")]
public class SO_Asset_Eyes : ScriptableObject, IAsset
{
    [SerializeField] private string name;
    [SerializeField] private GameObject model;
    [SerializeField] private Sprite icon;

    public string Name => name;
    public GameObject Model => model;
    public Sprite Icon => icon;

    public Sprite getIcon()
    {
        return Icon;
    }

    public string getName()
    {
        return Name;
    }
}
