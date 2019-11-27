﻿using UnityEngine;//使用unity API

//類別 類別名稱
public class Chicken : MonoBehaviour
{
    #region 欄位區域
    //宣告變數(定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱(指定 數值)結束；
    //私人 Private ；公開 Public
    [Header("移動速度")][Range(1,100)]
    public int speed = 10;
    [Header("移動速度")]
    [Tooltip("雞的旋轉速度"),Range(1.5f,200f)]
    //說明文字 Range(最小值,最大值)→拉桿
    public float turn = 20.5f;
    [Header("是否完成任務")]
    public bool mission;
    [Header("玩家名稱")]
    public string Name ="Chicken ";
    #endregion

    #region 方法區域
    ///<summary>
    ///跑步
    ///</summary>
    private void Run()
    {

    }
    ///<summary>
    ///旋轉
    ///</summary>
    private void Turn()
    {

    }
    ///<summary>
    ///亂叫
    ///</summary>
    private void Bark()
    {

    }
    ///<summary>
    ///撿東西
    ///</summary>
    private void Catch()
    {

    }
    ///<summary>
    ///檢視任務
    ///</summary>
    private void Task()
    {

    }
    #endregion
}


