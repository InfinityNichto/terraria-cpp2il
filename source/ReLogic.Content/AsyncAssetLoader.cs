using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace ReLogic.Content;

[Cpp2IlInjected.Token(Token = "0x2000748")]
public class AsyncAssetLoader
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400736E")]
	private readonly AssetReaderCollection _readers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400736F")]
	private readonly ConcurrentQueue<Action> _pendingCallbacks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007370")]
	private readonly ConcurrentQueue<Action> _pendingDelayedCallbacks;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007371")]
	private readonly HashSet<Type> _delayedLoadTypes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4007372")]
	private readonly int _maxCreationsPerTransfer;

	[Cpp2IlInjected.Token(Token = "0x17000816")]
	public int Remaining
	{
		[Cpp2IlInjected.Token(Token = "0x6004782")]
		[Cpp2IlInjected.Address(RVA = "0x10BE9F4", Offset = "0x10BE9F4", VA = "0x10BE9F4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6004783")]
		[Cpp2IlInjected.Address(RVA = "0x10BE9FC", Offset = "0x10BE9FC", VA = "0x10BE9FC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000817")]
	internal int AssetsReadyForTransfer
	{
		[Cpp2IlInjected.Token(Token = "0x6004784")]
		[Cpp2IlInjected.Address(RVA = "0x10BEA04", Offset = "0x10BEA04", VA = "0x10BEA04")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004785")]
	[Cpp2IlInjected.Address(RVA = "0x10BEA74", Offset = "0x10BEA74", VA = "0x10BEA74")]
	public AsyncAssetLoader(AssetReaderCollection readers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004786")]
	[Cpp2IlInjected.Address(RVA = "0x10BEB50", Offset = "0x10BEB50", VA = "0x10BEB50")]
	public AsyncAssetLoader(AssetReaderCollection readers, int maxCreationsPerTransfer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004787")]
	[Cpp2IlInjected.Address(RVA = "0x10BDDC8", Offset = "0x10BDDC8", VA = "0x10BDDC8")]
	public void TransferCompleted()
	{
	}
}
