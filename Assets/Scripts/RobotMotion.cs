using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RobotMotion
{
    Action<RobotController, float> animation;  //Actionを使う時、using Systemを書き加えること
    float duration;  //Animationの終了時間
    float pastTime = 0;  //経過時間

    public RobotMotion(Action<RobotController, float> animation, float duration)
    {
        this.animation = animation;  //クラス変数をこのメソッドの引数に指定した変数に代入
        this.duration = duration;
    }

    public bool Animate(RobotController robot, float deltaTime)
    {
        pastTime += deltaTime;
        animation(robot, pastTime / duration);
        return pastTime >= duration;
    }
}