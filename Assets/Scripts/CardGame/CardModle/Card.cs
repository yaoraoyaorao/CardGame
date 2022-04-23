/*-----------------------------------------------
 // 作    者：RCY
 // 文 件 名：Card
 // 创建日期：2022/4/22 10:25:39
 // 功能描述：卡牌基类
 // 修改日期：
 // 修改描述：
-----------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{

    #region 属性
    public string ID;
    public string name;
    public string description;
    public int cost;
    public E_CardType cardType;
    public E_CardOcc cardOcc;
    public E_Target cardTarget;
    
    private bool isLock = true;
    private bool isGold = false;

    public bool Lock => isLock;

    public bool Gold => isGold;
    #endregion

    #region 公共方法
    public void SetLock(bool isLock)
    {
        this.isLock = isLock;
    }

    public void SetGold(bool isGold)
    {
        this.isLock = isGold;
    }
    #endregion


}
