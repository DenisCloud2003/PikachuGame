using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotItem : MonoBehaviour
{
    int x, y;
    public Image imgIcon;
    int idItem;

    public Action<SlotItem> onSlotClick;

    public void OnInitSlot(int rows, int cols, Sprite spr, int id, Action<SlotItem> _onSlotClick)
    {
        x = rows;
        y = cols;
        idItem = id;
        imgIcon.sprite = spr;
        onSlotClick = _onSlotClick;
        
    }

    public void OnSlotClick()
    {
        onSlotClick?.Invoke(this);
    }

    public override string ToString()
    {
        return "x=" + x + " y=" + y;
    }
}
