﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAimer2D : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] bool aimAtMouse = true;
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Vector2.zero;
        if(aimAtMouse)
        {
            direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        }
        else
        {
            direction = target.transform.position - transform.position;
        }
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }
}
