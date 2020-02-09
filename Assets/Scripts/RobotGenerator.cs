using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotGenerator : MonoBehaviour
{
    public GameObject prefab;
    List<RobotGroup> groups = new List<RobotGroup>();
    void Start()
    {
        for (int cnt = 0; cnt<2; cnt++)  //2つのグループ作成
        {
            groups.Add(new RobotGroup(prefab, 0.2f + 0.4f * cnt, 0.3f));
        }

        for(int cnt=0;cnt<2;cnt++)
        {
            groups.Add(new RobotGroup(prefab,0.2f + 0.4f * cnt, 0.3f));
        }
    }

    void Update()
    {
        
    }
}
