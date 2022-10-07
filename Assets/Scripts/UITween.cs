using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITween : MonoBehaviour
{
    [SerializeField]
    GameObject applicationGroup, introGroup, miniMapWindow, helperButton, helperComponent,
    environtment;
    void Start()
    {
        environtment.SetActive(false);
        LeanTween.alpha(helperButton.GetComponent<RectTransform>(), 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            LeanTween.moveLocal(miniMapWindow, new Vector3(125f, -800f, 0f), 0.7f).setEase(LeanTweenType.easeOutCirc);
            LeanTween.alpha(helperButton.GetComponent<RectTransform>(), 0f, .1f);
            LeanTween.alpha(introGroup.GetComponent<RectTransform>(), 1f, .1f).setDelay(.5f);
            helperComponent.SetActive(false);
            // LeanTween.moveLocal(applicationGroup, new Vector3(-125f, -1760f, 0f), 0.7f).setEase(LeanTweenType.easeOutCirc); // ini app group
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            LeanTween.moveLocal(miniMapWindow, new Vector3(125f, 6f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeInOutCirc);
            LeanTween.alpha(helperButton.GetComponent<RectTransform>(), 1f, .1f).setDelay(.5f);
            LeanTween.alpha(introGroup.GetComponent<RectTransform>(), 0f, .25f);
            // LeanTween.moveLocal(applicationGroup, new Vector3(-125f, -90f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeInOutCirc); // ini app group
        }
    }

    public void showIntro()
    {
        environtment.SetActive(false);
        LeanTween.moveLocal(miniMapWindow, new Vector3(125f, -800f, 0f), 0.7f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.alpha(helperButton.GetComponent<RectTransform>(), 0f, .1f);
        LeanTween.alpha(introGroup.GetComponent<RectTransform>(), 1f, .1f).setDelay(.5f);
        helperComponent.SetActive(false);
    }

    public void showApplication()
    {
        environtment.SetActive(true);
        LeanTween.moveLocal(miniMapWindow, new Vector3(125f, 6f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.alpha(helperButton.GetComponent<RectTransform>(), 1f, .1f).setDelay(.5f);
        LeanTween.alpha(introGroup.GetComponent<RectTransform>(), 0f, .25f);
    }
}
