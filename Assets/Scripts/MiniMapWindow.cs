using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapAnim : MonoBehaviour
{
    public Transform image;
    
    private void OnEnable() {
        image.localPosition = new Vector2(0, -Screen.height);
    }

    private void OnClose() {

    }
}
