using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class PatrolEneny : MonoBehaviour
{

    public float speed;
    public List<GameObject> targets;
    GameObject currentTarget;
    int t;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = targets[t];
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.transform.position, speed);
        if(Vector3.Distance(transform.position, currentTarget.transform.position) < 0.5f)
        {
            currentTarget = targets[t++];
        }

        if(t >= targets.Count) t = 0; 
    }
}
