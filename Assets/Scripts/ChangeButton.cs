using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButton : MonoBehaviour
{

    public Sprite pencilButton;
    public Sprite couchButton;
    public Button button;

    public static bool editMode;

    void Start() {
        editMode = true;
    }

    public void ChangeButtonImage() {
        // changing from furniture-adding mode to room-drawing mode
        if(button.image.sprite == pencilButton) {
            button.image.sprite = couchButton;
        }
        // changing from room-drawing mode to furniture-adding mode
        else {
            button.image.sprite = pencilButton;
        }

        editMode = !editMode;
    }
}
