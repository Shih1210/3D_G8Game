using UnityEngine;//使用unity API

//類別 類別名稱
public class Chicken : MonoBehaviour
{
    #region 欄位區域
    //宣告變數(定義欄位 Field)
    //修飾詞 欄位類型 欄位名稱(指定 數值)結束；
    //私人 Private ；公開 Public
    [Header("移動速度")][Range(1,2000)]
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

    public Transform tran;
    public Rigidbody rig;
    public Animator ani;

    private void Update()
    {
        Turn();
        Run();
        Bark();
        Catch();
    }

    #region 方法區域
    ///<summary>
    ///跑步
    ///</summary>
    private void Run()
    {
        float v = Input.GetAxis("Vertical");    //W上 1，S下 -1 ，沒有 0
        //rig.AddForce(0, 0, speed * v);                //世界座標
        //tran.forward 區域座標Z軸
        //tran.right   區域座標X軸
        //tran.up      區域座標Y軸
        rig.AddForce(tran.forward * speed * v*Time.deltaTime);       //區域座標
    }
    ///<summary>
    ///旋轉
    ///</summary>
    private void Turn()
    {
        float h = Input.GetAxis("Horizontal");    //A左 -1，D右 1 ，沒有 0
        tran.Rotate(0, turn * h * Time.deltaTime, 0);
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
        Animator 撿東西;
        float 撿東西觸發器;


    }
    ///<summary>
    ///檢視任務
    ///</summary>
    private void Task()
    {

    }
    #endregion
}


