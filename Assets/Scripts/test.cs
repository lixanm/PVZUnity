using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private void OnParticleCollision(GameObject other)
    {
        //获取粒子系统组件
        ParticleSystem particleSystem = GetComponent<ParticleSystem>();

        //禁用粒子的旋转
        var rotationOverLifetimeModule = particleSystem.rotationOverLifetime;
        rotationOverLifetimeModule.enabled = false;

        var mainModule = particleSystem.main;
        mainModule.startRotation = new ParticleSystem.MinMaxCurve(0f);//设置起始旋转为0度
        mainModule.startRotation3D = false;//禁用3D旋转

        var collisionModule = particleSystem.collision;
        collisionModule.bounce = 0f;
        //碰撞不再反弹

        //停止发射
        var main = particleSystem.emission;

        main.enabled = false;

    }

    

}
