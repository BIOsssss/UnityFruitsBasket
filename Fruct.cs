using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruct : MonoBehaviour
{
    private float z = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RotateObj());
    }

    IEnumerator RotateObj(){
        yield return new WaitForSeconds(0.05f);
        transform.rotation = Quaternion.Euler(0,0,z);
        z+=5;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Destr") || collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        
    }
}
