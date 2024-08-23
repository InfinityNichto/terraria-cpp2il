using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000068 RID: 104
	[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
	public abstract class PointerInputModule : BaseInputModule
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x00003157 File Offset: 0x00001357
		[global::Cpp2ILInjected.Token(Token = "0x6000675")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9284", Offset = "0x1FE9284", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerInputModule.MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetLastPointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "IsPointerOverGameObject", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = ".ctor", MemberParameters = new object[] { typeof(EventSystem) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected bool GetPointerData(int id, out PointerEventData data, bool create)
		{
			throw null;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000315A File Offset: 0x0000135A
		[global::Cpp2ILInjected.Token(Token = "0x6000676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9364", Offset = "0x1FE9364", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void RemovePointerData(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000315D File Offset: 0x0000135D
		[global::Cpp2ILInjected.Token(Token = "0x6000677")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE93BC", Offset = "0x1FE93BC", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_fingerId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref PointerEventData),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_phase", ReturnType = typeof(TouchPhase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(List<RaycastResult>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast", MemberParameters = new object[] { typeof(List<RaycastResult>) }, ReturnType = typeof(RaycastResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_pressure", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_altitudeAngle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_azimuthAngle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_radius", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_radiusVariance", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released)
		{
			throw null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00003160 File Offset: 0x00001360
		[global::Cpp2ILInjected.Token(Token = "0x6000678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE96A8", Offset = "0x1FE96A8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerInputModule.MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected void CopyFromTo(PointerEventData from, PointerEventData to)
		{
			throw null;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00003163 File Offset: 0x00001363
		[global::Cpp2ILInjected.Token(Token = "0x6000679")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE972C", Offset = "0x1FE972C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerInputModule.MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		protected PointerEventData.FramePressState StateForMouseButton(int buttonId)
		{
			throw null;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00003166 File Offset: 0x00001366
		[global::Cpp2ILInjected.Token(Token = "0x600067A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE979C", Offset = "0x1FE979C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual PointerInputModule.MouseState GetMousePointerEventData()
		{
			throw null;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00003169 File Offset: 0x00001369
		[global::Cpp2ILInjected.Token(Token = "0x600067B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE97B0", Offset = "0x1FE97B0", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref PointerEventData),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "RaycastAll", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(List<RaycastResult>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "FindFirstRaycast", MemberParameters = new object[] { typeof(List<RaycastResult>) }, ReturnType = typeof(RaycastResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "CopyFromTo", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(PointerEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "StateForMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerEventData.FramePressState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseState), Member = "GetButtonState", MemberParameters = new object[] { typeof(PointerEventData.InputButton) }, ReturnType = typeof(PointerInputModule.ButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id)
		{
			throw null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000316C File Offset: 0x0000136C
		[global::Cpp2ILInjected.Token(Token = "0x600067C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9AB0", Offset = "0x1FE9AB0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref PointerEventData),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		protected PointerEventData GetLastPointerEventData(int id)
		{
			throw null;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000316F File Offset: 0x0000136F
		[global::Cpp2ILInjected.Token(Token = "0x600067D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9AD0", Offset = "0x1FE9AD0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold)
		{
			throw null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00003172 File Offset: 0x00001372
		[global::Cpp2ILInjected.Token(Token = "0x600067E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9B00", Offset = "0x1FE9B00", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMove", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		protected virtual void ProcessMove(PointerEventData pointerEvent)
		{
			throw null;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00003175 File Offset: 0x00001375
		[global::Cpp2ILInjected.Token(Token = "0x600067F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9B3C", Offset = "0x1FE9B3C", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Cursor), Member = "get_lockState", ReturnType = typeof(CursorLockMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData),
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "set_pointerPress", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected virtual void ProcessDrag(PointerEventData pointerEvent)
		{
			throw null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00003178 File Offset: 0x00001378
		[global::Cpp2ILInjected.Token(Token = "0x6000680")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9DD8", Offset = "0x1FE9DD8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref PointerEventData),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsPointerOverGameObject(int pointerId)
		{
			throw null;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000317B File Offset: 0x0000137B
		[global::Cpp2ILInjected.Token(Token = "0x6000681")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE9E74", Offset = "0x1FE9E74", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "DeactivateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "DeactivateModule", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		protected void ClearSelection()
		{
			throw null;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000317E File Offset: 0x0000137E
		[global::Cpp2ILInjected.Token(Token = "0x6000682")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA01C", Offset = "0x1FEA01C", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00003181 File Offset: 0x00001381
		[global::Cpp2ILInjected.Token(Token = "0x6000683")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA284", Offset = "0x1FEA284", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExecuteEvents), Member = "GetEventHandler", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventSystem), Member = "SetSelectedGameObject", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
		{
			throw null;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00003184 File Offset: 0x00001384
		[global::Cpp2ILInjected.Token(Token = "0x6000684")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEA368", Offset = "0x1FEA368", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected PointerInputModule()
		{
			throw null;
		}

		// Token: 0x04000204 RID: 516
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		public const int kMouseLeftId = -1;

		// Token: 0x04000205 RID: 517
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		public const int kMouseRightId = -2;

		// Token: 0x04000206 RID: 518
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		public const int kMouseMiddleId = -3;

		// Token: 0x04000207 RID: 519
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		public const int kFakeTouchesId = -4;

		// Token: 0x04000208 RID: 520
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected Dictionary<int, PointerEventData> m_PointerData;

		// Token: 0x04000209 RID: 521
		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly PointerInputModule.MouseState m_MouseState;

		// Token: 0x020000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x20000B4")]
		protected class ButtonState
		{
			// Token: 0x170001CF RID: 463
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00003415 File Offset: 0x00001615
			// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00003418 File Offset: 0x00001618
			[global::Cpp2ILInjected.Token(Token = "0x170001B8")]
			public PointerInputModule.MouseButtonEventData eventData
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000685")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FEA484", Offset = "0x1FEA484", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000686")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FEA48C", Offset = "0x1FEA48C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0000341B File Offset: 0x0000161B
			// (set) Token: 0x060006F6 RID: 1782 RVA: 0x0000341E File Offset: 0x0000161E
			[global::Cpp2ILInjected.Token(Token = "0x170001B9")]
			public PointerEventData.InputButton button
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000687")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FEA494", Offset = "0x1FEA494", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000688")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FEA49C", Offset = "0x1FEA49C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x00003421 File Offset: 0x00001621
			[global::Cpp2ILInjected.Token(Token = "0x6000689")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA4A4", Offset = "0x1FEA4A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ButtonState()
			{
				throw null;
			}

			// Token: 0x04000335 RID: 821
			[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private PointerEventData.InputButton m_Button;

			// Token: 0x04000336 RID: 822
			[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private PointerInputModule.MouseButtonEventData m_EventData;
		}

		// Token: 0x020000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
		protected class MouseState
		{
			// Token: 0x060006F8 RID: 1784 RVA: 0x00003424 File Offset: 0x00001624
			[global::Cpp2ILInjected.Token(Token = "0x600068A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA4AC", Offset = "0x1FEA4AC", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool AnyPressesThisFrame()
			{
				throw null;
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x00003427 File Offset: 0x00001627
			[global::Cpp2ILInjected.Token(Token = "0x600068B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA578", Offset = "0x1FEA578", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool AnyReleasesThisFrame()
			{
				throw null;
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x0000342A File Offset: 0x0000162A
			[global::Cpp2ILInjected.Token(Token = "0x600068C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA650", Offset = "0x1FEA650", Length = "0x18C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule.MouseState), Member = "SetButtonState", MemberParameters = new object[]
			{
				typeof(PointerEventData.InputButton),
				typeof(PointerEventData.FramePressState),
				typeof(PointerEventData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = "GetMousePointerEventData", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PointerInputModule.MouseState))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StandaloneInputModule), Member = "ProcessMouseEvent", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "FakeTouches", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button)
			{
				throw null;
			}

			// Token: 0x060006FB RID: 1787 RVA: 0x0000342D File Offset: 0x0000162D
			[global::Cpp2ILInjected.Token(Token = "0x600068D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE9A84", Offset = "0x1FE9A84", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseState), Member = "GetButtonState", MemberParameters = new object[] { typeof(PointerEventData.InputButton) }, ReturnType = "UnityEngine.EventSystems.PointerInputModule.ButtonState")]
			public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data)
			{
				throw null;
			}

			// Token: 0x060006FC RID: 1788 RVA: 0x00003430 File Offset: 0x00001630
			[global::Cpp2ILInjected.Token(Token = "0x600068E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA408", Offset = "0x1FEA408", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public MouseState()
			{
				throw null;
			}

			// Token: 0x04000337 RID: 823
			[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private List<PointerInputModule.ButtonState> m_TrackedButtons;
		}

		// Token: 0x020000CC RID: 204
		[global::Cpp2ILInjected.Token(Token = "0x20000B6")]
		public class MouseButtonEventData
		{
			// Token: 0x060006FD RID: 1789 RVA: 0x00003433 File Offset: 0x00001633
			[global::Cpp2ILInjected.Token(Token = "0x600068F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA568", Offset = "0x1FEA568", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public bool PressedThisFrame()
			{
				throw null;
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x00003436 File Offset: 0x00001636
			[global::Cpp2ILInjected.Token(Token = "0x6000690")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA63C", Offset = "0x1FEA63C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { typeof(PointerInputModule.MouseButtonEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			public bool ReleasedThisFrame()
			{
				throw null;
			}

			// Token: 0x060006FF RID: 1791 RVA: 0x00003439 File Offset: 0x00001639
			[global::Cpp2ILInjected.Token(Token = "0x6000691")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEA7DC", Offset = "0x1FEA7DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MouseButtonEventData()
			{
				throw null;
			}

			// Token: 0x04000338 RID: 824
			[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public PointerEventData.FramePressState buttonState;

			// Token: 0x04000339 RID: 825
			[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public PointerEventData buttonData;
		}
	}
}
