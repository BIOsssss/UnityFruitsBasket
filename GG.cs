using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG : MonoBehaviour
{
    public Korzinka korzinka;
    public HeartSystem hs;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Banana") || other.CompareTag("Apple") || other.CompareTag("Orange")){
            hs.health--;
        }
        if(hs.health == 0){
            korzinka.GameOver();
        }
    }
}
