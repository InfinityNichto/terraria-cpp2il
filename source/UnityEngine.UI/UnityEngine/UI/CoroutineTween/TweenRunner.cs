using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI.CoroutineTween
{
	// Token: 0x02000049 RID: 73
	[global::Cpp2ILInjected.Token(Token = "0x200008E")]
	internal class TweenRunner<T> where T : struct, ITweenValue
	{
		// Token: 0x060004F2 RID: 1266 RVA: 0x00002EB4 File Offset: 0x000010B4
		[global::Cpp2ILInjected.Token(Token = "0x6000575")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893840", Offset = "0x1893840", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static IEnumerator Start(T tweenInfo)
		{
			throw null;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002EB7 File Offset: 0x000010B7
		[global::Cpp2ILInjected.Token(Token = "0x6000576")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893900", Offset = "0x1893900", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Init(MonoBehaviour coroutineContainer)
		{
			throw null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002EBA File Offset: 0x000010BA
		[global::Cpp2ILInjected.Token(Token = "0x6000577")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893908", Offset = "0x1893908", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeInHierarchy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(Coroutine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ColorTween), Member = "TweenValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void StartTween(T info)
		{
			throw null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002EBD File Offset: 0x000010BD
		[global::Cpp2ILInjected.Token(Token = "0x6000578")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893A8C", Offset = "0x1893A8C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine", MemberParameters = new object[] { typeof(IEnumerator) }, ReturnType = typeof(void))]
		public void StopTween()
		{
			throw null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002EC0 File Offset: 0x000010C0
		[global::Cpp2ILInjected.Token(Token = "0x6000579")]
		[global::Cpp2ILInjected.Address(RVA = "0x1893AB4", Offset = "0x1893AB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TweenRunner()
		{
			throw null;
		}

		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected MonoBehaviour m_CoroutineContainer;

		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected IEnumerator m_Tween;

		// Token: 0x020000C4 RID: 196
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200008F")]
		private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060006E7 RID: 1767 RVA: 0x000033FD File Offset: 0x000015FD
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600057A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE560", Offset = "0x15BE560", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <Start>d__2(int <>1__state)
			{
				throw null;
			}

			// Token: 0x060006E8 RID: 1768 RVA: 0x00003400 File Offset: 0x00001600
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600057B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE588", Offset = "0x15BE588", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x060006E9 RID: 1769 RVA: 0x00003403 File Offset: 0x00001603
			[global::Cpp2ILInjected.Token(Token = "0x600057C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE58C", Offset = "0x15BE58C", Length = "0xFC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ColorTween), Member = "ValidTarget", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ColorTween), Member = "TweenValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x060006EA RID: 1770 RVA: 0x00003406 File Offset: 0x00001606
			[global::Cpp2ILInjected.Token(Token = "0x17000167")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600057D")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BE688", Offset = "0x15BE688", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x00003409 File Offset: 0x00001609
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600057E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15BE690", Offset = "0x15BE690", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x060006EC RID: 1772 RVA: 0x0000340C File Offset: 0x0000160C
			[global::Cpp2ILInjected.Token(Token = "0x17000168")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600057F")]
				[global::Cpp2ILInjected.Address(RVA = "0x15BE6C8", Offset = "0x15BE6C8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04000326 RID: 806
			[global::Cpp2ILInjected.Token(Token = "0x4000283")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			// Token: 0x04000327 RID: 807
			[global::Cpp2ILInjected.Token(Token = "0x4000284")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			// Token: 0x04000328 RID: 808
			[global::Cpp2ILInjected.Token(Token = "0x4000285")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public T tweenInfo;

			// Token: 0x04000329 RID: 809
			[global::Cpp2ILInjected.Token(Token = "0x4000286")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private float <elapsedTime>5__2;
		}
	}
}
