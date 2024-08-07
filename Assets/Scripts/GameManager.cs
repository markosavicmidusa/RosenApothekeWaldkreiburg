using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject IndustrialFurniture;
    public GameObject OriginalFurniture;

    public bool switchPositions;

    Animator originalAnimator;
    Animator industrialAnimator;

    void Awake()
    {
        switchPositions = true;
        originalAnimator = OriginalFurniture.GetComponent<Animator>();
        industrialAnimator = IndustrialFurniture.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }

    private void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (switchPositions)
            {
                StartCoroutine(InvokeAnimations("GoDownOriginal", "GoUpIndustrial"));
                switchPositions = false;
            }
            else
            {
                StartCoroutine(InvokeAnimations("GoUPOriginal", "GoDownIndustrial"));
                switchPositions = true;
            }
        }
    }

    private IEnumerator InvokeAnimations(string originalAnimation, string industrialAnimation)
    {
        if(switchPositions){
            
            originalAnimator.Play(originalAnimation);   
            yield return new WaitForSeconds(4f);

            IndustrialFurniture.gameObject.SetActive(true);
            industrialAnimator.Play(industrialAnimation);

            OriginalFurniture.gameObject.SetActive(false);
        }else{

            industrialAnimator.Play(industrialAnimation);   
            yield return new WaitForSeconds(4f);

            OriginalFurniture.gameObject.SetActive(true);
            originalAnimator.Play(originalAnimation);

            IndustrialFurniture.gameObject.SetActive(false);
        }
        
    }
}
