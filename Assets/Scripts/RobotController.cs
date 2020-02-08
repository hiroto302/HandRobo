using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    // 使用する画像を連想配列に格納するために初期化
    Dictionary<string, Sprite> pose = new Dictionary<string, Sprite>()
    {
        {"Normal", null},
        {"Right", null},
        {"Left", null},
        {"Both", null},
    };

    void Start()
    {
        foreach(var key in new List<string>(pose.Keys))  //var = KeyValuePair<string, int>、 foreachでは途中で値を変更することができないためListを利用
        {
            Texture2D tex = (Texture2D)Resources.Load("Robot_" + key);  //Resourcesフォルダからspriteの読み込み
            pose[key] = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));  //画像の大きさ、Pivot(回転中心)の設定
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            Pose("Both");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Pose("Left");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Pose("Right");
        }
        else
        {
            Pose("Normal");
        }
}

    public void Pose(string p)
    {
        GetComponent<SpriteRenderer>().sprite = pose[p];
    }
}
