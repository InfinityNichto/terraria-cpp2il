using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000712")]
public class MultiTimer
{
	[Cpp2IlInjected.Token(Token = "0x2000AC7")]
	private struct TimerData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008F73")]
		public readonly double Min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008F74")]
		public readonly double Max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008F75")]
		public readonly double Ticks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008F76")]
		public readonly double Total;

		[Cpp2IlInjected.Token(Token = "0x1700090B")]
		public double Average
		{
			[Cpp2IlInjected.Token(Token = "0x60052FB")]
			[Cpp2IlInjected.Address(RVA = "0x39A820", Offset = "0x39A820", VA = "0x39A820")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60052FC")]
		[Cpp2IlInjected.Address(RVA = "0x39A834", Offset = "0x39A834", VA = "0x39A834")]
		private TimerData(double min, double max, double ticks, double total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052FD")]
		[Cpp2IlInjected.Address(RVA = "0x39A85C", Offset = "0x39A85C", VA = "0x39A85C")]
		public TimerData(double startTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052FE")]
		[Cpp2IlInjected.Address(RVA = "0x39A884", Offset = "0x39A884", VA = "0x39A884")]
		public TimerData AddTick(double time)
		{
			return default(TimerData);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400714A")]
	private readonly int _ticksBetweenPrint;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400714B")]
	private int _ticksElapsedForPrint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400714C")]
	private readonly Stopwatch _timer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400714D")]
	private readonly Dictionary<string, TimerData> _timerDataMap;

	[Cpp2IlInjected.Token(Token = "0x6004622")]
	[Cpp2IlInjected.Address(RVA = "0xF96180", Offset = "0xF96180", VA = "0xF96180")]
	public MultiTimer(int ticksBetweenPrint = 100)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004623")]
	[Cpp2IlInjected.Address(RVA = "0xF96230", Offset = "0xF96230", VA = "0xF96230")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004624")]
	[Cpp2IlInjected.Address(RVA = "0xF96258", Offset = "0xF96258", VA = "0xF96258")]
	public void Record(string key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004625")]
	[Cpp2IlInjected.Address(RVA = "0xF96508", Offset = "0xF96508", VA = "0xF96508")]
	public bool StopAndPrint()
	{
		return default(bool);
	}
}
