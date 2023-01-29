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

    private Vector2 coords;
    private bool isClicked = false;
    private bool isOffset;

    public void Init(bool isOffset, Vector2 coords) {
        this.isOffset = isOffset;
        this.coords = coords;

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
            // if this cell was already selected, de-selects it
            if (isClicked) {
                if (isOffset) {
                renderer.color = offColor;
                }
                else {
                renderer.color = baseColor;
                }

                // removes current cell from the clicked dictionary
                GridManager.chosenCells.Remove(coords);
                int LayerDefault = LayerMask.NameToLayer("Default");
                //Cell cell = GridManager.getCellAtPosition(coords);
                renderer.gameObject.layer = LayerDefault;
            } 
            // if this hasn't already been selected
            else {
                renderer.color = selectColor;

                // adds current cell from the clicked dictionary
                GridManager.chosenCells.Add(coords, this);
                int LayerIgnoreColl = LayerMask.NameToLayer("Ignore Collisions");
                //Cell cell = GridManager.getCellAtPosition(coords);
                renderer.gameObject.layer = LayerIgnoreColl;
            }

        // switch
        isClicked = !isClicked;
        }
    }
}