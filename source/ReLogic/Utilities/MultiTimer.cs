using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace ReLogic.Utilities
{
	// Token: 0x0200070F RID: 1807
	[global::Cpp2ILInjected.Token(Token = "0x2000B03")]
	public class MultiTimer
	{
		// Token: 0x060045E3 RID: 17891 RVA: 0x0002E81D File Offset: 0x0002CA1D
		[global::Cpp2ILInjected.Token(Token = "0x600527B")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E2A0", Offset = "0x93E2A0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FrameSkipTest), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, MultiTimer.TimerData>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MultiTimer(int ticksBetweenPrint = 100)
		{
			throw null;
		}

		// Token: 0x060045E4 RID: 17892 RVA: 0x0002E820 File Offset: 0x0002CA20
		[global::Cpp2ILInjected.Token(Token = "0x600527C")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E35C", Offset = "0x93E35C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FrameSkipTest), Member = "UpdateServerTest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		public void Start()
		{
			throw null;
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x0002E823 File Offset: 0x0002CA23
		[global::Cpp2ILInjected.Token(Token = "0x600527D")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E380", Offset = "0x93E380", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FrameSkipTest), Member = "UpdateServerTest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Record(string key)
		{
			throw null;
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x0002E826 File Offset: 0x0002CA26
		[global::Cpp2ILInjected.Token(Token = "0x600527E")]
		[global::Cpp2ILInjected.Address(RVA = "0x93E560", Offset = "0x93E560", Length = "0x784")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FrameSkipTest), Member = "UpdateServerTest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		public bool StopAndPrint()
		{
			throw null;
		}

		// Token: 0x04007149 RID: 29001
		[global::Cpp2ILInjected.Token(Token = "0x4008AC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly int _ticksBetweenPrint;

		// Token: 0x0400714A RID: 29002
		[global::Cpp2ILInjected.Token(Token = "0x4008AC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _ticksElapsedForPrint;

		// Token: 0x0400714B RID: 29003
		[global::Cpp2ILInjected.Token(Token = "0x4008AC5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Stopwatch _timer;

		// Token: 0x0400714C RID: 29004
		[global::Cpp2ILInjected.Token(Token = "0x4008AC6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, MultiTimer.TimerData> _timerDataMap;

		// Token: 0x02000AD0 RID: 2768
		[global::Cpp2ILInjected.Token(Token = "0x2000B04")]
		private struct TimerData
		{
			// Token: 0x17000909 RID: 2313
			// (get) Token: 0x060052C4 RID: 21188 RVA: 0x00030992 File Offset: 0x0002EB92
			[global::Cpp2ILInjected.Token(Token = "0x170008DF")]
			public double Average
			{
				[global::Cpp2ILInjected.Token(Token = "0x600527F")]
				[global::Cpp2ILInjected.Address(RVA = "0x93ECE4", Offset = "0x93ECE4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060052C5 RID: 21189 RVA: 0x00030995 File Offset: 0x0002EB95
			[global::Cpp2ILInjected.Token(Token = "0x6005280")]
			[global::Cpp2ILInjected.Address(RVA = "0x93ECF0", Offset = "0x93ECF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private TimerData(double min, double max, double ticks, double total)
			{
				throw null;
			}

			// Token: 0x060052C6 RID: 21190 RVA: 0x00030998 File Offset: 0x0002EB98
			[global::Cpp2ILInjected.Token(Token = "0x6005281")]
			[global::Cpp2ILInjected.Address(RVA = "0x93E4AC", Offset = "0x93E4AC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public TimerData(double startTime)
			{
				throw null;
			}

			// Token: 0x060052C7 RID: 21191 RVA: 0x0003099B File Offset: 0x0002EB9B
			[global::Cpp2ILInjected.Token(Token = "0x6005282")]
			[global::Cpp2ILInjected.Address(RVA = "0x93E4C0", Offset = "0x93E4C0", Length = "0xA0")]
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

			// Token: 0x04008F86 RID: 36742
			[global::Cpp2ILInjected.Token(Token = "0x4008AC7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly double Min;

			// Token: 0x04008F87 RID: 36743
			[global::Cpp2ILInjected.Token(Token = "0x4008AC8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public readonly double Max;

			// Token: 0x04008F88 RID: 36744
			[global::Cpp2ILInjected.Token(Token = "0x4008AC9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly double Ticks;

			// Token: 0x04008F89 RID: 36745
			[global::Cpp2ILInjected.Token(Token = "0x4008ACA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly double Total;
		}
	}
}
