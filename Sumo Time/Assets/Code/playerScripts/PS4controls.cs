// GENERATED AUTOMATICALLY FROM 'Assets/Input&Controls/PS4controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PS4controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PS4controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PS4controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""02e94b47-b535-4333-bd43-8edc922852d9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f863d6ca-24dc-40f6-b69c-4a57eb9e5ae1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""3bd98787-6e7c-460f-ac2a-c6db76e16892"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""31b1ab52-c1fb-44ee-a740-29f193e15060"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21d8bd76-4290-4c0f-89eb-0ca35b80d648"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a24b87-4337-4adc-9d79-111dce5a07fd"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1742c6af-e565-457c-88a8-f7a8962053da"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PS4"",
            ""bindingGroup"": ""PS4"",
            ""devices"": []
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Camera = m_Movement.FindAction("Camera", throwIfNotFound: true);
        m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Camera;
    private readonly InputAction m_Movement_Jump;
    public struct MovementActions
    {
        private @PS4controls m_Wrapper;
        public MovementActions(@PS4controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Camera => m_Wrapper.m_Movement_Camera;
        public InputAction @Jump => m_Wrapper.m_Movement_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Camera.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCamera;
                @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    private int m_PS4SchemeIndex = -1;
    public InputControlScheme PS4Scheme
    {
        get
        {
            if (m_PS4SchemeIndex == -1) m_PS4SchemeIndex = asset.FindControlSchemeIndex("PS4");
            return asset.controlSchemes[m_PS4SchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
