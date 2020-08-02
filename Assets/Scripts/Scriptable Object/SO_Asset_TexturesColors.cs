using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetData", menuName = "Asset/TextureColors Data")]
public class SO_Asset_TexturesColors : ScriptableObject, IAsset
{
    [SerializeField] private new string name = "ColorName";
    [SerializeField] private Color color;
    [SerializeField] private Sprite icon;

    public string Name => name;
    public Color Color => color;
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
