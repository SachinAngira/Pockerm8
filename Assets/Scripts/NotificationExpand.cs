using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationExpand : MonoBehaviour
{
    public RectTransform RT,holder;
    public GameObject Srinkbtn, ExpandBtn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSrink()
    {
     //   RT.sizeDelta = new Vector2(RT.sizeDelta.x,RT.sizeDelta.y - 178f);
        holder.sizeDelta = new Vector2(RT.sizeDelta.x, 274f);
        ExpandBtn.SetActive(true);
        Srinkbtn.SetActive(false);
    }
    public void OnExpend()
    {
        holder.sizeDelta = new Vector2(RT.sizeDelta.x, 434.3f);
        ExpandBtn.SetActive(false);
        Srinkbtn.SetActive(true);
    }
}
