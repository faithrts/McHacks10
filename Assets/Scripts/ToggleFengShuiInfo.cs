using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleFengShuiInfo : MonoBehaviour
{
    public Button FengShuiButton;
    public Button self;

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
            self.GetComponent<Image>().color = new Color(255, 255, 71);
        }
        else {
            FengShuiButton.gameObject.SetActive(true);
            self.GetComponent<Image>().color = new Color(255, 255, 255);
        }
        clicked = !clicked;
    }
}
