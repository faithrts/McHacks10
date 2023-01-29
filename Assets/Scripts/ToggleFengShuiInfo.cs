using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleFengShuiInfo : MonoBehaviour
{
    public Button pencilButton;
    public Button FengShuiButton;
    private bool clicked = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked() {
        if (clicked) {
            FengShuiButton.gameObject.SetActive(false);
        }
        else {
            FengShuiButton.gameObject.SetActive(true);
        }
        clicked = !clicked;
    }
}
