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
	// Token: 0x020000A6 RID: 166
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E7")]
	internal class FieldFilter : PathFilter
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x000039B0 File Offset: 0x00001BB0
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x000039B3 File Offset: 0x00001BB3
		[global::Cpp2ILInjected.Token(Token = "0x170001BA")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F958", Offset = "0x1D1F958", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60009A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F960", Offset = "0x1D1F960", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000039B6 File Offset: 0x00001BB6
		[global::Cpp2ILInjected.Token(Token = "0x60009A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1F968", Offset = "0x1D1F968", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000039B9 File Offset: 0x00001BB9
		[global::Cpp2ILInjected.Token(Token = "0x60009A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1FA14", Offset = "0x1D1FA14", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FieldFilter()
		{
			throw null;
		}

		// Token: 0x040002C8 RID: 712
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Name>k__BackingField;

		// Token: 0x02000131 RID: 305
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000E8")]
		private sealed class <ExecuteFilter>d__4 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B84 RID: 2948 RVA: 0x00004208 File Offset: 0x00002408
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F9D8", Offset = "0x1D1F9D8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter), Member = "ExecuteFilter", MemberParameters = new object[]
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

			// Token: 0x06000B85 RID: 2949 RVA: 0x0000420B File Offset: 0x0000240B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1FA1C", Offset = "0x1D1FA1C", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B86 RID: 2950 RVA: 0x0000420E File Offset: 0x0000240E
			[global::Cpp2ILInjected.Token(Token = "0x60009A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1FAD0", Offset = "0x1D1FAD0", Length = "0x5BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<KeyValuePair<string, JToken>>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "<>m__Finally2", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B87 RID: 2951 RVA: 0x00004211 File Offset: 0x00002411
			[global::Cpp2ILInjected.Token(Token = "0x60009A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2013C", Offset = "0x1D2013C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x06000B88 RID: 2952 RVA: 0x00004214 File Offset: 0x00002414
			[global::Cpp2ILInjected.Token(Token = "0x60009A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D2008C", Offset = "0x1D2008C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally2()
			{
				throw null;
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00004217 File Offset: 0x00002417
			[global::Cpp2ILInjected.Token(Token = "0x170001BB")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009A9")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D201EC", Offset = "0x1D201EC", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x0000421A File Offset: 0x0000241A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D201F4", Offset = "0x1D201F4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0000421D File Offset: 0x0000241D
			[global::Cpp2ILInjected.Token(Token = "0x170001BC")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x60009AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D2022C", Offset = "0x1D2022C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B8C RID: 2956 RVA: 0x00004220 File Offset: 0x00002420
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D20234", Offset = "0x1D20234", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B8D RID: 2957 RVA: 0x00004223 File Offset: 0x00002423
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60009AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D202D8", Offset = "0x1D202D8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldFilter.<ExecuteFilter>d__4), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000445 RID: 1093
			[global::Cpp2ILInjected.Token(Token = "0x40003B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000446 RID: 1094
			[global::Cpp2ILInjected.Token(Token = "0x40003B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x04000447 RID: 1095
			[global::Cpp2ILInjected.Token(Token = "0x40003B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000448 RID: 1096
			[global::Cpp2ILInjected.Token(Token = "0x40003B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerable<JToken> current;

			// Token: 0x04000449 RID: 1097
			[global::Cpp2ILInjected.Token(Token = "0x40003B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x0400044A RID: 1098
			[global::Cpp2ILInjected.Token(Token = "0x40003B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public FieldFilter <>4__this;

			// Token: 0x0400044B RID: 1099
			[global::Cpp2ILInjected.Token(Token = "0x40003B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private bool errorWhenNoMatch;

			// Token: 0x0400044C RID: 1100
			[global::Cpp2ILInjected.Token(Token = "0x40003B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
			public bool <>3__errorWhenNoMatch;

			// Token: 0x0400044D RID: 1101
			[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private JObject <o>5__1;

			// Token: 0x0400044E RID: 1102
			[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private JToken <t>5__2;

			// Token: 0x0400044F RID: 1103
			[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private IEnumerator<JToken> <>7__wrap1;

			// Token: 0x04000450 RID: 1104
			[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private IEnumerator<KeyValuePair<string, JToken>> <>7__wrap2;
		}
	}
}
