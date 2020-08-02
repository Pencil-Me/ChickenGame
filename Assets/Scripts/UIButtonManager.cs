using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManager : MonoBehaviour
{
    [SerializeField] GameObject[] RegionsToHide;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < RegionsToHide.Length; i++)
        {
            RegionsToHide[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton(GameObject RegionToShow = null)
    {
        for (int i = 0; i < RegionsToHide.Length; i++)
        {
            RegionsToHide[i].SetActive(false);
        }

        if (RegionToShow != null)
            RegionToShow.SetActive(true);
    }
}
