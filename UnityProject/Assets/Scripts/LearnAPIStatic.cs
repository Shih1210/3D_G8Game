using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
    //靜態
    //隨機 數學 輸入 時間 除錯
    // Start is called before the first frame update
    void Start()
    {
        //使用靜態屬性
        //類別名稱.靜態屬性
        ///取得靜態屬性
        print(Random.value); //0-1
        print(Mathf.PI);

        //類別名稱.靜態方法(應對引數)
        print(Mathf.Abs(-99));
        print(Random.Range(50, 150));

        Debug.Log("測試~");
        Debug.LogWarning("警告!");
        Debug.LogError("危險!");
    }
    //更新事件:一秒執行約60次
    //監聽玩家輸入事件、時間(像是按下鍵盤)
    private void Update()
    {
        print(Time.time);

        //print(Input.mousePosition);
        //print(Input.GetKeyDown("space"));
        //print(Input.GetKeyDown(KeyCode.Space));
    }

}
