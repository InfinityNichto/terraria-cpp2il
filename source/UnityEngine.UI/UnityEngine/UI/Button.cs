using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000003 RID: 3
	[AddComponentMenu("UI/Button", 30)]
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5FB4", Offset = "0x1FA5FB4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected Button()
		{
			throw null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public Button.ButtonClickedEvent onClick
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA6048", Offset = "0x1FA6048", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA6050", Offset = "0x1FA6050", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA6058", Offset = "0x1FA6058", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Button), Member = "OnPointerClick", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Button), Member = "OnSubmit", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent), Member = "Invoke", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Press()
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA60E8", Offset = "0x1FA60E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Button), Member = "Press", ReturnType = typeof(void))]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA60F8", Offset = "0x1FA60F8", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Button), Member = "Press", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Button), Member = "OnFinishSubmit", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		public virtual void OnSubmit(BaseEventData eventData)
		{
			throw null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA6170", Offset = "0x1FA6170", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Button), Member = "OnSubmit", MemberParameters = new object[] { typeof(BaseEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IEnumerator OnFinishSubmit()
		{
			throw null;
		}

		// Token: 0x0400000B RID: 11
		[SerializeField]
		[FormerlySerializedAs("onClick")]
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private Button.ButtonClickedEvent m_OnClick;

		// Token: 0x0200007F RID: 127
		[global::Cpp2ILInjected.Token(Token = "0x2000004")]
		[Serializable]
		public class ButtonClickedEvent : UnityEvent
		{
			// Token: 0x06000664 RID: 1636 RVA: 0x000032CB File Offset: 0x000014CB
			[global::Cpp2ILInjected.Token(Token = "0x6000013")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA6040", Offset = "0x1FA6040", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent), Member = ".ctor", ReturnType = typeof(void))]
			public ButtonClickedEvent()
			{
				throw null;
			}
		}

		// Token: 0x02000080 RID: 128
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000005")]
		private sealed class <OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06000665 RID: 1637 RVA: 0x000032CE File Offset: 0x000014CE
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000014")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA61D0", Offset = "0x1FA61D0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <OnFinishSubmit>d__9(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x000032D1 File Offset: 0x000014D1
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000015")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA61F8", Offset = "0x1FA61F8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x000032D4 File Offset: 0x000014D4
			[global::Cpp2ILInjected.Token(Token = "0x6000016")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA61FC", Offset = "0x1FA61FC", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Selectable), Member = "get_currentSelectionState", ReturnType = "UnityEngine.UI.Selectable.SelectionState")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x06000668 RID: 1640 RVA: 0x000032D7 File Offset: 0x000014D7
			[global::Cpp2ILInjected.Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000017")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FA62AC", Offset = "0x1FA62AC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x000032DA File Offset: 0x000014DA
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000018")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA62B4", Offset = "0x1FA62B4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x000032DD File Offset: 0x000014DD
			[global::Cpp2ILInjected.Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000019")]
				[global::Cpp2ILInjected.Address(RVA = "0x1FA62EC", Offset = "0x1FA62EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04000249 RID: 585
			[global::Cpp2ILInjected.Token(Token = "0x400000C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400024A RID: 586
			[global::Cpp2ILInjected.Token(Token = "0x400000D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400024B RID: 587
			[global::Cpp2ILInjected.Token(Token = "0x400000E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Button <>4__this;

			// Token: 0x0400024C RID: 588
			[global::Cpp2ILInjected.Token(Token = "0x400000F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private float <fadeTime>5__2;

			// Token: 0x0400024D RID: 589
			[global::Cpp2ILInjected.Token(Token = "0x4000010")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private float <elapsedTime>5__3;
		}
	}
}
