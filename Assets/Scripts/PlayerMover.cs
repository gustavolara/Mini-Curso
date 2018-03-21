using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour {
    [SerializeField]
    private float m_speed = 2f;

    [SerializeField]
    private float m_fireCooldownInSeconds = 0.5f;

    [SerializeField]
    private GameObject m_goProjectile;

    private GameObject m_pRef;

    private float m_Counter;


    private void Awake(){
        
    }
    private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            //tem q mexer trasform.position.x pra negativo
            this.transform.position -= new Vector3(m_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            //tem q mexer trasform.position.x pra positivo
            this.transform.position += new Vector3(m_speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.J)) {
            if( m_Counter >= m_fireCooldownInSeconds){
                m_Counter = 0;
                Shoot();
            }
        }
        m_Counter += Time.deltaTime;
    }
    private void Shoot(){
      Vector3 pos = transform.position + new Vector3(0, 1, 0);
      GameObject go = GameObject.Instantiate(m_pRef, pos, Quaternion.identity);
    }
}
