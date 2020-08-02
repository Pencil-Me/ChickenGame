using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : ScriptableObject
{
    [SerializeField]
    private CustomChar cc;
    public InputField nameInput;
    public Text message;

    //Kopf
    //-Kamm         Model
    //--Model
    //--Farbe

    //-Schnabel     Model
    //--Model
    //--Farbe

    //-Augen        Model
    //--Model
    //--Farbe

    //-Halsbehang   Model
    //--Model
    //--Farbe


    //Body
    //-Gefieder     Textur
    //--Farbe
    //--Textur

    //-Schwanz      Model
    //--Model
    //--Farbe

    //-Läufe        Model
    //--Model
    //--Farbe

    //-Statur
    //--Height
    //public void HeightAssign(float value)
    //{
    //    cc.Height = value;
    //}
    //--Muskles
    //--Weight


    //Extras
    //-Tattoos      TexturLayer
    //--TexturLayer
    //--Farbe

    //-Narben       TexturLayer
    //--TexturLayer
    //--Farbe

    //-Schmuck      Model
    //--Model
    //--Farbe
}