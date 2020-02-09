using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// : MonoBehaviour start,Updateメソッドを使わない場合MonoBehabiourクラスを継承する必要がないので削除して良い
public class RobotGroup{

    List<RobotController> robots = new List<RobotController>();

    public RobotGroup(GameObject prefab, float px, float py)  //インスタンス生成された時に呼ばれるメソッド、コンストラクター、クラス名と同じメソッドにより作成出来る
    {
        //計９回のループ
        for(int x = 0; x<3; x++)
        {
            for(int y = 0; y<3; y++)
            {
                Vector3 p = Camera.main.ViewportToWorldPoint(new Vector3(px + 0.1f * x, py + 0.13f * y, 0));  //ビューポートからワールド座標への変換
                p.z = 0;
                GameObject obj = Object.Instantiate(prefab, p, Quaternion.identity);
                robots.Add(obj.GetComponent<RobotController>());  //生成したロボットの保存
            }
        }
    }
}





