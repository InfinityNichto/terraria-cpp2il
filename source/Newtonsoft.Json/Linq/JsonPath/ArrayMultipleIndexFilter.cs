using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000A4 RID: 164
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E3")]
	internal class ArrayMultipleIndexFilter : PathFilter
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00003989 File Offset: 0x00001B89
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x0000398C File Offset: 0x00001B8C
		[global::Cpp2ILInjected.Token(Token = "0x170001B2")]
		public List<int> Indexes
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000980")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E7D0", Offset = "0x1D1E7D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000981")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E7D8", Offset = "0x1D1E7D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0000398F File Offset: 0x00001B8F
		[global::Cpp2ILInjected.Token(Token = "0x6000982")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1E7E0", Offset = "0x1D1E7E0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00003992 File Offset: 0x00001B92
		[global::Cpp2ILInjected.Token(Token = "0x6000983")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1E88C", Offset = "0x1D1E88C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArrayMultipleIndexFilter()
		{
			throw null;
		}

		// Token: 0x040002C4 RID: 708
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<int> <Indexes>k__BackingField;

		// Token: 0x0200012F RID: 303
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000E4")]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B71 RID: 2929 RVA: 0x000041CF File Offset: 0x000023CF
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000984")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E850", Offset = "0x1D1E850", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter), Member = "ExecuteFilter", MemberParameters = new object[]
			{
				typeof(IEnumerable<JToken>),
				typeof(bool)
			}, ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <ExecuteFilter>d__4(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x000041D2 File Offset: 0x000023D2
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000985")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E894", Offset = "0x1D1E894", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x000041D5 File Offset: 0x000023D5
			[global::Cpp2ILInjected.Token(Token = "0x6000986")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E944", Offset = "0x1D1E944", Length = "0x31C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathFilter), Member = "GetTokenIndex", MemberParameters = new object[]
			{
				typeof(JToken),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x000041D8 File Offset: 0x000023D8
			[global::Cpp2ILInjected.Token(Token = "0x6000987")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1ECB0", Offset = "0x1D1ECB0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B75 RID: 2933 RVA: 0x000041DB File Offset: 0x000023DB
			[global::Cpp2ILInjected.Token(Token = "0x6000988")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EC60", Offset = "0x1D1EC60", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x06000B76 RID: 2934 RVA: 0x000041DE File Offset: 0x000023DE
			[global::Cpp2ILInjected.Token(Token = "0x170001B3")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000989")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1ED60", Offset = "0x1D1ED60", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B77 RID: 2935 RVA: 0x000041E1 File Offset: 0x000023E1
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1ED68", Offset = "0x1D1ED68", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000B78 RID: 2936 RVA: 0x000041E4 File Offset: 0x000023E4
			[global::Cpp2ILInjected.Token(Token = "0x170001B4")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600098B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1EDA0", Offset = "0x1D1EDA0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B79 RID: 2937 RVA: 0x000041E7 File Offset: 0x000023E7
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EDA8", Offset = "0x1D1EDA8", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x000041EA File Offset: 0x000023EA
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600098D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE4C", Offset = "0x1D1EE4C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayMultipleIndexFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x0400042B RID: 1067
			[global::Cpp2ILInjected.Token(Token = "0x4000393")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400042C RID: 1068
			[global::Cpp2ILInjected.Token(Token = "0x4000394")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x0400042D RID: 1069
			[global::Cpp2ILInjected.Token(Token = "0x4000395")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x0400042E RID: 1070
			[global::Cpp2ILInjected.Token(Token = "0x4000396")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			// Token: 0x0400042F RID: 1071
			[global::Cpp2ILInjected.Token(Token = "0x4000397")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x04000430 RID: 1072
			[global::Cpp2ILInjected.Token(Token = "0x4000398")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public ArrayMultipleIndexFilter <>4__this;

			// Token: 0x04000431 RID: 1073
			[global::Cpp2ILInjected.Token(Token = "0x4000399")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private JToken <t>5__1;

			// Token: 0x04000432 RID: 1074
			[global::Cpp2ILInjected.Token(Token = "0x400039A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool errorWhenNoMatch;

			// Token: 0x04000433 RID: 1075
			[global::Cpp2ILInjected.Token(Token = "0x400039B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
			public bool <>3__errorWhenNoMatch;

			// Token: 0x04000434 RID: 1076
			[global::Cpp2ILInjected.Token(Token = "0x400039C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x04000435 RID: 1077
			[global::Cpp2ILInjected.Token(Token = "0x400039D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private List<int>.Enumerator <>7__wrap2;
		}
	}
}
