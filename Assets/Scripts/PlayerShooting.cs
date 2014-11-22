using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public float coolDown = 0f;
    public float fireDelay = 0.50f;
    public GameObject bulletPrefab;
    public Vector3 bulletOffset = new Vector3(0, 0.75f, 0);
	
	// Update is called once per frame
	void Update () 
    {
        coolDown -= Time.deltaTime;
        if (Input.GetButton("Fire1") && coolDown <= 0)
        {
            //Shoot
            Debug.Log("pew!");
            coolDown = fireDelay;

            Vector3 offSet = transform.rotation * bulletOffset;

            Instantiate(bulletPrefab , transform.position + offSet , transform.rotation);
        }
        if(coolDown <= 0)
        {
            coolDown = 0;
        }
	}
}
