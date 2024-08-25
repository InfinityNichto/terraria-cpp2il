using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x20004FB")]
	public class MultiTimer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60030E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13017A4", Offset = "0x13017A4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MultiTimer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301854", Offset = "0x1301854", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MultiTimer(int ticksBetweenPrint)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301918", Offset = "0x1301918", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		public void Start()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x130193C", Offset = "0x130193C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref MultiTimer.TimerData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultiTimer.TimerData), Member = "AddTick", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(MultiTimer.TimerData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MultiTimer.TimerData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MultiTimer.TimerData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Restart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Record(string key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60030EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1301B04", Offset = "0x1301B04", Length = "0x778")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 68)]
		public bool StopAndPrint()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003ACF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _ticksBetweenPrint;

		[global::Cpp2ILInjected.Token(Token = "0x4003AD0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _ticksElapsedForPrint;

		[global::Cpp2ILInjected.Token(Token = "0x4003AD1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stopwatch _timer;

		[global::Cpp2ILInjected.Token(Token = "0x4003AD2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Dictionary<string, MultiTimer.TimerData> _timerDataMap;

		[global::Cpp2ILInjected.Token(Token = "0x20004FC")]
		private struct TimerData
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000615")]
			public double Average
			{
				[global::Cpp2ILInjected.Token(Token = "0x60030ED")]
				[global::Cpp2ILInjected.Address(RVA = "0x130227C", Offset = "0x130227C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60030EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1302288", Offset = "0x1302288", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private TimerData(double min, double max, double ticks, double total)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60030EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1301A50", Offset = "0x1301A50", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TimerData(double startTime)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60030F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1301A64", Offset = "0x1301A64", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MultiTimer), Member = "Record", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public MultiTimer.TimerData AddTick(double time)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4003AD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly double Min;

			[global::Cpp2ILInjected.Token(Token = "0x4003AD4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly double Max;

			[global::Cpp2ILInjected.Token(Token = "0x4003AD5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly double Ticks;

			[global::Cpp2ILInjected.Token(Token = "0x4003AD6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly double Total;
		}
	}
}
