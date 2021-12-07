using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayMenuHandler : MonoBehaviour
{

    [SerializeField]
    GameObject HowToPlayPanelPrefab;

    GameObject howToPlayPanelObject;

    Canvas parentCanvas;
    void Start()
    {
        if (!HowToPlayPanelPrefab)
        {
            Debug.LogError("HowToPlayPanelPrefab undefined! Set HowToPlayPanelPrefab in the inspector.");
        }

        parentCanvas = GetComponentInParent<Canvas>();
        if (!parentCanvas)
        {
            Debug.LogError("Unable to locate parent Canvas! Make sure this object's parent has a Canvas component.");
        }
    }

    void Update()
    {
        
    }

    public void ShowHowToPlayPanel()
    {
        if (!HowToPlayPanelPrefab || howToPlayPanelObject)
            return;

        howToPlayPanelObject = Instantiate(HowToPlayPanelPrefab, parentCanvas.transform);
    }
}
