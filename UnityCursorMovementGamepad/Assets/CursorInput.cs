//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/CursorInput.inputactions
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

public partial class @CursorInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CursorInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CursorInput"",
    ""maps"": [
        {
            ""name"": ""GamepadStick"",
            ""id"": ""368f49ea-51a3-4f78-9399-d812c3d7001e"",
            ""actions"": [
                {
                    ""name"": ""LeftControllerStick"",
                    ""type"": ""Value"",
                    ""id"": ""19c35e28-f19f-4bfc-89ae-f25c1fb542f4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4bf1cd5e-524e-46fa-a6a9-25fadecbcafb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerStick"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c21d1ab-9304-4f4d-a090-a807bc5e64a1"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7baf5501-dd4e-4ca6-81b3-a64e2689f59a"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""75acb1ef-77ed-4d07-9b2b-ff5e4a10f315"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f4a5831d-4396-4fb5-9ab0-e659fef69a41"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamepadStick
        m_GamepadStick = asset.FindActionMap("GamepadStick", throwIfNotFound: true);
        m_GamepadStick_LeftControllerStick = m_GamepadStick.FindAction("LeftControllerStick", throwIfNotFound: true);
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

    // GamepadStick
    private readonly InputActionMap m_GamepadStick;
    private List<IGamepadStickActions> m_GamepadStickActionsCallbackInterfaces = new List<IGamepadStickActions>();
    private readonly InputAction m_GamepadStick_LeftControllerStick;
    public struct GamepadStickActions
    {
        private @CursorInput m_Wrapper;
        public GamepadStickActions(@CursorInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftControllerStick => m_Wrapper.m_GamepadStick_LeftControllerStick;
        public InputActionMap Get() { return m_Wrapper.m_GamepadStick; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadStickActions set) { return set.Get(); }
        public void AddCallbacks(IGamepadStickActions instance)
        {
            if (instance == null || m_Wrapper.m_GamepadStickActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamepadStickActionsCallbackInterfaces.Add(instance);
            @LeftControllerStick.started += instance.OnLeftControllerStick;
            @LeftControllerStick.performed += instance.OnLeftControllerStick;
            @LeftControllerStick.canceled += instance.OnLeftControllerStick;
        }

        private void UnregisterCallbacks(IGamepadStickActions instance)
        {
            @LeftControllerStick.started -= instance.OnLeftControllerStick;
            @LeftControllerStick.performed -= instance.OnLeftControllerStick;
            @LeftControllerStick.canceled -= instance.OnLeftControllerStick;
        }

        public void RemoveCallbacks(IGamepadStickActions instance)
        {
            if (m_Wrapper.m_GamepadStickActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamepadStickActions instance)
        {
            foreach (var item in m_Wrapper.m_GamepadStickActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamepadStickActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamepadStickActions @GamepadStick => new GamepadStickActions(this);
    public interface IGamepadStickActions
    {
        void OnLeftControllerStick(InputAction.CallbackContext context);
    }
}