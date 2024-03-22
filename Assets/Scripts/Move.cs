using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 2f;
    public GameObject goal;
    private Vector3 direction;
    void Start()
    {
        
        //this.transform.Translate(direction);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude > 2)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}