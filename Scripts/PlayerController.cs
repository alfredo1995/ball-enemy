using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody playerRb;

    private GameObject pontoFocal;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        pontoFocal = GameObject.Find("Ponto Focal");
    }
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(pontoFocal.transform.forward * forwardInput * speed);
    }
}
