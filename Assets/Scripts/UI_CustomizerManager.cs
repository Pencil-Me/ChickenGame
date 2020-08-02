using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CustomizerManager : MonoBehaviour
{
    [SerializeField] GameObject Charakter;

    [SerializeField] GameObject AssetButton;
    [SerializeField] SO_Assets AssetsList;

    [SerializeField] RectTransform Gefieder;
    [SerializeField] RectTransform GefiederColor;

    [SerializeField] RectTransform Schnabel;
    [SerializeField] RectTransform Kamm;
    [SerializeField] RectTransform Eyes;
    [SerializeField] RectTransform Schwanz;

    private void Start()
    {
        clickGefieder(AssetsList.Textures[0].Texture);
        for (var i = 0; i < AssetsList.Textures.Length; i++)
        {
            Texture t = AssetsList.Textures[i].Texture;
            var btn = fillButtons(AssetsList.Textures[i], Gefieder);
            btn.onClick.AddListener(delegate () { clickGefieder(t); });
        }

        clickGefiederColor(AssetsList.TextureColors[0].Color);
        for (var i = 0; i < AssetsList.TextureColors.Length; i++)
        {
            Color t = AssetsList.TextureColors[i].Color;
            var btn = fillButtons(AssetsList.TextureColors[i], GefiederColor, t);
            btn.onClick.AddListener(delegate () { clickGefiederColor(t); });
        }

        clickSchnabel(AssetsList.Schnabel[0].Model);
        for (var i = 0; i < AssetsList.Schnabel.Length; i++)
        {
            GameObject t = AssetsList.Schnabel[i].Model;
            var btn = fillButtons(AssetsList.Schnabel[i], Schnabel);
            btn.onClick.AddListener(delegate () { clickSchnabel(t); });
        }

        clickKamm(AssetsList.Kamm[0].Model);
        for (var i = 0; i < AssetsList.Kamm.Length; i++)
        {
            GameObject t = AssetsList.Kamm[i].Model;
            var btn = fillButtons(AssetsList.Kamm[i], Kamm);
            btn.onClick.AddListener(delegate () { clickKamm(t); });
        }

        clickEyes(AssetsList.Eye[0].Model);
        for (var i = 0; i < AssetsList.Eye.Length; i++)
        {
            GameObject t = AssetsList.Eye[i].Model;
            var btn = fillButtons(AssetsList.Eye[i], Eyes);
            btn.onClick.AddListener(delegate () { clickEyes(t); });
        }

        clickSchwanz(AssetsList.Schwanz[0].Model);
        for (var i = 0; i < AssetsList.Schwanz.Length; i++)
        {
            GameObject t = AssetsList.Schwanz[i].Model;
            var btn = fillButtons(AssetsList.Schwanz[i], Schwanz);
            btn.onClick.AddListener(delegate () { clickSchwanz(t); });
        }
    }


    public void clickGefieder(Texture i)
    {
        Charakter.GetComponent<CustomChar>().setTexture(i);
    }

    public void clickGefiederColor(Color i)
    {
        Charakter.GetComponent<CustomChar>().setTextureColor(i);
    }

    public void clickSchnabel(GameObject i)
    {
        Charakter.GetComponent<CustomChar>().setSchnabel(i);
    }

    public void clickKamm(GameObject i)
    {
        Charakter.GetComponent<CustomChar>().setKamm(i);
    }

    public void clickEyes(GameObject i)
    {
        Charakter.GetComponent<CustomChar>().setEyes(i);
    }

    public void clickSchwanz(GameObject i)
    {
        Charakter.GetComponent<CustomChar>().setSchwanz(i);
    }


    Button fillButtons(IAsset al, RectTransform parent, Color ? c = null)
    {
        var obj = Instantiate(AssetButton);
        obj.transform.SetParent(parent, false);

        var button = obj.GetComponent<UI_AssetButton>();
        button.setText(al.getName());
        button.setIcon(al.getIcon());
        button.setColor(c ?? Color.white);

        Button btn = obj.GetComponent<Button>();
        return btn;
    }
}
