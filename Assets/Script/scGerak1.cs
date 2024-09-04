using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scGerak1 : MonoBehaviour
{
    [SerializeField] Transform Tujuan1;
    [SerializeField] Transform Tujuan2;
    float kecepatan = 3f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = Tujuan1.position;

        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //gerakan1();
        //gerakan2();
        //gerakan3();
        //gerakan4();
        gerakan5();
    }

    /*
    void gerakan1(){
        /*if(Vector3.Distance(this.transform.position, Tujuan1.position) > 0.1f){
            Vector3 pos = (Tujuan1.position - this.transform.position).normalized;
            this.transform.position += pos * kecepatan * Time.deltaTime;
        }

    }
    */

    /*
    void gerakan2(){
        this.transform.position = Vector3.Lerp(this.transform.position, Tujuan1.transform.position, 1f * Time.deltaTime);
    }
    */

    /*
    void gerakan3(){
        this.transform.position = Vector3.MoveTowards(this.transform.position, Tujuan1.transform.position, 1f * Time.deltaTime);
    }
    */

    /*
    void gerakan4(){
        Vector3 jarak = Tujuan1.transform.position - this.transform.position;
        jarak = jarak.normalized * kecepatan;
        rb.AddForce(jarak);
    }
    */

    void gerakan5(){
        this.transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        this.transform.Rotate(Vector3.up * 1f);
    }
}
