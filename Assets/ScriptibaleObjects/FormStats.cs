using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "NewFormStats", menuName = "ScriptableObjects/FormStats")]
public class FormStats : ScriptableObject
{
    public Forms form;
    public GameObject mesh;    
    public AnimatorController animatorController;
    public Avatar avatar;
    public float coliderRadius;
    public float coliderHeight;
    public float walkSpeed;
    public float runSpeed;
}
