// GENERATED AUTOMATICALLY FROM 'Assets/Input Action/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""BlueController"",
            ""id"": ""9f7cae0c-0891-45ef-8e19-4f2dc52749f2"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""fc35ffb6-4ce9-4141-94e2-dba77e7431e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e29d5f1f-aa62-43eb-96f2-68f643f7046c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""df055ea2-48a3-49c5-bb12-436695fe87bd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""95589b3e-2c87-4e2b-b54e-be25f574fc15"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7806bb69-539e-4afd-b932-38b2f5e6c878"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""636b4b44-8435-4d52-8bc9-be68e681642b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LS"",
                    ""id"": ""3b04676c-6db7-470a-93f4-1f571e4c2b33"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8379d86b-ab87-44ea-96fb-93d3f4c2ac7b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f29052d8-39a0-4566-94ba-0b0633b31e64"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0d28d200-94df-49ee-baa0-72875748b8cb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""45394d73-3894-4b6c-ab08-cfe0145ef346"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LDPad"",
                    ""id"": ""271dedb5-ef1b-4af9-a494-c6193ad09338"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""323c79cc-09ac-40fe-a27b-aa022402737f"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4159040-7d78-4a7a-bf37-af03223b00d9"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""84c05292-5073-4ecb-a31c-badecdeca625"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""de5bbce8-f108-44e6-ad9b-a534c1778be6"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PinkController"",
            ""id"": ""7315b586-a62c-4576-b16e-bf2010e1ae8d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8baa1e8e-1cc5-46f5-be72-cbe19e85769b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""c9f15022-2db6-4fe9-89be-1465b0016078"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6efa2486-e6dc-4412-a00d-45f305f07d0b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2ce8fbec-5872-4089-bd20-1a3f44ae2c06"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b952cebd-709e-4cee-a835-2c371bee3063"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""961147c7-bf6a-42e2-9470-e5a20ceeb787"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RS"",
                    ""id"": ""bb79061b-bc3c-4587-a863-85ac71fa3d98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""541a2cdd-55bb-4e9f-bd80-91216a000d4a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""568eecc1-834d-4328-b073-9d1b9acf1912"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50ec6a13-e449-4362-a1fc-0fc4c3ecd0d6"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ae7e2b0f-678f-4117-89ff-d5f12e2ac016"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Extra Inputs"",
            ""id"": ""07560bd4-f72e-4c43-8a8a-5481e5563a53"",
            ""actions"": [
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""8882f4d8-e8b7-41dc-8ba0-bb1f83f48cfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""555c9cb0-3553-4403-9f64-6191873fbec8"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0492e2a2-760b-41d0-a59d-db413510ad1a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BlueController
        m_BlueController = asset.FindActionMap("BlueController", throwIfNotFound: true);
        m_BlueController_Move = m_BlueController.FindAction("Move", throwIfNotFound: true);
        // PinkController
        m_PinkController = asset.FindActionMap("PinkController", throwIfNotFound: true);
        m_PinkController_Move = m_PinkController.FindAction("Move", throwIfNotFound: true);
        // Extra Inputs
        m_ExtraInputs = asset.FindActionMap("Extra Inputs", throwIfNotFound: true);
        m_ExtraInputs_Restart = m_ExtraInputs.FindAction("Restart", throwIfNotFound: true);
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

    // BlueController
    private readonly InputActionMap m_BlueController;
    private IBlueControllerActions m_BlueControllerActionsCallbackInterface;
    private readonly InputAction m_BlueController_Move;
    public struct BlueControllerActions
    {
        private @InputActions m_Wrapper;
        public BlueControllerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BlueController_Move;
        public InputActionMap Get() { return m_Wrapper.m_BlueController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BlueControllerActions set) { return set.Get(); }
        public void SetCallbacks(IBlueControllerActions instance)
        {
            if (m_Wrapper.m_BlueControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BlueControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BlueControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BlueControllerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_BlueControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public BlueControllerActions @BlueController => new BlueControllerActions(this);

    // PinkController
    private readonly InputActionMap m_PinkController;
    private IPinkControllerActions m_PinkControllerActionsCallbackInterface;
    private readonly InputAction m_PinkController_Move;
    public struct PinkControllerActions
    {
        private @InputActions m_Wrapper;
        public PinkControllerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PinkController_Move;
        public InputActionMap Get() { return m_Wrapper.m_PinkController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PinkControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPinkControllerActions instance)
        {
            if (m_Wrapper.m_PinkControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PinkControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PinkControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PinkControllerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PinkControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PinkControllerActions @PinkController => new PinkControllerActions(this);

    // Extra Inputs
    private readonly InputActionMap m_ExtraInputs;
    private IExtraInputsActions m_ExtraInputsActionsCallbackInterface;
    private readonly InputAction m_ExtraInputs_Restart;
    public struct ExtraInputsActions
    {
        private @InputActions m_Wrapper;
        public ExtraInputsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Restart => m_Wrapper.m_ExtraInputs_Restart;
        public InputActionMap Get() { return m_Wrapper.m_ExtraInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ExtraInputsActions set) { return set.Get(); }
        public void SetCallbacks(IExtraInputsActions instance)
        {
            if (m_Wrapper.m_ExtraInputsActionsCallbackInterface != null)
            {
                @Restart.started -= m_Wrapper.m_ExtraInputsActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_ExtraInputsActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_ExtraInputsActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_ExtraInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public ExtraInputsActions @ExtraInputs => new ExtraInputsActions(this);
    public interface IBlueControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPinkControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IExtraInputsActions
    {
        void OnRestart(InputAction.CallbackContext context);
    }
}
