using System;
using System.Collections.Concurrent;
using System.Threading;
using Cpp2IlInjected;

namespace ReLogic.OS.Windows;

[Cpp2IlInjected.Token(Token = "0x2000729")]
internal class STATaskInvoker : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400717C")]
	private static STATaskInvoker Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400717D")]
	private Thread _staThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400717E")]
	private bool _shouldThreadContinue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400717F")]
	private BlockingCollection<Action> _staTasks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007180")]
	private object _taskInvokeLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007181")]
	private object _taskCompletionLock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007182")]
	private bool disposedValue;

	[Cpp2IlInjected.Token(Token = "0x60046DC")]
	[Cpp2IlInjected.Address(RVA = "0xF92728", Offset = "0xF92728", VA = "0xF92728")]
	private STATaskInvoker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046DD")]
	[Cpp2IlInjected.Address(RVA = "0xF9288C", Offset = "0xF9288C", VA = "0xF9288C")]
	public static void Invoke(Action action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046DE")]
	[Cpp2IlInjected.Address(RVA = "0x15ADA00", Offset = "0x15ADA00", VA = "0x15ADA00")]
	public static T Invoke<T>(Func<T> action)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60046DF")]
	[Cpp2IlInjected.Address(RVA = "0xF92920", Offset = "0xF92920", VA = "0xF92920")]
	private void InvokeAndWait(Action action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046E0")]
	[Cpp2IlInjected.Address(RVA = "0xF92A78", Offset = "0xF92A78", VA = "0xF92A78")]
	private void TaskThreadStart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046E1")]
	[Cpp2IlInjected.Address(RVA = "0xF92BAC", Offset = "0xF92BAC", VA = "0xF92BAC")]
	private void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046E2")]
	[Cpp2IlInjected.Address(RVA = "0xF92C34", Offset = "0xF92C34", VA = "0xF92C34", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046E3")]
	[Cpp2IlInjected.Address(RVA = "0xF92CC8", Offset = "0xF92CC8", VA = "0xF92CC8", Slot = "4")]
	public void Dispose()
	{
	}
}
