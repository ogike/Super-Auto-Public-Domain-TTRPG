using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceTriggerValue : MonoBehaviour
{
    public int value;
    public bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        onGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider other)
	{
        onGround = true;
    }

	private void OnTriggerExit(Collider other)
	{
        onGround = false;
	}
}
