using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000A7 RID: 167
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
	internal class FieldMultipleFilter : PathFilter
	{
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000039BC File Offset: 0x00001BBC
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x000039BF File Offset: 0x00001BBF
		[global::Cpp2ILInjected.Token(Token = "0x170001BD")]
		public List<string> Names
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D202DC", Offset = "0x1D202DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D202E4", Offset = "0x1D202E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000039C2 File Offset: 0x00001BC2
		[global::Cpp2ILInjected.Token(Token = "0x60009B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D202EC", Offset = "0x1D202EC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x000039C5 File Offset: 0x00001BC5
		[global::Cpp2ILInjected.Token(Token = "0x60009B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D20398", Offset = "0x1D20398", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FieldMultipleFilter()
		{
			throw null;
		}

		// Token: 0x040002C9 RID: 713
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<string> <Names>k__BackingField;

		// Token: 0x02000132 RID: 306
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000B8E RID: 2958 RVA: 0x00004226 File Offset: 0x00002426
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60009B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D203A0", Offset = "0x1D203A0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000B8F RID: 2959 RVA: 0x00004229 File Offset: 0x00002429
			[global::Cpp2ILInjected.Token(Token = "0x60009B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D203FC", Offset = "0x1D203FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x0000422C File Offset: 0x0000242C
			[global::Cpp2ILInjected.Token(Token = "0x60009B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20404", Offset = "0x1D20404", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <ExecuteFilter>b__4_0(string n)
			{
				throw null;
			}

			// Token: 0x04000451 RID: 1105
			[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
			public static readonly FieldMultipleFilter.<>c <>9;

			// Token: 0x04000452 RID: 1106
			[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
			public static Func<string, string> <>9__4_0;
		}

		// Token: 0x02000133 RID: 307
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B91 RID: 2961 RVA: 0x0000422F File Offset: 0x0000242F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2035C", Offset = "0x1D2035C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter), Member = "ExecuteFilter", MemberParameters = new object[]
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

			// Token: 0x06000B92 RID: 2962 RVA: 0x00004232 File Offset: 0x00002432
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20454", Offset = "0x1D20454", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x00004235 File Offset: 0x00002435
			[global::Cpp2ILInjected.Token(Token = "0x60009B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20504", Offset = "0x1D20504", Length = "0x654")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Select", MemberTypeParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, MemberParameters = new object[]
			{
				typeof(IEnumerable<object>),
				typeof(Func<object, object>)
			}, ReturnType = "System.Collections.Generic.IEnumerable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToArray", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "TSource[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Join", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x00004238 File Offset: 0x00002438
			[global::Cpp2ILInjected.Token(Token = "0x60009B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20BA8", Offset = "0x1D20BA8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B95 RID: 2965 RVA: 0x0000423B File Offset: 0x0000243B
			[global::Cpp2ILInjected.Token(Token = "0x60009B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20B58", Offset = "0x1D20B58", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0000423E File Offset: 0x0000243E
			[global::Cpp2ILInjected.Token(Token = "0x170001BE")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009BA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D20C58", Offset = "0x1D20C58", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x00004241 File Offset: 0x00002441
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20C60", Offset = "0x1D20C60", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x06000B98 RID: 2968 RVA: 0x00004244 File Offset: 0x00002444
			[global::Cpp2ILInjected.Token(Token = "0x170001BF")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009BC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D20C98", Offset = "0x1D20C98", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B99 RID: 2969 RVA: 0x00004247 File Offset: 0x00002447
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20CA0", Offset = "0x1D20CA0", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B9A RID: 2970 RVA: 0x0000424A File Offset: 0x0000244A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20D44", Offset = "0x1D20D44", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldMultipleFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000453 RID: 1107
			[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000454 RID: 1108
			[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x04000455 RID: 1109
			[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000456 RID: 1110
			[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			// Token: 0x04000457 RID: 1111
			[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x04000458 RID: 1112
			[global::Cpp2ILInjected.Token(Token = "0x40003C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public FieldMultipleFilter <>4__this;

			// Token: 0x04000459 RID: 1113
			[global::Cpp2ILInjected.Token(Token = "0x40003C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private JObject <o>5__1;

			// Token: 0x0400045A RID: 1114
			[global::Cpp2ILInjected.Token(Token = "0x40003C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private bool errorWhenNoMatch;

			// Token: 0x0400045B RID: 1115
			[global::Cpp2ILInjected.Token(Token = "0x40003C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
			public bool <>3__errorWhenNoMatch;

			// Token: 0x0400045C RID: 1116
			[global::Cpp2ILInjected.Token(Token = "0x40003C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private string <name>5__2;

			// Token: 0x0400045D RID: 1117
			[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private JToken <t>5__3;

			// Token: 0x0400045E RID: 1118
			[global::Cpp2ILInjected.Token(Token = "0x40003CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x0400045F RID: 1119
			[global::Cpp2ILInjected.Token(Token = "0x40003CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private List<string>.Enumerator <>7__wrap2;
		}
	}
}
