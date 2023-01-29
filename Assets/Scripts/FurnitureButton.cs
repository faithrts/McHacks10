using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureButton : MonoBehaviour
{
    [SerializeField] private Button thisButton;

    void Update() {
        if (true) {
            thisButton.interactable = false;
        }
        else {
            thisButton.interactable = true;
        }
    }
}
