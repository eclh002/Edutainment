using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Followmagnet : MonoBehaviour
{

    Transform tr_Player;
    float f_RotSpeed = 3.0f, f_MoveSpeed;
    public Slider slider;
    // Use this for initialization
    void Start()
    {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;
        slider = GameObject.FindGameObjectWithTag("MagnetSlider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {

        
            f_MoveSpeed = slider.value * 15;
            f_RotSpeed = slider.value * 3;
       
        /* Look at Player*/
        
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(tr_Player.position - transform.position), f_RotSpeed * Time.deltaTime);
            /* Move at Player*/
            transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
        
        
    }
 
}