using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_1 : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    void Start()
    {
        rb = this.gameObject.AddComponent<Rigidbody>();
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * 10f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col){
        Debug.Log("Box Collide dengan " + col.gameObject.name);
    }
}
