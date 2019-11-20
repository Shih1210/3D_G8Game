using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //定義方法
    //語法
    //修飾詞 傳回類型 方法名稱(參數)[陳述式或演算法]
    //參數類型 參數名稱 參數:方便後續維護
    //void 無傳回
    //自訂需要被呼叫
    /// <summary>
    /// 開車方法
    /// </summary>
    /// <param name="speed">開車速度</param>
    private void Drive(int speed)
    {
        //輸出訊息(字串);
        print("音效~");
        //可使用+符號連接字串與其他類型
        print("開車，時速:" + speed);
    }

    //有預設值的參數 選填式參數 呼叫時可不填寫
    //選填式參數只能寫在最右邊
    private void shoot(int count, float speed, string prop = "無",string direction = "前方") 
    {
        print("弓箭數量:"+count);
        print("弓箭速度:"+speed);
        print("弓箭屬性:"+prop);
        print("弓箭方向:"+direction);
    }

    //事件:在指定的時間會以指定次數執行的方法
    //start 初始事件:遊戲播放後執行一次
    private void Start()
    {
        print("哈囉，沃的~");

        //自訂的呼叫方式 寫幾次撥放幾次
        Drive(200);
        Drive(300);

        shoot(1, 1.5f);
        shoot(10, 10.5f,"火屬性");
        shoot(3,2,direction:"前後方");
    }
}
