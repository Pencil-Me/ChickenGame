using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_AssetButton : MonoBehaviour
{
    private Sprite image;
    [SerializeField] private Text Text;
    [SerializeField] private Image Icon;

    public void setText(string t)
    {
        Text.text = t;
    }

    public void setIcon(Sprite i)
    {
        Icon.sprite = i;
    }

    public void setColor(Color c)
    {
        Icon.color = c;
    }
}
