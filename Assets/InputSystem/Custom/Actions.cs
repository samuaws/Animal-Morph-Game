//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/Custom/Actions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Actions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Actions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Actions"",
    ""maps"": [
        {
            ""name"": ""Transformations"",
            ""id"": ""78e6f0dc-d617-4e3d-af83-b246fe77e84a"",
            ""actions"": [
                {
                    ""name"": ""Tiger"",
                    ""type"": ""Button"",
                    ""id"": ""9964f5b0-6735-49bb-a85f-c59546f8eaaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""01c8752e-101c-46cf-b4ea-b066ef3e422a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tiger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Transformations
        m_Transformations = asset.FindActionMap("Transformations", throwIfNotFound: true);
        m_Transformations_Tiger = m_Transformations.FindAction("Tiger", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Transformations
    private readonly InputActionMap m_Transformations;
    private List<ITransformationsActions> m_TransformationsActionsCallbackInterfaces = new List<ITransformationsActions>();
    private readonly InputAction m_Transformations_Tiger;
    public struct TransformationsActions
    {
        private @Actions m_Wrapper;
        public TransformationsActions(@Actions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Tiger => m_Wrapper.m_Transformations_Tiger;
        public InputActionMap Get() { return m_Wrapper.m_Transformations; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TransformationsActions set) { return set.Get(); }
        public void AddCallbacks(ITransformationsActions instance)
        {
            if (instance == null || m_Wrapper.m_TransformationsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TransformationsActionsCallbackInterfaces.Add(instance);
            @Tiger.started += instance.OnTiger;
            @Tiger.performed += instance.OnTiger;
            @Tiger.canceled += instance.OnTiger;
        }

        private void UnregisterCallbacks(ITransformationsActions instance)
        {
            @Tiger.started -= instance.OnTiger;
            @Tiger.performed -= instance.OnTiger;
            @Tiger.canceled -= instance.OnTiger;
        }

        public void RemoveCallbacks(ITransformationsActions instance)
        {
            if (m_Wrapper.m_TransformationsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITransformationsActions instance)
        {
            foreach (var item in m_Wrapper.m_TransformationsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TransformationsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TransformationsActions @Transformations => new TransformationsActions(this);
    public interface ITransformationsActions
    {
        void OnTiger(InputAction.CallbackContext context);
    }
}
