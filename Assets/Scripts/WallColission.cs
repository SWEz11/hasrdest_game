using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColission : MonoBehaviour
{

    public Transform nextlevel;

    // Start is called before the first frame update
        private void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.transform.position = nextlevel.position;
            collision.gameObject.GetComponent<Player>().startPos = nextlevel.position;
        }

        // Update is called once per frame
        void Update()
    {
        
    }
}
