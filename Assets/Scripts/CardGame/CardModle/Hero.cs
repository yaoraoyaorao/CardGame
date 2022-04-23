/*-----------------------------------------------
 // 作    者：RCY
 // 文 件 名：Hero
 // 创建日期：2022/4/22 10:39:21
 // 功能描述：英雄牌 继承卡牌类
 // 修改日期：
 // 修改描述：
-----------------------------------------------*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero :Card
{
    public int hp;
    public int atk;

    public void SetHp(int hp)
    {
        this.hp = hp;
    }

    public void SetAtk(int atk)
    {

        this.atk = atk;
    }
}
