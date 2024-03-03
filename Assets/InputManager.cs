using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Actions actions;
    private CharacterFormSwitcher characterFormSwitcher;

    private void Awake()
    {
        characterFormSwitcher = GetComponent<CharacterFormSwitcher>();
        actions = new Actions();
        actions.Enable();
        actions.Transformations.Tiger.performed += _ => characterFormSwitcher.SwitchForms();

    }
}
