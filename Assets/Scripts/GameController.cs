using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public GameObject arrow;
    Transform cam;
    public Image strengthBar, pnl;
    float power = 750f;
    int reArrow = 5;
    public int score = 0;
    public TMP_Text arrowTxt, scoreTxt;
    private void Awake()
    {
        Instance = this;
    }
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
        else
        {
            pnl.gameObject.SetActive(true);
        }
        
    }
    public void UpdateScore(int scoreCount)
    {
        score += scoreCount;
        scoreTxt.text = "SCORE: " + score;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
