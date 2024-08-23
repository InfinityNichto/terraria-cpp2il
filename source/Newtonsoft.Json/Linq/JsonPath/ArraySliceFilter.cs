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
	// Token: 0x020000A5 RID: 165
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	internal class ArraySliceFilter : PathFilter
	{
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00003995 File Offset: 0x00001B95
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00003998 File Offset: 0x00001B98
		[global::Cpp2ILInjected.Token(Token = "0x170001B5")]
		public int? Start
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600098E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE50", Offset = "0x1D1EE50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600098F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE58", Offset = "0x1D1EE58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0000399B File Offset: 0x00001B9B
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x0000399E File Offset: 0x00001B9E
		[global::Cpp2ILInjected.Token(Token = "0x170001B6")]
		public int? End
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000990")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE60", Offset = "0x1D1EE60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000991")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE68", Offset = "0x1D1EE68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000039A1 File Offset: 0x00001BA1
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x000039A4 File Offset: 0x00001BA4
		[global::Cpp2ILInjected.Token(Token = "0x170001B7")]
		public int? Step
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000992")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE70", Offset = "0x1D1EE70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000993")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EE78", Offset = "0x1D1EE78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000039A7 File Offset: 0x00001BA7
		[global::Cpp2ILInjected.Token(Token = "0x6000994")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1EE80", Offset = "0x1D1EE80", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x000039AA File Offset: 0x00001BAA
		[global::Cpp2ILInjected.Token(Token = "0x6000995")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1EF30", Offset = "0x1D1EF30", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			throw null;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000039AD File Offset: 0x00001BAD
		[global::Cpp2ILInjected.Token(Token = "0x6000996")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1EF48", Offset = "0x1D1EF48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArraySliceFilter()
		{
			throw null;
		}

		// Token: 0x040002C5 RID: 709
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int? <Start>k__BackingField;

		// Token: 0x040002C6 RID: 710
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int? <End>k__BackingField;

		// Token: 0x040002C7 RID: 711
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int? <Step>k__BackingField;

		// Token: 0x02000130 RID: 304
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
		private sealed class <ExecuteFilter>d__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
			// Token: 0x06000B7B RID: 2939 RVA: 0x000041ED File Offset: 0x000023ED
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000997")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EEF4", Offset = "0x1D1EEF4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySliceFilter), Member = "ExecuteFilter", MemberParameters = new object[]
			{
				typeof(IEnumerable<JToken>),
				typeof(bool)
			}, ReturnType = typeof(IEnumerable<JToken>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			public <ExecuteFilter>d__12(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x000041F0 File Offset: 0x000023F0
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000998")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EF50", Offset = "0x1D1EF50", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "<>m__Finally1", ReturnType = typeof(void))]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06000B7D RID: 2941 RVA: 0x000041F3 File Offset: 0x000023F3
			[global::Cpp2ILInjected.Token(Token = "0x6000999")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1EF6C", Offset = "0x1D1EF6C", Length = "0x84C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JContainer), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JArray), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(JToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "<>m__Finally1", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
			{
				typeof(string),
				typeof(IFormatProvider),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06000B7E RID: 2942 RVA: 0x000041F6 File Offset: 0x000023F6
			[global::Cpp2ILInjected.Token(Token = "0x600099A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F7B8", Offset = "0x1D1F7B8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void <>m__Finally1()
			{
				throw null;
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x06000B7F RID: 2943 RVA: 0x000041F9 File Offset: 0x000023F9
			[global::Cpp2ILInjected.Token(Token = "0x170001B8")]
			private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600099B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1F868", Offset = "0x1D1F868", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B80 RID: 2944 RVA: 0x000041FC File Offset: 0x000023FC
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600099C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F870", Offset = "0x1D1F870", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x06000B81 RID: 2945 RVA: 0x000041FF File Offset: 0x000023FF
			[global::Cpp2ILInjected.Token(Token = "0x170001B9")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600099D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D1F8A8", Offset = "0x1D1F8A8", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000B82 RID: 2946 RVA: 0x00004202 File Offset: 0x00002402
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600099E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F8B0", Offset = "0x1D1F8B0", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_ManagedThreadId", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000B83 RID: 2947 RVA: 0x00004205 File Offset: 0x00002405
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600099F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F954", Offset = "0x1D1F954", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			// Token: 0x04000436 RID: 1078
			[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04000437 RID: 1079
			[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			// Token: 0x04000438 RID: 1080
			[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04000439 RID: 1081
			[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public ArraySliceFilter <>4__this;

			// Token: 0x0400043A RID: 1082
			[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private IEnumerable<JToken> current;

			// Token: 0x0400043B RID: 1083
			[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public IEnumerable<JToken> <>3__current;

			// Token: 0x0400043C RID: 1084
			[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private JArray <a>5__1;

			// Token: 0x0400043D RID: 1085
			[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <i>5__2;

			// Token: 0x0400043E RID: 1086
			[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int <stepCount>5__3;

			// Token: 0x0400043F RID: 1087
			[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private int <stopIndex>5__4;

			// Token: 0x04000440 RID: 1088
			[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			private bool <positiveStep>5__5;

			// Token: 0x04000441 RID: 1089
			[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
			private bool errorWhenNoMatch;

			// Token: 0x04000442 RID: 1090
			[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x56")]
			public bool <>3__errorWhenNoMatch;

			// Token: 0x04000443 RID: 1091
			[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private JToken <t>5__6;

			// Token: 0x04000444 RID: 1092
			[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private IEnumerator<JToken> <>7__wrap1;
		}
	}
}
