using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolbarManager : MonoBehaviour
{
    public Button pencilButton;
    public Button doorButton;
    public Button windowButton;
    public Button furnitureButton;

    public static bool pencilMode;
    public static bool doorMode;
    public static bool windowMode;
    public static bool furnitureMode;

    public Button curButton;

    Color unselectedColor = Color.white;
    Color selectedColor = new Color(0, 229, 255);

    // Start is called before the first frame update
    void Start()
    {
        pencilMode = true;
        doorMode = false;
        windowMode = false;
        furnitureMode = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ButtonSelected()
    {
        if (curButton == pencilButton) {
            pencilMode = true;
            doorMode = false;
            windowMode = false;
            furnitureMode = false;
        }
        else if (curButton == doorButton) {
            pencilMode = false;
            doorMode = true;
            windowMode = false;
            furnitureMode = false;
        }
        else if (curButton == windowButton) {
            pencilMode = false;
            doorMode = false;
            windowMode = true;
            furnitureMode = false;
        }
        else if (curButton == furnitureButton) {
            pencilMode = false;
            doorMode = false;
            windowMode = false;
            furnitureMode = true;
        }
        /*
        if (button == curButton) {
            button.GetComponent<Image>().color = unselectedColor;
            curButton = null;
        }
        else {
            if (curButton != null) {
                curButton.GetComponent<Image>().color = unselectedColor;
            }
            button.GetComponent<Image>().color = selectedColor;
        }*/

        /*
        if (pencilButton.selected) {
            doorButton.selected = false;
            windowButton.selected = false;
            couchButton.selected = false;
        }
        else if (doorButton.selected) {
            pencilButton.selected = false;
            windowButton.selected = false;
            ouchButton.selected = false;
        }
        else if (windowButton.selected) {
            pencilButton.selected = false;
            doorButton.selected = false;
            couchButton.selected = false;
        }
        else if (couchButton.selected) {
            pencilButton.selected = false;
            doorButton.selected = false;
            windowButton.selected = false;
        }*/

    }
}
