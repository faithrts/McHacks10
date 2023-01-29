using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawWall : MonoBehaviour
{

    // private Vector3 offset;
    private bool drawing = true;
    [SerializeField] private Wall wallPrefab;

    public void setDraw(){
        drawing = true;
    }


    private void OnMouseDown() {
        if (drawing){
            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var spawnedWall = Instantiate(wallPrefab, worldPosition, Quaternion.identity);
        }
    }
    
    // private void OnMouseUp() {
    //     dragging = false;
    // }
}
