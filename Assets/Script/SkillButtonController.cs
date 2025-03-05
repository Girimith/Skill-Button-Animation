using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButtonController : MonoBehaviour
{
    [SerializeField]bool isButtonOn = true;

    public Animator skillButtonAnimator;
    public Animator skillContainarAnimator;


    public void OnSkillButtonClick()
    {
        if(isButtonOn)
        {
            skillButtonAnimator.SetTrigger("Click");
            skillContainarAnimator.SetTrigger("Click");
            isButtonOn = false;
        }
        else
        {
            skillButtonAnimator.SetTrigger("ClickBack");
            skillContainarAnimator.SetTrigger("ClickBack");
            isButtonOn = true;
        }
    }
}
