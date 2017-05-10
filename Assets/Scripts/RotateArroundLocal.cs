using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArroundLocal : MonoBehaviour {

    public float speed = 20f;
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,speed * Time.deltaTime,0);
	}

    public void OpenURL(string direccion)
    {
        if (direccion != null)
        {
            Application.OpenURL(direccion);
        }
        else
        {
            Application.OpenURL("http://www.sym.com.co/");
        }
    }

}
