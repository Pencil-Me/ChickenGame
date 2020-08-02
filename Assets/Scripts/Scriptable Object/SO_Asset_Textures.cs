using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetData", menuName = "Asset/Textures Data")]
public class SO_Asset_Textures : ScriptableObject, IAsset
{
    [SerializeField] private new string name = "TextureName";
    [SerializeField] private Texture texture;
    [SerializeField] private Sprite icon;

    public string Name => name;
    public Texture Texture => texture;
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
