using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float b_speed;
    public float max_Velocity;
    // Start is called before the first frame update

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.AddForce(transform.up * b_speed);
    }
}
