using System;
using System.Collections.Generic;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006A RID: 106
	[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
	[AddComponentMenu("Event/Touch Input Module")]
	[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
	public class TouchInputModule : PointerInputModule
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000031F3 File Offset: 0x000013F3
		[global::Cpp2ILInjected.Token(Token = "0x60006B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC4F4", Offset = "0x1FEC4F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = ".ctor", ReturnType = typeof(void))]
		protected TouchInputModule()
		{
			throw null;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x000031F6 File Offset: 0x000013F6
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x000031F9 File Offset: 0x000013F9
		[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
		[global::Cpp2ILInjected.Token(Token = "0x170001C3")]
		public bool allowActivationOnStandalone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEC4F8", Offset = "0x1FEC4F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEC500", Offset = "0x1FEC500", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000031FC File Offset: 0x000013FC
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x000031FF File Offset: 0x000013FF
		[global::Cpp2ILInjected.Token(Token = "0x170001C4")]
		public bool forceModuleActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEC50C", Offset = "0x1FEC50C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEC514", Offset = "0x1FEC514", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003202 File Offset: 0x00001402
		[global::Cpp2ILInjected.Token(Token = "0x60006BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC520", Offset = "0x1FEC520", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void UpdateModule()
		{
			throw null;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00003205 File Offset: 0x00001405
		[global::Cpp2ILInjected.Token(Token = "0x60006BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC660", Offset = "0x1FEC660", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool IsModuleSupported()
		{
			throw null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00003208 File Offset: 0x00001408
		[global::Cpp2ILInjected.Token(Token = "0x60006BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC690", Offset = "0x1FEC690", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "ShouldActivateModule", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		public override bool ShouldActivateModule()
		{
			throw null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000320B File Offset: 0x0000140B
		[global::Cpp2ILInjected.Token(Token = "0x60006BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC73C", Offset = "0x1FEC73C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		private bool UseFakeInput()
		{
			throw null;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000320E File Offset: 0x0000140E
		[global::Cpp2ILInjected.Token(Token = "0x60006BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC764", Offset = "0x1FEC764", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
		public override void Process()
		{
			throw null;
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003211 File Offset: 0x00001411
		[global::Cpp2ILInjected.Token(Token = "0x60006C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC79C", Offset = "0x1FEC79C", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule.MouseState), Member = "GetButtonState", MemberParameters = new object[] { typeof(PointerEventData.InputButton) }, ReturnType = typeof(PointerInputModule.ButtonState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void FakeTouches()
		{
			throw null;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003214 File Offset: 0x00001414
		[global::Cpp2ILInjected.Token(Token = "0x60006C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC8A8", Offset = "0x1FEC8A8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "Process", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Touch), Member = "get_type", ReturnType = typeof(TouchType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetTouchPointerEventData", MemberParameters = new object[]
		{
			typeof(Touch),
			typeof(ref bool),
			typeof(ref bool)
		}, ReturnType = typeof(PointerEventData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchInputModule), Member = "ProcessTouchPress", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "RemovePointerData", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ProcessTouchEvents()
		{
			throw null;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00003217 File Offset: 0x00001417
		[global::Cpp2ILInjected.Token(Token = "0x60006C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEC9F8", Offset = "0x1FEC9F8", Length = "0x660")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "FakeTouches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchInputModule), Member = "ProcessTouchEvents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "DeselectIfSelectionChanged", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(BaseEventData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
		{
			throw null;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000321A File Offset: 0x0000141A
		[global::Cpp2ILInjected.Token(Token = "0x60006C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED058", Offset = "0x1FED058", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "ClearSelection", ReturnType = typeof(void))]
		public override void DeactivateModule()
		{
			throw null;
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000321D File Offset: 0x0000141D
		[global::Cpp2ILInjected.Token(Token = "0x60006C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED05C", Offset = "0x1FED05C", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseInputModule), Member = "get_input", ReturnType = typeof(BaseInput))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<int, object>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerInputModule), Member = "GetPointerData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref PointerEventData),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Vector2 m_LastMousePosition;

		// Token: 0x04000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Vector2 m_MousePosition;

		// Token: 0x0400021A RID: 538
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private PointerEventData m_InputPointerEvent;

		// Token: 0x0400021B RID: 539
		[SerializeField]
		[FormerlySerializedAs("m_AllowActivationOnStandalone")]
		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool m_ForceModuleActive;
	}
}
