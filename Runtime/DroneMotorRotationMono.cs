using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMotorRotationMono : MonoBehaviour
{

    public Transform m_whatToRotate;

    [Range(0,1)]
    public float m_percentSpeed = 0.5f;
    public float m_speedMin = 360;
    public float m_speedMax = 720;
    public bool m_inverse=false;
    public Vector3 m_rotationAxis = Vector3.up;

    private void Reset()
    {
        m_whatToRotate = transform;
    }
    void Update()
    {
        if (m_whatToRotate != null)
        {
            float speed = 0;
            
            if (m_percentSpeed > 0f) {
            
                m_percentSpeed = Mathf.Clamp01(m_percentSpeed);
                speed = Mathf.Lerp(m_speedMin, m_speedMax, m_percentSpeed);
            }
            if (m_inverse)
            {
                m_whatToRotate.Rotate(m_rotationAxis, -speed);
            }
            else
            {
                m_whatToRotate.Rotate(m_rotationAxis, speed);
            }
        }
    }
}
