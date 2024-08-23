using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace InControl
{
	// Token: 0x02000036 RID: 54
	[AddComponentMenu("Event/InControl Input Module")]
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	public class InControlInputModule : PointerInputModule
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002840 File Offset: 0x00000A40
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002843 File Offset: 0x00000A43
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public PlayerAction SubmitAction
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992A24", Offset = "0x1992A24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992A2C", Offset = "0x1992A2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00002846 File Offset: 0x00000A46
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002849 File Offset: 0x00000A49
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public PlayerAction CancelAction
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992A34", Offset = "0x1992A34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992A3C", Offset = "0x1992A3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000284C File Offset: 0x00000A4C
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000284F File Offset: 0x00000A4F
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public PlayerTwoAxisAction MoveAction
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992A44", Offset = "0x1992A44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992A4C", Offset = "0x1992A4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00002852 File Offset: 0x00000A52
		[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992A54", Offset = "0x1992A54", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "set_StateThreshold", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected InControlInputModule()
		{
			throw null;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002855 File Offset: 0x00000A55
		[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992AF0", Offset = "0x1992AF0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		public override void UpdateModule()
		{
			throw null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002858 File Offset: 0x00000A58
		[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992B20", Offset = "0x1992B20", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
		public override bool IsModuleSupported()
		{
			throw null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000285B File Offset: 0x00000A5B
		[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992B50", Offset = "0x1992B50", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "UpdateInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_VectorWasPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		public override bool ShouldActivateModule()
		{
			throw null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000285E File Offset: 0x00000A5E
		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992F90", Offset = "0x1992F90", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "ActivateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void ActivateModule()
		{
			throw null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00002861 File Offset: 0x00000A61
		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1993054", Offset = "0x1993054", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "SendUpdateEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "SendVectorEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "SendButtonEventToSelectedObject", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public override void Process()
		{
			throw null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00002864 File Offset: 0x00000A64
		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1993580", Offset = "0x1993580", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_type", ReturnType = typeof(TouchType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "RemovePointerData", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ProcessTouchEvents()
		{
			throw null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00002867 File Offset: 0x00000A67
		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19933A8", Offset = "0x19933A8", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private bool SendButtonEventToSelectedObject()
		{
			throw null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000286A File Offset: 0x00000A6A
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19931F4", Offset = "0x19931F4", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_VectorWasPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool SendVectorEventToSelectedObject()
		{
			throw null;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000286D File Offset: 0x00000A6D
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1993DFC", Offset = "0x1993DFC", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "ProcessMove", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void ProcessMove(PointerEventData pointerEvent)
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002870 File Offset: 0x00000A70
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1993EF8", Offset = "0x1993EF8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Direction", ReturnType = typeof(TwoAxisInputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "Filter", MemberParameters = new object[]
		{
			typeof(TwoAxisInputControl),
			typeof(float)
		}, ReturnType = typeof(void))]
		private void Update()
		{
			throw null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002873 File Offset: 0x00000A73
		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992C44", Offset = "0x1992C44", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "AbsoluteIsOverThreshold", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_VectorIsReleased", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_VectorIsPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_IsPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateInputState()
		{
			throw null;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00002879 File Offset: 0x00000A79
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00002876 File Offset: 0x00000A76
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public InputDevice Device
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1993F34", Offset = "0x1993F34", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "UpdateInputState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "get_SubmitButton", ReturnType = typeof(InputControl))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "get_CancelButton", ReturnType = typeof(InputControl))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x19940A0", Offset = "0x19940A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000287C File Offset: 0x00000A7C
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		private InputControl SubmitButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994068", Offset = "0x1994068", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_Device", ReturnType = typeof(InputDevice))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0000287F File Offset: 0x00000A7F
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		private InputControl CancelButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994084", Offset = "0x1994084", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_Device", ReturnType = typeof(InputDevice))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002882 File Offset: 0x00000A82
		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1993DC4", Offset = "0x1993DC4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		private void SetVectorRepeatTimer()
		{
			throw null;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00002885 File Offset: 0x00000A85
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		private bool VectorIsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994000", Offset = "0x1994000", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "UpdateInputState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "get_VectorWasPressed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00002888 File Offset: 0x00000A88
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		private bool VectorIsReleased
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1993F98", Offset = "0x1993F98", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "UpdateInputState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0000288B File Offset: 0x00000A8B
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		private bool VectorHasChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994134", Offset = "0x1994134", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0000288E File Offset: 0x00000A8E
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		private bool VectorWasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992EB8", Offset = "0x1992EB8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "SendVectorEventToSelectedObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "get_VectorIsPressed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00002891 File Offset: 0x00000A91
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		private bool SubmitWasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992E78", Offset = "0x1992E78", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00002894 File Offset: 0x00000A94
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		private bool SubmitWasReleased
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1993DA4", Offset = "0x1993DA4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00002897 File Offset: 0x00000A97
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		private bool CancelWasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992E98", Offset = "0x1992E98", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0000289A File Offset: 0x00000A9A
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		private bool MouseHasMoved
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992F4C", Offset = "0x1992F4C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000289D File Offset: 0x00000A9D
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		private bool MouseButtonIsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1992F84", Offset = "0x1992F84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000028A0 File Offset: 0x00000AA0
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19930B8", Offset = "0x19930B8", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected bool SendUpdateEventToSelectedObject()
		{
			throw null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000028A3 File Offset: 0x00000AA3
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19936B0", Offset = "0x19936B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		protected void ProcessMouseEvent()
		{
			throw null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000028A6 File Offset: 0x00000AA6
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1994158", Offset = "0x1994158", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "ProcessMouseEvent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseState), Member = "GetButtonState", MemberParameters = new object[] { typeof(PointerEventData.InputButton) }, ReturnType = typeof(PointerInputModule.ButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected void ProcessMouseEvent(int id)
		{
			throw null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000028A9 File Offset: 0x00000AA9
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19943D4", Offset = "0x19943D4", Length = "0x62C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseButtonEventData), Member = "PressedThisFrame", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseButtonEventData), Member = "ReleasedThisFrame", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data)
		{
			throw null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000028AC File Offset: 0x00000AAC
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19936B8", Offset = "0x19936B8", Length = "0x6EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "ExecuteHierarchy", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			throw null;
		}

		// Token: 0x04000282 RID: 642
		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public InControlInputModule.Button submitButton;

		// Token: 0x04000283 RID: 643
		[global::Cpp2ILInjected.Token(Token = "0x400028A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public InControlInputModule.Button cancelButton;

		// Token: 0x04000284 RID: 644
		[Range(0.1f, 0.9f)]
		[global::Cpp2ILInjected.Token(Token = "0x400028B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public float analogMoveThreshold;

		// Token: 0x04000285 RID: 645
		[global::Cpp2ILInjected.Token(Token = "0x400028C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public float moveRepeatFirstDuration;

		// Token: 0x04000286 RID: 646
		[global::Cpp2ILInjected.Token(Token = "0x400028D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public float moveRepeatDelayDuration;

		// Token: 0x04000287 RID: 647
		[FormerlySerializedAs("allowMobileDevice")]
		[global::Cpp2ILInjected.Token(Token = "0x400028E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		public bool forceModuleActive;

		// Token: 0x04000288 RID: 648
		[global::Cpp2ILInjected.Token(Token = "0x400028F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x75")]
		public bool allowMouseInput;

		// Token: 0x04000289 RID: 649
		[global::Cpp2ILInjected.Token(Token = "0x4000290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x76")]
		public bool focusOnMouseHover;

		// Token: 0x0400028A RID: 650
		[global::Cpp2ILInjected.Token(Token = "0x4000291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x77")]
		public bool allowTouchInput;

		// Token: 0x0400028B RID: 651
		[global::Cpp2ILInjected.Token(Token = "0x4000292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private InputDevice inputDevice;

		// Token: 0x0400028C RID: 652
		[global::Cpp2ILInjected.Token(Token = "0x4000293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Vector3 thisMousePosition;

		// Token: 0x0400028D RID: 653
		[global::Cpp2ILInjected.Token(Token = "0x4000294")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private Vector3 lastMousePosition;

		// Token: 0x0400028E RID: 654
		[global::Cpp2ILInjected.Token(Token = "0x4000295")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Vector2 thisVectorState;

		// Token: 0x0400028F RID: 655
		[global::Cpp2ILInjected.Token(Token = "0x4000296")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private Vector2 lastVectorState;

		// Token: 0x04000290 RID: 656
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool thisSubmitState;

		// Token: 0x04000291 RID: 657
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA9")]
		private bool lastSubmitState;

		// Token: 0x04000292 RID: 658
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAA")]
		private bool thisCancelState;

		// Token: 0x04000293 RID: 659
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAB")]
		private bool lastCancelState;

		// Token: 0x04000294 RID: 660
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private bool moveWasRepeated;

		// Token: 0x04000295 RID: 661
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private float nextMoveRepeatTime;

		// Token: 0x04000296 RID: 662
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private TwoAxisInputControl direction;

		// Token: 0x04000297 RID: 663
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private PlayerAction <SubmitAction>k__BackingField;

		// Token: 0x04000298 RID: 664
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private PlayerAction <CancelAction>k__BackingField;

		// Token: 0x04000299 RID: 665
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private PlayerTwoAxisAction <MoveAction>k__BackingField;

		// Token: 0x020001EC RID: 492
		[global::Cpp2ILInjected.Token(Token = "0x2000039")]
		public enum Button
		{
			// Token: 0x040003DA RID: 986
			[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
			Action1 = 19,
			// Token: 0x040003DB RID: 987
			[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
			Action2,
			// Token: 0x040003DC RID: 988
			[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
			Action3,
			// Token: 0x040003DD RID: 989
			[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
			Action4
		}
	}
}
