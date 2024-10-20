using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject nextlevel;

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.position = nextlevel.transform.position;
    }
}
