//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/SoccerGame/MainInputControles.inputactions
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

public partial class @MainInputControles : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainInputControles()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainInputControles"",
    ""maps"": [
        {
            ""name"": ""InGame"",
            ""id"": ""6713f1ec-8f4f-49cb-bff4-0c0b0170bd1e"",
            ""actions"": [
                {
                    ""name"": ""LeftPlayer"",
                    ""type"": ""Value"",
                    ""id"": ""33cab1d2-ada1-4c3f-b74b-e78ae6741b55"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightPlayer"",
                    ""type"": ""Value"",
                    ""id"": ""296c148c-251b-42ed-8ea3-939f504bb4be"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector Controller"",
                    ""id"": ""42d3679c-6262-4041-8dbe-67faa704cb4e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1e4bc4b9-4783-4c57-af65-66669e826cd5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c820b1e7-a692-48a3-89a4-04b5f13b6787"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ae9e606-fb97-4b8e-9183-b2182223936f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba936903-e304-4eff-b85c-2b739a75c897"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector Keyboard"",
                    ""id"": ""08ccb9d7-6dda-49d1-8e16-ab020f4c870a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3f78a36f-4e2d-4bb0-8197-d6e560a240cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1a27f507-c733-4948-92ca-d3bb8ad930c2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a523dbd-9111-4ab1-aa36-4e291df71610"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""74f64c7d-3757-4ad1-b8be-72689dcac34e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 1"",
                    ""action"": ""LeftPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector Controller"",
                    ""id"": ""1dde44fa-24e6-4ebb-9aa3-19aa1b10e798"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7afacfa7-15c1-4449-9ce6-f22a27dab6fc"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e03d84b7-7ffc-4ef2-b414-7b09af08b1d3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5d485e71-77d1-4d11-8603-08ed1a7685a5"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3918598b-5092-4f09-891d-0d9556d586d3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector Keyboard"",
                    ""id"": ""c6cf0574-6049-4fb7-bf72-465d61bfb756"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5b88ab70-a5f8-41e8-a358-1fafbfb026a0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""43d664b3-afe9-4d4b-91cb-9b33149b8a4d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4a849a4d-c6a1-4a1b-b161-8e272fc6057a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9ee6515d-7d10-4447-9c77-15030f2f6402"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller 2"",
                    ""action"": ""RightPlayer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller 1"",
            ""bindingGroup"": ""Controller 1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller 2"",
            ""bindingGroup"": ""Controller 2"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_LeftPlayer = m_InGame.FindAction("LeftPlayer", throwIfNotFound: true);
        m_InGame_RightPlayer = m_InGame.FindAction("RightPlayer", throwIfNotFound: true);
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

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_LeftPlayer;
    private readonly InputAction m_InGame_RightPlayer;
    public struct InGameActions
    {
        private @MainInputControles m_Wrapper;
        public InGameActions(@MainInputControles wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftPlayer => m_Wrapper.m_InGame_LeftPlayer;
        public InputAction @RightPlayer => m_Wrapper.m_InGame_RightPlayer;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @LeftPlayer.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnLeftPlayer;
                @LeftPlayer.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnLeftPlayer;
                @LeftPlayer.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnLeftPlayer;
                @RightPlayer.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnRightPlayer;
                @RightPlayer.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnRightPlayer;
                @RightPlayer.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnRightPlayer;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftPlayer.started += instance.OnLeftPlayer;
                @LeftPlayer.performed += instance.OnLeftPlayer;
                @LeftPlayer.canceled += instance.OnLeftPlayer;
                @RightPlayer.started += instance.OnRightPlayer;
                @RightPlayer.performed += instance.OnRightPlayer;
                @RightPlayer.canceled += instance.OnRightPlayer;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    private int m_Controller1SchemeIndex = -1;
    public InputControlScheme Controller1Scheme
    {
        get
        {
            if (m_Controller1SchemeIndex == -1) m_Controller1SchemeIndex = asset.FindControlSchemeIndex("Controller 1");
            return asset.controlSchemes[m_Controller1SchemeIndex];
        }
    }
    private int m_Controller2SchemeIndex = -1;
    public InputControlScheme Controller2Scheme
    {
        get
        {
            if (m_Controller2SchemeIndex == -1) m_Controller2SchemeIndex = asset.FindControlSchemeIndex("Controller 2");
            return asset.controlSchemes[m_Controller2SchemeIndex];
        }
    }
    public interface IInGameActions
    {
        void OnLeftPlayer(InputAction.CallbackContext context);
        void OnRightPlayer(InputAction.CallbackContext context);
    }
}
