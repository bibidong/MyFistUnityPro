/***********************************
*    Description: set 和 get 挂载对象可否点击
*    Mountpoint：挂载点为需要添加该属性的对象
***********************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Able_Click : MonoBehaviour
{
    public bool _clickable = false;

    public bool Clickable
    {
        get
        {
            return _clickable;
        }
        set
        {
            _clickable = value;
        }

    }
}
