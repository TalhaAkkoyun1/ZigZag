using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        offset = transform.position - player.transform.position;
       
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
