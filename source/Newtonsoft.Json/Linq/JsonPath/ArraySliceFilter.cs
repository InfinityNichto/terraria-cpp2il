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
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	internal class ArraySliceFilter : PathFilter
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000994")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1EE80", Offset = "0x1D1EE80", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000995")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1EF30", Offset = "0x1D1EF30", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000996")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D1EF48", Offset = "0x1D1EF48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArraySliceFilter()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400039E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int? <Start>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400039F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int? <End>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int? <Step>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000E6")]
		private sealed class <ExecuteFilter>d__12 : IEnumerable<JToken>, IEnumerable, IEnumerator<JToken>, IDisposable, IEnumerator
		{
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

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600099F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D1F954", Offset = "0x1D1F954", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArraySliceFilter.<ExecuteFilter>d__12), Member = "System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator", ReturnType = typeof(IEnumerator<JToken>))]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x40003A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private JToken <>2__current;

			[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public ArraySliceFilter <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private IEnumerable<JToken> current;

			[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public IEnumerable<JToken> <>3__current;

			[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private JArray <a>5__1;

			[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int <i>5__2;

			[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int <stepCount>5__3;

			[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private int <stopIndex>5__4;

			[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
			private bool <positiveStep>5__5;

			[global::Cpp2ILInjected.Token(Token = "0x40003AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
			private bool errorWhenNoMatch;

			[global::Cpp2ILInjected.Token(Token = "0x40003AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x56")]
			public bool <>3__errorWhenNoMatch;

			[global::Cpp2ILInjected.Token(Token = "0x40003AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private JToken <t>5__6;

			[global::Cpp2ILInjected.Token(Token = "0x40003AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private IEnumerator<JToken> <>7__wrap1;
		}
	}
}
