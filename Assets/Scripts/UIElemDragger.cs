using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Linq;

public class UIElemDragger : MonoBehaviour
{
    public const string DRAGGABLE_TAG = "UIDraggable";

    private bool dragging = false;

    private Vector2 originPos;
    private int originalID;

    private Transform objectToDrag;
    private Image objectToDragImage;

    List<RaycastResult> hitObjects = new List<RaycastResult>();
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            objectToDrag = GetDraggableTransformUnderMouse();

            if (objectToDrag != null)
            {
                dragging = true;

                objectToDrag.SetAsLastSibling();

                originPos = objectToDrag.position;
                originalID = objectToDrag.GetComponent<TaskID>().order;
                objectToDragImage = objectToDrag.GetComponent<Image>();
                objectToDragImage.raycastTarget = false;
            }
        }

        if (dragging)
        {
            objectToDrag.position = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (objectToDrag != null)
            {
                Transform objectToReplace = GetDraggableTransformUnderMouse();

                if (objectToReplace != null)
                {
                    objectToDrag.position = objectToReplace.position;
                    objectToReplace.position = originPos;
                    objectToDrag.GetComponent<TaskID>().order = objectToReplace.GetComponent<TaskID>().order;
                    objectToReplace.GetComponent<TaskID>().order = originalID;


                }
                else
                {
                    objectToDrag.position = originPos;
                }
                objectToDragImage.raycastTarget = true;
                objectToDrag = null;
            }
            dragging = false;
        }
    }

    private GameObject GetObjectUnderMouse()
    {
        var pointer = new PointerEventData(EventSystem.current);

        pointer.position = Input.mousePosition;

        EventSystem.current.RaycastAll(pointer, hitObjects);

        if (hitObjects.Count <= 0) return null;

        return hitObjects.First().gameObject;
    }

    private Transform GetDraggableTransformUnderMouse()
    {
        GameObject clicked = GetObjectUnderMouse();

        if (clicked != null && clicked.tag == DRAGGABLE_TAG)
        {
            return clicked.transform;
        }
        return null;
    }
}
