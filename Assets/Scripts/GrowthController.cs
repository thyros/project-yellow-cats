﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GrowthController : MonoBehaviour
{
    private Rigidbody2D mRigidbody;
    [SerializeField] float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
       mRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Grow"))
        {
            mRigidbody.velocity = transform.up * speed;
            //Leave checkpoints as you grow?
        }
        else if(Input.GetButton("Retract"))
        {
            //retract, not just move backwards
            //maybe just turn back time - how?
        }
        else if(mRigidbody.velocity != Vector2.zero)
        {
            mRigidbody.velocity = mRigidbody.velocity * transform.up;
        }
    }
}
