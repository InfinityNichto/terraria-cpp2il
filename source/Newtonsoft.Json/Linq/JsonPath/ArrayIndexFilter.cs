using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000A3 RID: 163
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
	internal class ArrayIndexFilter : PathFilter
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0000397D File Offset: 0x00001B7D
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00003980 File Offset: 0x00001B80
		[global::Cpp2ILInjected.Token(Token = "0x170001AF")]
		public int? Index
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000972")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1DBEC", Offset = "0x1D1DBEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000973")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1DBF4", Offset = "0x1D1DBF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00003983 File Offset: 0x00001B83
		[global::Cpp2ILInjected.Token(Token = "0x6000974")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DBFC", Offset = "0x1D1DBFC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00003986 File Offset: 0x00001B86
		[global::Cpp2ILInjected.Token(Token = "0x6000975")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1DCA8", Offset = "0x1D1DCA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArrayIndexFilter()
		{
			throw null;
		}

		// Token: 0x040002C3 RID: 707
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int? <Index>k__BackingField;

		// Token: 0x0200012E RID: 302
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000E2")]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B67 RID: 2919 RVA: 0x000041B1 File Offset: 0x000023B1
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000976")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1DC6C", Offset = "0x1D1DC6C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter), Member = "ExecuteFilter", MemberParameters = new object[]
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

			// Token: 0x06000B68 RID: 2920 RVA: 0x000041B4 File Offset: 0x000023B4
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000977")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1DCB8", Offset = "0x1D1DCB8", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B69 RID: 2921 RVA: 0x000041B7 File Offset: 0x000023B7
			[global::Cpp2ILInjected.Token(Token = "0x6000978")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1DD6C", Offset = "0x1D1DD6C", Length = "0x558")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PathFilter), Member = "GetTokenIndex", MemberParameters = new object[]
			{
				typeof(JToken),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x000041BA File Offset: 0x000023BA
			[global::Cpp2ILInjected.Token(Token = "0x6000979")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E630", Offset = "0x1D1E630", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x000041BD File Offset: 0x000023BD
			[global::Cpp2ILInjected.Token(Token = "0x600097A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E580", Offset = "0x1D1E580", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000041C0 File Offset: 0x000023C0
			[global::Cpp2ILInjected.Token(Token = "0x170001B0")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600097B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1E6E0", Offset = "0x1D1E6E0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B6D RID: 2925 RVA: 0x000041C3 File Offset: 0x000023C3
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600097C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E6E8", Offset = "0x1D1E6E8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06000B6E RID: 2926 RVA: 0x000041C6 File Offset: 0x000023C6
			[global::Cpp2ILInjected.Token(Token = "0x170001B1")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600097D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1E720", Offset = "0x1D1E720", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x000041C9 File Offset: 0x000023C9
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600097E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E728", Offset = "0x1D1E728", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x000041CC File Offset: 0x000023CC
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600097F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1E7CC", Offset = "0x1D1E7CC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayIndexFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000420 RID: 1056
			[global::Cpp2ILInjected.Token(Token = "0x4000387")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000421 RID: 1057
			[global::Cpp2ILInjected.Token(Token = "0x4000388")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x04000422 RID: 1058
			[global::Cpp2ILInjected.Token(Token = "0x4000389")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000423 RID: 1059
			[global::Cpp2ILInjected.Token(Token = "0x400038A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			// Token: 0x04000424 RID: 1060
			[global::Cpp2ILInjected.Token(Token = "0x400038B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x04000425 RID: 1061
			[global::Cpp2ILInjected.Token(Token = "0x400038C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public ArrayIndexFilter <>4__this;

			// Token: 0x04000426 RID: 1062
			[global::Cpp2ILInjected.Token(Token = "0x400038D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private bool errorWhenNoMatch;

			// Token: 0x04000427 RID: 1063
			[global::Cpp2ILInjected.Token(Token = "0x400038E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
			public bool <>3__errorWhenNoMatch;

			// Token: 0x04000428 RID: 1064
			[global::Cpp2ILInjected.Token(Token = "0x400038F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private JToken <t>5__1;

			// Token: 0x04000429 RID: 1065
			[global::Cpp2ILInjected.Token(Token = "0x4000390")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x0400042A RID: 1066
			[global::Cpp2ILInjected.Token(Token = "0x4000391")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private IEnumerator<JToken> <>7__wrap2;
		}
	}
}
