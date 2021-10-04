using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    float xValue;
    float zValue;
    float yValue = 0;

    [SerializeField] [Range(0,10)] float currentSpeed = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        xValue = Input.GetAxis("Horizontal");
        zValue = Input.GetAxis("Vertical");
        var vector = new Vector3(xValue, yValue, zValue);
        transform.Translate(vector * currentSpeed * Time.deltaTime);
    }
}
