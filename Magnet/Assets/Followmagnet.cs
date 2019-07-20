using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Followmagnet : MonoBehaviour
{

    Transform tr_Player;
    float f_RotSpeed = 3.0f, f_MoveSpeed;
    public Slider slider;
    [SerializeField]
    float threshold;
    // Use this for initialization
    void Start()
    {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
        slider = GameObject.FindGameObjectWithTag("MagnetSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (slider.value > threshold)
        {
            f_MoveSpeed = slider.value * 10;
            f_RotSpeed = slider.value * 3;
        }
        else
        {
            f_MoveSpeed = 0;
            f_RotSpeed = 0;
        }
        /* Look at Player*/
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tr_Player.position - transform.position), f_RotSpeed * Time.deltaTime);
        /* Move at Player*/
        transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
    }
    public void setThres(float thres) {
        threshold = thres;
    }
}