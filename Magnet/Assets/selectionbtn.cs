using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectionbtn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Magnet()
    {
        SceneManager.LoadScene("magnet");

    }
    public void CircularMotion()
    {
        SceneManager.LoadScene("circularmotion");

    }
    public void Newton()
    {
        SceneManager.LoadScene("newton");

    }
    public void Ball() {
        SceneManager.LoadScene("ballinbasket");
    }
    public void Magnetin() {
        SceneManager.LoadScene("inst1");
    }
    public void Circlein()
    {
        SceneManager.LoadScene("inst2");

    }
    public void Newtonin()
    {
        SceneManager.LoadScene("inst3");
    }
    public void Ballin()
    {
        SceneManager.LoadScene("inst4");
    }
}
