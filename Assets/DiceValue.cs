using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceValue : MonoBehaviour
{
    public int value;


    public List<DiceTriggerValue> sides;
    public float velocityEpsilon = .1f;

    private Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (rigid.velocity.sqrMagnitude < velocityEpsilon && rigid.angularVelocity.sqrMagnitude < velocityEpsilon)
		{
			foreach (DiceTriggerValue side in sides)
			{
                if (side.onGround) value = side.value;
			}
		}
    }
}
