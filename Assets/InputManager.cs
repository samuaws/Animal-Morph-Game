using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Actions actions;
    private CharacterFormSwitcher characterFormSwitcher;
    public FormStats horseSO;

    private void Awake()
    {
        characterFormSwitcher = GetComponent<CharacterFormSwitcher>();
        actions = new Actions();
        actions.Enable();
        actions.Transformations.Horse.performed += _ => characterFormSwitcher.SwitchForms(horseSO);

    }
}
