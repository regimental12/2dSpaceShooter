using UnityEngine;
using System.Collections;

public class selfDestruct : MonoBehaviour {

    public float timer = 1f;
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Destroy(gameObject);
        }
	}
}
