using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    private void OnParticleCollision(GameObject other)
    {
        //��ȡ����ϵͳ���
        ParticleSystem particleSystem = GetComponent<ParticleSystem>();

        //�������ӵ���ת
        var rotationOverLifetimeModule = particleSystem.rotationOverLifetime;
        rotationOverLifetimeModule.enabled = false;

        var mainModule = particleSystem.main;
        mainModule.startRotation = new ParticleSystem.MinMaxCurve(0f);//������ʼ��תΪ0��
        mainModule.startRotation3D = false;//����3D��ת

        var collisionModule = particleSystem.collision;
        collisionModule.bounce = 0f;
        //��ײ���ٷ���

        //ֹͣ����
        var main = particleSystem.emission;

        main.enabled = false;

    }

    

}
