using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetData", menuName = "UI/UIToHide Data")]
public class SO_UIToHide : ScriptableObject
{
    [SerializeField] GameObject[] RegionsToHide;
}
