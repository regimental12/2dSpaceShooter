using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    Transform player;
    public float rotationSpeed = 180;
	
	// Update is called once per frame
	void Update () {
	    if(player == null)
        {
            // find player ship
            GameObject go = GameObject.Find("PlayerShip");

            if(go !=null)
            {
                player = go.transform;
            }
        }

        if(player == null)
        {
            return;
        }

        Vector3 dir = player.position - transform.position;

        dir.Normalize();

        float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotationSpeed * Time.deltaTime);

	}
}
