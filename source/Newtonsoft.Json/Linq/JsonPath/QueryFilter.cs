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
	// Token: 0x020000AE RID: 174
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	internal class QueryFilter : PathFilter
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x00003A2E File Offset: 0x00001C2E
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00003A31 File Offset: 0x00001C31
		[global::Cpp2ILInjected.Token(Token = "0x170001C5")]
		public QueryExpression Expression
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23EB4", Offset = "0x1D23EB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23EBC", Offset = "0x1D23EBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00003A34 File Offset: 0x00001C34
		[global::Cpp2ILInjected.Token(Token = "0x60009E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D23EC4", Offset = "0x1D23EC4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00003A37 File Offset: 0x00001C37
		[global::Cpp2ILInjected.Token(Token = "0x60009E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D228B4", Offset = "0x1D228B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public QueryFilter()
		{
			throw null;
		}

		// Token: 0x040002DC RID: 732
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private QueryExpression <Expression>k__BackingField;

		// Token: 0x02000134 RID: 308
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B9B RID: 2971 RVA: 0x0000424D File Offset: 0x0000244D
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23F2C", Offset = "0x1D23F2C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter), Member = "ExecuteFilter", MemberParameters = new object[]
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

			// Token: 0x06000B9C RID: 2972 RVA: 0x00004250 File Offset: 0x00002450
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D23F68", Offset = "0x1D23F68", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B9D RID: 2973 RVA: 0x00004253 File Offset: 0x00002453
			[global::Cpp2ILInjected.Token(Token = "0x60009E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24018", Offset = "0x1D24018", Length = "0x3C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x00004256 File Offset: 0x00002456
			[global::Cpp2ILInjected.Token(Token = "0x60009EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24490", Offset = "0x1D24490", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x00004259 File Offset: 0x00002459
			[global::Cpp2ILInjected.Token(Token = "0x60009EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D243E0", Offset = "0x1D243E0", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0000425C File Offset: 0x0000245C
			[global::Cpp2ILInjected.Token(Token = "0x170001C6")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009EC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D24540", Offset = "0x1D24540", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x0000425F File Offset: 0x0000245F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24548", Offset = "0x1D24548", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x00004262 File Offset: 0x00002462
			[global::Cpp2ILInjected.Token(Token = "0x170001C7")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009EE")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D24580", Offset = "0x1D24580", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x00004265 File Offset: 0x00002465
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24588", Offset = "0x1D24588", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x00004268 File Offset: 0x00002468
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D24624", Offset = "0x1D24624", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(QueryFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000460 RID: 1120
			[global::Cpp2ILInjected.Token(Token = "0x40003E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000461 RID: 1121
			[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x04000462 RID: 1122
			[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000463 RID: 1123
			[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			// Token: 0x04000464 RID: 1124
			[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x04000465 RID: 1125
			[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public QueryFilter <>4__this;

			// Token: 0x04000466 RID: 1126
			[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x04000467 RID: 1127
			[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private IEnumerator<JToken> <>7__wrap2;
		}
	}
}
