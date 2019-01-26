using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFireball : MonoBehaviour {


    public Transform pointoffire;
    public GameObject Fireball;
    public float rot = 90;

    // Use this for initialization
    void Start () {
		
	}


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(Fireball, pointoffire.position, pointoffire.rotation);
    }


}
