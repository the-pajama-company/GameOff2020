using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Speed;
    public float turn_Speed;
    public GameObject myPrefab;


    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(myPrefab, transform.position, transform.rotation);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Apply force to the "up" of the object, moving object forward
            m_Rigidbody.AddForce (transform.up * m_Speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //Apply negative force to the "up" of the object, moving object backwards
            m_Rigidbody.AddForce(-transform.up * m_Speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Rotate the sprite about the Y axis in the positive direction
            transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime * turn_Speed, Space.World);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Rotate the sprite about the Y axis in the negative direction
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * turn_Speed, Space.World);
        }
    }
}