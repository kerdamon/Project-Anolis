// GENERATED AUTOMATICALLY FROM 'Assets/Actions/GameplayControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameplayControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameplayControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameplayControls"",
    ""maps"": [
        {
            ""name"": ""PlanetaryMode"",
            ""id"": ""815d0310-239f-4bb2-837a-b01562e0aaf2"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""ab77acef-0e06-4ac9-8a44-6cbc56483d0e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""20fadbc5-f268-434a-94f9-5006fcc2e195"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChooseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""d52f9fda-3abd-444d-b0e3-6e3acf207825"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""5d8ed5f2-b081-4e99-affa-e4ce3804e419"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99ddc06f-c563-4b2c-a0d0-fcb90954e2fc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""76bb0edc-c15a-49d0-9dc3-211695f83b57"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""60e6aa59-8e98-4950-9eda-b6d16befc386"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2f54bde2-d823-4ddc-a07e-2b0832f06811"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""89c427a1-48a4-42ed-89db-c447395fa406"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b5c054bb-3746-40d4-ace6-95845b010b03"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2b8e405a-c2f1-4066-9908-ac68b5a15375"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73fdceb3-9539-4204-b516-b1dcf4e457bf"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""35ab43f4-30c7-4392-ba6d-2f83050476ce"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""add41f27-11fe-4d2a-ade1-ed7c0117bacf"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1d860da-d6f1-4951-937b-c05a47bc6a12"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InterplanetaryMode"",
            ""id"": ""40213b6b-8349-40d9-8f5c-6e88e1340d97"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""af1fe188-4007-4a2f-b2f4-b31bdbb27dd1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""04fc4c6a-4d9f-4223-8162-7a41cf80b977"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FocusPlanet"",
                    ""type"": ""Button"",
                    ""id"": ""ebd25abd-667f-49e8-ac57-e7e0a907d853"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""MultiTap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ce91063c-fcdf-40a5-bfc9-ee360cb874f5"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""d9071b39-2038-48ed-b533-0853206700f8"",
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
                    ""id"": ""e74297cd-1c49-456c-845d-6b7d74db0a7a"",
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
                    ""id"": ""cd914ea7-0387-4b48-b769-4f76674c1d1a"",
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
                    ""id"": ""96cf24c9-f361-4e5c-8f5c-3c5f2d44bf5e"",
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
                    ""id"": ""07c2a447-3201-4d66-bbc1-41b4db457db9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4a60a0d8-50d1-43cf-b73e-20202b1c0342"",
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
                    ""id"": ""89111756-d225-4c0e-8d00-c0c52d5f6b90"",
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
                    ""id"": ""78a3dbd2-cb92-4a0f-9af3-f77dfa3907dc"",
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
                    ""id"": ""2b1462b7-60d2-4737-9e46-61a179f1bb06"",
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
                    ""id"": ""360c4b0a-3ca8-4934-a188-04aacb82b2dd"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""87666a1e-937e-4c82-add0-7bee210fff6d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FocusPlanet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Utilities"",
            ""id"": ""39b072f5-4e42-4c60-934d-b7f38d01a9a8"",
            ""actions"": [
                {
                    ""name"": ""CastRay"",
                    ""type"": ""Value"",
                    ""id"": ""ec3ec968-0559-4686-919b-b2012e0c9482"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""943b4955-fd81-4cc9-b258-822aab22560b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CastRay"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlanetaryMode
        m_PlanetaryMode = asset.FindActionMap("PlanetaryMode", throwIfNotFound: true);
        m_PlanetaryMode_Rotate = m_PlanetaryMode.FindAction("Rotate", throwIfNotFound: true);
        m_PlanetaryMode_Zoom = m_PlanetaryMode.FindAction("Zoom", throwIfNotFound: true);
        m_PlanetaryMode_ChooseMenu = m_PlanetaryMode.FindAction("ChooseMenu", throwIfNotFound: true);
        // InterplanetaryMode
        m_InterplanetaryMode = asset.FindActionMap("InterplanetaryMode", throwIfNotFound: true);
        m_InterplanetaryMode_Move = m_InterplanetaryMode.FindAction("Move", throwIfNotFound: true);
        m_InterplanetaryMode_Zoom = m_InterplanetaryMode.FindAction("Zoom", throwIfNotFound: true);
        m_InterplanetaryMode_FocusPlanet = m_InterplanetaryMode.FindAction("FocusPlanet", throwIfNotFound: true);
        // Utilities
        m_Utilities = asset.FindActionMap("Utilities", throwIfNotFound: true);
        m_Utilities_CastRay = m_Utilities.FindAction("CastRay", throwIfNotFound: true);
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

    // PlanetaryMode
    private readonly InputActionMap m_PlanetaryMode;
    private IPlanetaryModeActions m_PlanetaryModeActionsCallbackInterface;
    private readonly InputAction m_PlanetaryMode_Rotate;
    private readonly InputAction m_PlanetaryMode_Zoom;
    private readonly InputAction m_PlanetaryMode_ChooseMenu;
    public struct PlanetaryModeActions
    {
        private @GameplayControls m_Wrapper;
        public PlanetaryModeActions(@GameplayControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_PlanetaryMode_Rotate;
        public InputAction @Zoom => m_Wrapper.m_PlanetaryMode_Zoom;
        public InputAction @ChooseMenu => m_Wrapper.m_PlanetaryMode_ChooseMenu;
        public InputActionMap Get() { return m_Wrapper.m_PlanetaryMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlanetaryModeActions set) { return set.Get(); }
        public void SetCallbacks(IPlanetaryModeActions instance)
        {
            if (m_Wrapper.m_PlanetaryModeActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnRotate;
                @Zoom.started -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnZoom;
                @ChooseMenu.started -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnChooseMenu;
                @ChooseMenu.performed -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnChooseMenu;
                @ChooseMenu.canceled -= m_Wrapper.m_PlanetaryModeActionsCallbackInterface.OnChooseMenu;
            }
            m_Wrapper.m_PlanetaryModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @ChooseMenu.started += instance.OnChooseMenu;
                @ChooseMenu.performed += instance.OnChooseMenu;
                @ChooseMenu.canceled += instance.OnChooseMenu;
            }
        }
    }
    public PlanetaryModeActions @PlanetaryMode => new PlanetaryModeActions(this);

    // InterplanetaryMode
    private readonly InputActionMap m_InterplanetaryMode;
    private IInterplanetaryModeActions m_InterplanetaryModeActionsCallbackInterface;
    private readonly InputAction m_InterplanetaryMode_Move;
    private readonly InputAction m_InterplanetaryMode_Zoom;
    private readonly InputAction m_InterplanetaryMode_FocusPlanet;
    public struct InterplanetaryModeActions
    {
        private @GameplayControls m_Wrapper;
        public InterplanetaryModeActions(@GameplayControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_InterplanetaryMode_Move;
        public InputAction @Zoom => m_Wrapper.m_InterplanetaryMode_Zoom;
        public InputAction @FocusPlanet => m_Wrapper.m_InterplanetaryMode_FocusPlanet;
        public InputActionMap Get() { return m_Wrapper.m_InterplanetaryMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InterplanetaryModeActions set) { return set.Get(); }
        public void SetCallbacks(IInterplanetaryModeActions instance)
        {
            if (m_Wrapper.m_InterplanetaryModeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnMove;
                @Zoom.started -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnZoom;
                @FocusPlanet.started -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnFocusPlanet;
                @FocusPlanet.performed -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnFocusPlanet;
                @FocusPlanet.canceled -= m_Wrapper.m_InterplanetaryModeActionsCallbackInterface.OnFocusPlanet;
            }
            m_Wrapper.m_InterplanetaryModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @FocusPlanet.started += instance.OnFocusPlanet;
                @FocusPlanet.performed += instance.OnFocusPlanet;
                @FocusPlanet.canceled += instance.OnFocusPlanet;
            }
        }
    }
    public InterplanetaryModeActions @InterplanetaryMode => new InterplanetaryModeActions(this);

    // Utilities
    private readonly InputActionMap m_Utilities;
    private IUtilitiesActions m_UtilitiesActionsCallbackInterface;
    private readonly InputAction m_Utilities_CastRay;
    public struct UtilitiesActions
    {
        private @GameplayControls m_Wrapper;
        public UtilitiesActions(@GameplayControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CastRay => m_Wrapper.m_Utilities_CastRay;
        public InputActionMap Get() { return m_Wrapper.m_Utilities; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UtilitiesActions set) { return set.Get(); }
        public void SetCallbacks(IUtilitiesActions instance)
        {
            if (m_Wrapper.m_UtilitiesActionsCallbackInterface != null)
            {
                @CastRay.started -= m_Wrapper.m_UtilitiesActionsCallbackInterface.OnCastRay;
                @CastRay.performed -= m_Wrapper.m_UtilitiesActionsCallbackInterface.OnCastRay;
                @CastRay.canceled -= m_Wrapper.m_UtilitiesActionsCallbackInterface.OnCastRay;
            }
            m_Wrapper.m_UtilitiesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CastRay.started += instance.OnCastRay;
                @CastRay.performed += instance.OnCastRay;
                @CastRay.canceled += instance.OnCastRay;
            }
        }
    }
    public UtilitiesActions @Utilities => new UtilitiesActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlanetaryModeActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnChooseMenu(InputAction.CallbackContext context);
    }
    public interface IInterplanetaryModeActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnFocusPlanet(InputAction.CallbackContext context);
    }
    public interface IUtilitiesActions
    {
        void OnCastRay(InputAction.CallbackContext context);
    }
}
