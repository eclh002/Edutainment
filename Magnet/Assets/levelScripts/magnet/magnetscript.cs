﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magnetscript : MonoBehaviour
{
    public Canvas can;
    [SerializeField]
    GameObject start;
    [SerializeField]
    GameObject nail;
    GameObject obj;

    void Start() {

        line1();

    }

    void line1() {

        Debug.Log("line");
        obj = Instantiate(nail,start.transform);
        obj.GetComponent<Followmagnet>().setThres(0.5f);
    }
    public void line2() {
        Debug.Log("line2");
        Destroy(obj);
        obj = Instantiate(nail, start.transform);
        obj.GetComponent<Followmagnet>().setThres(0.8f);
    }
    public void end() {

    }
}
