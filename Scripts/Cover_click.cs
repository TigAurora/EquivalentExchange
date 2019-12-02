using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cover_click : MonoBehaviour
{
    public GameObject btnObj;
    public Sprite expan;
    public Sprite back;
    Button btn;
    public int flag = 0;
    void Start()
    {
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            if (flag == 0)
            {
                this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(431F, 930F);
                this.gameObject.transform.localPosition = new Vector3(484.5F, -60F, 0F);
                btn.GetComponent<Image>().sprite = back;
                flag = 1;
            }
            else
            {
                this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1400F, 651F);
                this.gameObject.transform.localPosition = new Vector3(0, -199.5F, 0F);
                btn.GetComponent<Image>().sprite = expan;
                flag = 0;
            }
        });
    }

}