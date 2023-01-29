using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    [SerializeField] private Color baseColor;
    [SerializeField] private Color offColor;
    [SerializeField] private Color selectColor;
    [SerializeField] private SpriteRenderer renderer;
    [SerializeField] private GameObject highlight;
    private bool isClicked = false;
    private bool isOffset;

    public void Init(bool isOffset) {
        this.isOffset = isOffset;

        if (isOffset) {
            renderer.color = offColor;
        }
        else {
            renderer.color = baseColor;
        }
    }

    void OnMouseEnter() {
        if(ChangeButton.editMode) {
            highlight.SetActive(true);
        }
    }

    void OnMouseExit() {
        highlight.SetActive(false);
    }

    void OnMouseDown() {
        if(ChangeButton.editMode) {
            // if this cell was already clicked
            if (isClicked) {
                if (isOffset) {
                renderer.color = offColor;
            }
            else {
                renderer.color = baseColor;
            }
        } 
        // if this cell is its default colour
        else {
            renderer.color = selectColor;
        }

        // switch
        isClicked = !isClicked;
        }
    }
}