using UnityEngine;
using System.Collections;

public class touchButtonManager : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
    {
        //if we have touches
        if(Input.touches.Length >= 0)
        {
            for (int i = 0; i < Input.touches.Length; i++)
            {
                if(this.guiTexture.HitTest(Input.GetTouch(i).position))
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        Debug.Log("Touch me, touch me");
                    }
                }
            }
        }
        else 
        {
            //we have no touches
            return;
        }
	}
}
