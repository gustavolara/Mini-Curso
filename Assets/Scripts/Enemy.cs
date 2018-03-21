using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private void OnTriggerEnter(Collider p_other){
       if (p_other.tag == "Enemy"){
            Destroy(p_other.gameObject);
            Destroy(this.gameObject);
        } 
    }
}
