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
        if(button.image.sprite == pencilButton) {
            button.image.sprite = couchButton;
        }
        else {
            button.image.sprite = pencilButton;
        }

        editMode = !editMode;
    }
}
