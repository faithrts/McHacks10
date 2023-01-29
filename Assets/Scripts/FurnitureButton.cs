using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureButton : MonoBehaviour
{
    [SerializeField] private Button thisButton;

    void Update() {
        if (ChangeButton.editMode) {
            thisButton.interactable = false;
        }
        else {
            thisButton.interactable = true;
        }
    }
}
