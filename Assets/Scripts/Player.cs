using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        dir.Normalize();
        transform.position += dir * speed;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Portal")
        {
            transform.position = new Vector3(0, 0, 45);
        }

        if (other.gameObject.name == "Enemy")
        {
            transform.position = startPos;
        }
    }
}
