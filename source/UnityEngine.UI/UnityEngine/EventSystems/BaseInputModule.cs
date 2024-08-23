using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000067 RID: 103
	[RequireComponent(typeof(EventSystem))]
	[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
	public abstract class BaseInputModule : UIBehaviour
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00003112 File Offset: 0x00001312
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00003115 File Offset: 0x00001315
		[global::Cpp2ILInjected.Token(Token = "0x170001B4")]
		internal bool sendPointerHoverToParent
		{
			[global::Cpp2ILInjected.Token(Token = "0x600065D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE80BC", Offset = "0x1FE80BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600065E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE80C4", Offset = "0x1FE80C4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00003118 File Offset: 0x00001318
		[global::Cpp2ILInjected.Token(Token = "0x170001B5")]
		public BaseInput input
		{
			[global::Cpp2ILInjected.Token(Token = "0x600065F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE80D0", Offset = "0x1FE80D0", Length = "0x1F8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "get_input", ReturnType = typeof(BaseInput))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "StateForMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerEventData.FramePressState))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = "UnityEngine.EventSystems.PointerInputModule.MouseState")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "UpdateModule", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ActivateModule", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "Process", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "SendSubmitEventToSelectedObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "GetRawMoveVector", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "UpdateModule", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "IsModuleSupported", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "UseFakeInput", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "Process", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "FakeTouches", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 38)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0000311B File Offset: 0x0000131B
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0000311E File Offset: 0x0000131E
		[global::Cpp2ILInjected.Token(Token = "0x170001B6")]
		public BaseInput inputOverride
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000660")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE82C8", Offset = "0x1FE82C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000661")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE82D0", Offset = "0x1FE82D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00003121 File Offset: 0x00001321
		[global::Cpp2ILInjected.Token(Token = "0x170001B7")]
		protected EventSystem eventSystem
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000662")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE82D8", Offset = "0x1FE82D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00003124 File Offset: 0x00001324
		[global::Cpp2ILInjected.Token(Token = "0x6000663")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE82E0", Offset = "0x1FE82E0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "UpdateModules", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00003127 File Offset: 0x00001327
		[global::Cpp2ILInjected.Token(Token = "0x6000664")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8330", Offset = "0x1FE8330", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "UpdateModules", ReturnType = typeof(void))]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x060005D6 RID: 1494
		[global::Cpp2ILInjected.Token(Token = "0x6000665")]
		public abstract void Process();

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000312A File Offset: 0x0000132A
		[global::Cpp2ILInjected.Token(Token = "0x6000666")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8338", Offset = "0x1FE8338", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = "UnityEngine.EventSystems.PointerInputModule.MouseState")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RaycastResult>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
		{
			throw null;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000312D File Offset: 0x0000132D
		[global::Cpp2ILInjected.Token(Token = "0x6000667")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8444", Offset = "0x1FE8444", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected static MoveDirection DetermineMoveDirection(float x, float y)
		{
			throw null;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00003130 File Offset: 0x00001330
		[global::Cpp2ILInjected.Token(Token = "0x6000668")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8498", Offset = "0x1FE8498", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
		{
			throw null;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00003133 File Offset: 0x00001333
		[global::Cpp2ILInjected.Token(Token = "0x6000669")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE84E8", Offset = "0x1FE84E8", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
		{
			throw null;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00003136 File Offset: 0x00001336
		[global::Cpp2ILInjected.Token(Token = "0x600066A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8644", Offset = "0x1FE8644", Length = "0x9F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "ProcessMove", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ReleaseMouse", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "FindCommonRoot", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(GameObject)
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentInParent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
		{
			throw null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00003139 File Offset: 0x00001339
		[global::Cpp2ILInjected.Token(Token = "0x600066B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE903C", Offset = "0x1FE903C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AxisEventData), Member = ".ctor", MemberParameters = new object[] { typeof(EventSystem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
		{
			throw null;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000313C File Offset: 0x0000133C
		[global::Cpp2ILInjected.Token(Token = "0x600066C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9128", Offset = "0x1FE9128", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual BaseEventData GetBaseEventData()
		{
			throw null;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000313F File Offset: 0x0000133F
		[global::Cpp2ILInjected.Token(Token = "0x600066D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91A4", Offset = "0x1FE91A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool IsPointerOverGameObject(int pointerId)
		{
			throw null;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00003142 File Offset: 0x00001342
		[global::Cpp2ILInjected.Token(Token = "0x600066E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91AC", Offset = "0x1FE91AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		public virtual bool ShouldActivateModule()
		{
			throw null;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00003145 File Offset: 0x00001345
		[global::Cpp2ILInjected.Token(Token = "0x600066F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91E4", Offset = "0x1FE91E4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void DeactivateModule()
		{
			throw null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00003148 File Offset: 0x00001348
		[global::Cpp2ILInjected.Token(Token = "0x6000670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91E8", Offset = "0x1FE91E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ActivateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public virtual void ActivateModule()
		{
			throw null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000314B File Offset: 0x0000134B
		[global::Cpp2ILInjected.Token(Token = "0x6000671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91EC", Offset = "0x1FE91EC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void UpdateModule()
		{
			throw null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000314E File Offset: 0x0000134E
		[global::Cpp2ILInjected.Token(Token = "0x6000672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91F0", Offset = "0x1FE91F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual bool IsModuleSupported()
		{
			throw null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00003151 File Offset: 0x00001351
		[global::Cpp2ILInjected.Token(Token = "0x6000673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE91F8", Offset = "0x1FE91F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			throw null;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00003154 File Offset: 0x00001354
		[global::Cpp2ILInjected.Token(Token = "0x6000674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9200", Offset = "0x1FE9200", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<RaycastResult>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected BaseInputModule()
		{
			throw null;
		}

		// Token: 0x040001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x40002E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[NonSerialized]
		protected List<RaycastResult> m_RaycastResultCache;

		// Token: 0x040001FE RID: 510
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_SendPointerHoverToParent;

		// Token: 0x040001FF RID: 511
		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private AxisEventData m_AxisEventData;

		// Token: 0x04000200 RID: 512
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private EventSystem m_EventSystem;

		// Token: 0x04000201 RID: 513
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private BaseEventData m_BaseEventData;

		// Token: 0x04000202 RID: 514
		[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected BaseInput m_InputOverride;

		// Token: 0x04000203 RID: 515
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BaseInput m_DefaultInput;
	}
}
