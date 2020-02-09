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
        int mcode = MouseCode();
        if(mcode == 1 || mcode == 2)
        {
            RobotMotion[] motions = new RobotMotion[] {
                new RobotMotion(
                    (r, p) =>
                    {
                        if (p >= 0.5)
                        {
                            r.Pose("Left");
                        }
                    }, 2f
                    ),
                new RobotMotion(
                    (r, p) =>
                    {
                        if (p >= 0.5)
                        {
                            r.Pose("Right");
                        }
                    }, 2f
                    ),
            };

            foreach(var g in groups)
            {
                g.MotionRandom(motions);
            }
        }
    }
    int MouseCode()
    {
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            return 3;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            return 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }
}