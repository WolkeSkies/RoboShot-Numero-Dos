using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.Game
{
    public class ExplosionForce : MonoBehaviour
    {
        System.Random randangle = new System.Random();
        float timer = 0.0f;
        float waittime = 0.4f;
        float rotationSpeed = 45;
        Rigidbody m_Rigidbody;
        public float m_Thrust = 20f;
        [Tooltip("Health")] public Health Health;
        Vector3 currentEulerAngles;

        void Start()
        {
            //Fetch the Rigidbody from the GameObject with this script attached
            m_Rigidbody = GetComponent<Rigidbody>();
            
        }

        public float GetRandomRotation()
        {
            float angle = (float)randangle.NextDouble();
            return angle;
        }

        private void OnTiggerEvent(Collider collider)
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            currentEulerAngles += new Vector3(GetRandomRotation(), GetRandomRotation(), GetRandomRotation()) * Time.deltaTime * rotationSpeed;
        }

        void FixedUpdate()
        {
            timer += Time.deltaTime;
            if (timer > waittime)
            {
                
            }
        }
    }
}
