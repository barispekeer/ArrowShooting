using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    Rigidbody rigi;
    GameController gc;
    private void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
        {
            rigi.isKinematic = true;
            GameController.Instance.UpdateScore(collision.gameObject.GetComponent<ScoreController>().score);
        }
    }
}
