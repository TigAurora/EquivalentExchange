using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class BookDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 beginPos;
    private Image image;
    private static Transform canvasTra;
    private Camera canvasCamera = null;
    void Start()
    {
        beginPos = this.transform.position;
        image = this.transform.GetComponent<Image>();
        print("drag!!");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        image.raycastTarget = false;
        beginPos = this.transform.position;
        this.transform.SetAsLastSibling();
        if (canvasTra == null) canvasTra = GameObject.Find("Room").transform;
        canvasCamera = canvasTra.GetComponentInChildren<Camera>();
        this.transform.SetParent(canvasTra);
    }

    public void OnDrag(PointerEventData eventData)
    {
        SetDraggedPosition(eventData);
        //transform.position = Input.mousePosition;
        //transform.position = canvasCamera.ScreenToWorldPoint(Input.mousePosition); 
        //transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject go = eventData.pointerCurrentRaycast.gameObject;
        //print(go.tag);
        if (go != null && go.transform != this.transform && go.tag == "Book")
        {
            //BookDrag drag = eventData.pointerEnter.GetComponent<BookDrag>();

            Vector3 length = this.transform.GetComponent<Collider2D>().bounds.size;
            float x1 = length.x;
            //float y = length.y;
            Vector3 length2 = go.transform.GetComponent<Collider2D>().bounds.size;
            float x2 = length2.x;
            //float y2 = length2.y;


            float posx = go.transform.position.x;
            float posy = beginPos.y;
            Vector3 temp = go.transform.position;
            temp.x = beginPos.x;
            go.transform.position = temp;
            temp = this.transform.position;
            temp.x = posx;
            temp.y = posy;
            this.transform.position = temp;
            //transform.localScale = Vector3.one;
            PlayerPrefs.SetString("Drag", "on");
        }
        else
        {
            this.transform.position = beginPos;
            //transform.localScale = Vector3.one;
            //Destroy(this.gameObject);
            //print("else");
        }
        image.raycastTarget = true;
    }
    private void SetDraggedPosition(PointerEventData eventData)
    {
        var rt = gameObject.GetComponent<RectTransform>();

        // transform the screen point to world point int rectangle
        Vector3 globalMousePos;
        if (RectTransformUtility.ScreenPointToWorldPointInRectangle(rt, eventData.position, eventData.pressEventCamera, out globalMousePos))
        {
            rt.position = globalMousePos;
        }
    }

}
