using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomChar : MonoBehaviour
{
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
    [SerializeField] float Height;
    //--Muskles
    //public float Muscle;
    //--Weight
    //public float Weight;


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

    /*public SpriteRenderer hairBack;
    public SpriteRenderer hairFront;
    public SpriteRenderer ear;
    public SpriteRenderer body;
    public SpriteRenderer eyebrow;
    public SpriteRenderer eye;
    public SpriteRenderer mouth;
    public SpriteRenderer effect;
    public SpriteRenderer faceOption;*/
    [SerializeField] string charName;

    [SerializeField] Texture texture;
    [SerializeField] Color textureColor;
    [SerializeField] Renderer[] Rend;

    GameObject Schnabel;
    [SerializeField] Transform SchnabelBone;

    GameObject Kamm;
    [SerializeField] Transform KammBone;

    GameObject Eyes;
    [SerializeField] Transform EyesBone;

    GameObject Schwanz;
    [SerializeField] Transform SchwanzBone;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void setTexture(Texture i)
    {
        texture = i;
        foreach (var r in Rend)
        {
            r.enabled = true;
            //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
            r.GetComponent<Renderer>().material.SetTexture("_MainTex", texture);
            //Set the Normal map using the Texture you assign in the Inspector
            //r.GetComponent<Renderer>().material.SetTexture("_BumpMap", m_Normal);
            //Set the Metallic Texture as a Texture you assign in the Inspector
            //r.GetComponent<Renderer>().material.SetTexture("_MetallicGlossMap", m_Metal);
        }
    }
    public void setTextureColor(Color col)
    {
        textureColor = col;
        foreach (var r in Rend)
        {
            r.enabled = true;
            //Call SetColor using the shader property name "_Color" and setting the color to red
            r.GetComponent<Renderer>().material.SetColor("_Color", col);
        }
    }

    public void setSchnabel(GameObject i)
    {
        Destroy(Schnabel);
        Schnabel = Instantiate(i);
        Schnabel.transform.SetParent(SchnabelBone, false);
    }

    public void setKamm(GameObject i)
    {
        Destroy(Kamm);
        Kamm = Instantiate(i);
        Kamm.transform.SetParent(KammBone, false);
    }

    public void setEyes(GameObject i)
    {
        Destroy(Eyes);
        Eyes = Instantiate(i);
        Eyes.transform.SetParent(EyesBone, false);
    }

    public void setSchwanz(GameObject i)
    {
        Destroy(Schwanz);
        Schwanz = Instantiate(i);
        Schwanz.transform.SetParent(SchwanzBone, false);
    }

    public void setHeight(float i)
    {
        float baseHeight = .90f;
        Height = baseHeight + .20f * i;
        transform.localScale = new Vector3(1,Height,1);
    }
}
