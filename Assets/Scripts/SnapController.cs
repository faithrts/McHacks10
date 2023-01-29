using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapController : MonoBehaviour
{
    public List<Transform> snapPoints;
    public List<MouseDrag> dragObjects;
    public float snapRange = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        foreach(MouseDrag drag in dragObjects){
            drag.dragEndedCallback = onDragEnded;
        }
    }

    // Update is called once per frame
    private void onDragEnded(MouseDrag drag){
        float dist = -1;
        Transform closest_point = null;

        foreach(Transform snapPoint in snapPoints){
            float currentDistance = Vector2.Distance(drag.transform.localPosition, snapPoint.localPosition);
            if (closest_point == null || currentDistance < dist){
                closest_point = snapPoint;
                dist = currentDistance;
            }

            if (closest_point != null && dist <= snapRange){
                drag.transform.localPosition = closest_point.localPosition;
            }
        }
    }
}
