using UnityEngine;
using UnityEngine.UI;

public class CameraFloorSystem : MonoBehaviour
{
    public int countFloor;
    public Text textCount;

    private void Update()
    {
        Move();
        Count();
    }

    private void Move()
    {
        transform.Translate(0, Time.deltaTime * -2, 0);
    }

    /// <summary>
    /// 判斷層數
    /// </summary>
    private void Count()
    {
        // 層數 = 絕對值((轉整數)攝影機.Y 軸 / 2)
        // - 攝影機 Y 軸取絕對值當作層數
        // - / 2 讓層數變慢，可自行調整
        countFloor = Mathf.Abs((int)transform.position.y / 2);
        textCount.text = "層數：" + countFloor;
    }
}
