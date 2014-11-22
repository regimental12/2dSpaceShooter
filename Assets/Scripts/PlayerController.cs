using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed = 10f;
    public float rotspeed = 180f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;

        z -= Input.GetAxis("Horizontal") * rotspeed * Time.deltaTime;
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        Vector3 pos = transform.position;
        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        pos += rot * velocity;
        transform.position = pos;

        bounding();

	}

    void bounding()
    {
        Vector3 pos = transform.position;

        if (transform.position.x < -10)
        {
            pos.x = 10;
            //pos.y = transform.position.y;
            transform.position = pos;
        }
        else if (transform.position.x > 10)
        {
            pos.x = -10;
            //pos.y = transform.position.y;
            transform.position = pos;
        }
        if (transform.position.y < -6)
        {
            pos.y = 6;
            //pos.x = transform.position.x;
            transform.position = pos;
        }
        else if (transform.position.y >= 6)
        {
            pos.y = -6;
            //pos.x = transform.position.x;
            transform.position = pos;
        }
    }

}
