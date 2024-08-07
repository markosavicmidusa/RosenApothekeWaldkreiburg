using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingController : MonoBehaviour
{
    [SerializeField] GameObject CylinderLightsGroup;
    [SerializeField] GameObject CircleLightsGroup;
    
    int lightsPosition = 0; 
    // 0 - off 
    // 1 -point light ON  
    // 2- cieling light ON
    // 3 - pointLight off
    // 0- cieling light off, all are off

    // Update is called once per frame
    void Update()
    {
        ToggleLights();
    }
    void ToggleLights(){
        if(Input.GetKeyDown(KeyCode.Space)){

            if(lightsPosition == 0){
                CylinderLightsGroup.SetActive(true);
                lightsPosition = 1;
            }else if(lightsPosition == 1){
                CircleLightsGroup.SetActive(true);
                lightsPosition = 2;
            }else if(lightsPosition == 2){
                CylinderLightsGroup.SetActive(false);
                lightsPosition = 3;
            }else{
                CircleLightsGroup.SetActive(false);
                lightsPosition = 0;
            }
        }
    }
}
