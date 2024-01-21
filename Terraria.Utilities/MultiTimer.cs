using System.Collections.Generic;
using System.Diagnostics;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000379")]
public class MultiTimer
{
	[Cpp2IlInjected.Token(Token = "0x20008CE")]
	private struct TimerData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40080D4")]
		public readonly double Min;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40080D5")]
		public readonly double Max;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080D6")]
		public readonly double Ticks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40080D7")]
		public readonly double Total;

		[Cpp2IlInjected.Token(Token = "0x1700088E")]
		public double Average
		{
			[Cpp2IlInjected.Token(Token = "0x6004BF8")]
			[Cpp2IlInjected.Address(RVA = "0x39C7CC", Offset = "0x39C7CC", VA = "0x39C7CC")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004BF9")]
		[Cpp2IlInjected.Address(RVA = "0x39C7E0", Offset = "0x39C7E0", VA = "0x39C7E0")]
		private TimerData(double min, double max, double ticks, double total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BFA")]
		[Cpp2IlInjected.Address(RVA = "0x39C808", Offset = "0x39C808", VA = "0x39C808")]
		public TimerData(double startTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004BFB")]
		[Cpp2IlInjected.Address(RVA = "0x39C830", Offset = "0x39C830", VA = "0x39C830")]
		public TimerData AddTick(double time)
		{
			return default(TimerData);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003190")]
	private int _ticksBetweenPrint;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003191")]
	private int _ticksElapsedForPrint;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003192")]
	private Stopwatch _timer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4003193")]
	private Dictionary<string, TimerData> _timerDataMap;

	[Cpp2IlInjected.Token(Token = "0x6002D0D")]
	[Cpp2IlInjected.Address(RVA = "0x10DBC14", Offset = "0x10DBC14", VA = "0x10DBC14")]
	public MultiTimer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D0E")]
	[Cpp2IlInjected.Address(RVA = "0x10DBCC4", Offset = "0x10DBCC4", VA = "0x10DBCC4")]
	public MultiTimer(int ticksBetweenPrint)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D0F")]
	[Cpp2IlInjected.Address(RVA = "0x10DBD7C", Offset = "0x10DBD7C", VA = "0x10DBD7C")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D10")]
	[Cpp2IlInjected.Address(RVA = "0x10DBDA4", Offset = "0x10DBDA4", VA = "0x10DBDA4")]
	public void Record(string key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D11")]
	[Cpp2IlInjected.Address(RVA = "0x10DC03C", Offset = "0x10DC03C", VA = "0x10DC03C")]
	public bool StopAndPrint()
	{
		return default(bool);
	}
}
