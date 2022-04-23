/*-----------------------------------------------
 // 作    者：RCY
 // 文 件 名：Commander
 // 创建日期：2022/4/22 10:42:35
 // 功能描述：
 // 修改日期：
 // 修改描述：
-----------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commander : Hero
{
    public int shieldNum;
    
    public void SetShield(int num)
    {
        shieldNum = num;
    }
}
