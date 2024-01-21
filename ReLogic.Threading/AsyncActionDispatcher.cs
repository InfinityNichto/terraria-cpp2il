using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;

namespace ReLogic.Threading;

[Cpp2IlInjected.Token(Token = "0x2000719")]
public class AsyncActionDispatcher : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007162")]
	private Thread _actionThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007163")]
	private readonly BlockingCollection<Action> _actionQueue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007164")]
	private readonly CancellationTokenSource _threadCancellation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007165")]
	private bool _isRunning;

	[Cpp2IlInjected.Token(Token = "0x170007ED")]
	public int ActionsRemaining
	{
		[Cpp2IlInjected.Token(Token = "0x600469A")]
		[Cpp2IlInjected.Address(RVA = "0xF94FEC", Offset = "0xF94FEC", VA = "0xF94FEC")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007EE")]
	public bool IsDisposed
	{
		[Cpp2IlInjected.Token(Token = "0x600469B")]
		[Cpp2IlInjected.Address(RVA = "0xF95048", Offset = "0xF95048", VA = "0xF95048")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600469C")]
		[Cpp2IlInjected.Address(RVA = "0xF95050", Offset = "0xF95050", VA = "0xF95050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007EF")]
	public bool IsRunning
	{
		[Cpp2IlInjected.Token(Token = "0x600469D")]
		[Cpp2IlInjected.Address(RVA = "0xF95058", Offset = "0xF95058", VA = "0xF95058")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600469E")]
	[Cpp2IlInjected.Address(RVA = "0xF95070", Offset = "0xF95070", VA = "0xF95070")]
	public void Queue(Action action)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600469F")]
	[Cpp2IlInjected.Address(RVA = "0xF950D4", Offset = "0xF950D4", VA = "0xF950D4")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046A0")]
	[Cpp2IlInjected.Address(RVA = "0xF9521C", Offset = "0xF9521C", VA = "0xF9521C")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046A1")]
	[Cpp2IlInjected.Address(RVA = "0xF952E4", Offset = "0xF952E4", VA = "0xF952E4")]
	private void LoaderThreadStart()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046A2")]
	[Cpp2IlInjected.Address(RVA = "0xF953F0", Offset = "0xF953F0", VA = "0xF953F0", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046A3")]
	[Cpp2IlInjected.Address(RVA = "0xF9548C", Offset = "0xF9548C", VA = "0xF9548C", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60046A4")]
	[Cpp2IlInjected.Address(RVA = "0xF954A0", Offset = "0xF954A0", VA = "0xF954A0")]
	public AsyncActionDispatcher()
	{
	}
}
