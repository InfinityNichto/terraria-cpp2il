using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;

namespace ReLogic.Threading;

[Cpp2IlInjected.Token(Token = "0x200071B")]
public static class FastParallel
{
	[Cpp2IlInjected.Token(Token = "0x2000ACC")]
	private class RangeTask
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008F7F")]
		private readonly ParallelForAction _action;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008F80")]
		private readonly int _fromInclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008F81")]
		private readonly int _toExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008F82")]
		private readonly object _context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008F83")]
		private readonly CountdownEvent _countdown;

		[Cpp2IlInjected.Token(Token = "0x600530A")]
		[Cpp2IlInjected.Address(RVA = "0xF95AD8", Offset = "0xF95AD8", VA = "0xF95AD8")]
		public RangeTask(ParallelForAction action, int fromInclusive, int toExclusive, object context, CountdownEvent countdown)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600530B")]
		[Cpp2IlInjected.Address(RVA = "0xF95A98", Offset = "0xF95A98", VA = "0xF95A98")]
		public void Invoke()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007F0")]
	public static bool ForceTasksOnCallingThread
	{
		[Cpp2IlInjected.Token(Token = "0x60046AA")]
		[Cpp2IlInjected.Address(RVA = "0xF955C4", Offset = "0xF955C4", VA = "0xF955C4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60046AB")]
		[Cpp2IlInjected.Address(RVA = "0xF9563C", Offset = "0xF9563C", VA = "0xF9563C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60046A9")]
	[Cpp2IlInjected.Address(RVA = "0xF95548", Offset = "0xF95548", VA = "0xF95548")]
	static FastParallel()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046AC")]
	[Cpp2IlInjected.Address(RVA = "0xF956B8", Offset = "0xF956B8", VA = "0xF956B8")]
	public static void For(int fromInclusive, int toExclusive, ParallelForAction callback, [Optional] object context)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046AD")]
	[Cpp2IlInjected.Address(RVA = "0xF959C4", Offset = "0xF959C4", VA = "0xF959C4")]
	private static void InvokeTask(object context)
	{
	}
}
