using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    [SerializeField]
    GameObject helperComponent;
    bool helperComponentIsVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        helperComponent.SetActive(helperComponentIsVisible);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HelperComponentVisibility()
    {
        Debug.Log("udah disappear");
        helperComponentIsVisible = !helperComponentIsVisible;
        helperComponent.SetActive(helperComponentIsVisible);
    }
}
