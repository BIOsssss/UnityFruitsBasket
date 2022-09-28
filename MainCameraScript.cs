using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    public KeyCode pauseKey;
    public PauseScreen ps;
    private int getPause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(pauseKey)){
            getPause++;
            if(getPause % 2 == 0){
                ps.ContinueButton();
            }
            else{
               ps.Setup(); 
            }
        }
    }
}
