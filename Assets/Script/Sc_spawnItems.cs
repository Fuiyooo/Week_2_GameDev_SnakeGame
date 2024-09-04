using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_spawnItems : MonoBehaviour
{

    [SerializeField] GameObject objItems;
    int banyak = 30;
    // Start is called before the first frame update
    void Start()
    {
        for(int a = 0; a < 30; a++){
            Vector3 pos = this.transform.position;
            pos.x = Random.Range(-10f, 10f);
            pos.z = Random.Range(-10f, 10f);
            Instantiate(objItems, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
