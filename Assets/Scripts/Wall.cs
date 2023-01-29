using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private Color baseColor;
    [SerializeField] private Color offColor;
    [SerializeField] private Color selectColor;
    [SerializeField] private SpriteRenderer renderer;
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

    void OnMouseDown() {
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
