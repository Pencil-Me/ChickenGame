using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AssetData", menuName = "Asset/Assets Container Data")]
public class SO_Assets : ScriptableObject
{
    public SO_Asset_Kamm[] Kamm;
    public SO_Asset_Eyes[] Eye;
    public SO_Asset_Schnabel[] Schnabel;
    public SO_Asset_Schwanz[] Schwanz;
    public SO_Asset_Textures[] Textures;
    public SO_Asset_TexturesColors[] TextureColors;
}
