using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){
        
        if(other.gameObject.GetComponent<Mover>()){
            Vector3 PlayerPos = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z);
            other.gameObject.transform.position = PlayerPos;
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
