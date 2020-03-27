﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleSprite : MonoBehaviour
{
    //public AngleToCamera angleToCamera;

    public float angle;
    public GameObject pivot;
    private AngleToCamera angleToCamera;
    public SpriteRenderer spriteRenderer;
    public Sprite[] sprite;
    // Start is called before the first frame update
    void Start()
    {
        angleToCamera = pivot.GetComponent<AngleToCamera>();
        spriteRenderer = GetComponent<SpriteRenderer>();
         
    }

    // Update is called once per frame
    void Update()
    {
        angle = angleToCamera.angle;
        //entre 337.5 y 22.5 es el sprite 2
        //asi que sumo y resto para que de 0 a 45 sea el sprite 0
        angle += 22.5f + 45 + 45;
        angle += (angle > 360) ? -360 : 0;
        //asigno el sprite
        spriteRenderer.sprite = sprite[(int)Mathf.Floor(angle / 45)];


        //print(angle);
        //if (angle > 337.5 || angle < 22.5)
        //{
        //    spriteRenderer.sprite = sprite[2];
        //}
        //if (angle > 22.5 && angle < 67.5)
        //{
        //    spriteRenderer.sprite = sprite[3];
        //}
        //if (angle > 67.5 && angle < 112.5)
        //{
        //    spriteRenderer.sprite = sprite[4];
        //}
        //if (angle > 112.5 && angle < 157.5)
        //{
        //    spriteRenderer.sprite = sprite[5];
        //}
        //if (angle > 157.5 && angle < 202.5)
        //{
        //    spriteRenderer.sprite = sprite[6];
        //}
        //if (angle > 202.5 && angle < 247.5)
        //{
        //    spriteRenderer.sprite = sprite[7];
        //}
        //if (angle > 247.5 && angle < 297.5)
        //{
        //    spriteRenderer.sprite = sprite[0];
        //}
        //if (angle > 297.5 && angle < 337.5)
        //{
        //    spriteRenderer.sprite = sprite[1];
        //}

    }
}
