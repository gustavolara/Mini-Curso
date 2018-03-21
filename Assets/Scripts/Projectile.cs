using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [SerializeField]
    private float m_speed = 10;
	private void Start () {
		
	}
	
	
	private void Update () {
        transform.position += new Vector3(0, Time.deltaTime * m_speed, 0);
        if (transform.position.y > 10){
            Destroy(this.gameObject);
        }
	}
}
