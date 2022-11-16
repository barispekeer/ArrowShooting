using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject arrow;
    Transform cam;
    public Image strengthBar;
    float power = 750f;
    int reArrow = 5;
    public TMP_Text arrowTxt, scoreTxt;
    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
    }

    
    void Update()
    {
        if (reArrow > 0)
        {  
            if (Input.GetMouseButtonDown(0))
            {
                GameObject newArrow = Instantiate(arrow, cam.position, cam.rotation);
                power *= strengthBar.fillAmount;
                newArrow.GetComponent<Rigidbody>().AddForce(newArrow.transform.forward * power);
                reArrow--;
                arrowTxt.text = "ARROW: " + reArrow;
            }
        }
        
    }
    public void IncScore()
    {

    }
}
