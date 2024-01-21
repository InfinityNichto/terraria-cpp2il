using System.Collections.Generic;
using Cpp2IlInjected;

namespace Telepathy;

[Cpp2IlInjected.Token(Token = "0x200025B")]
public class SafeQueue<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C40")]
	private Queue<T> queue;

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x600114E")]
		[Cpp2IlInjected.Address(RVA = "0x163B630", Offset = "0x163B630", VA = "0x163B630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600114F")]
	[Cpp2IlInjected.Address(RVA = "0x163B6D8", Offset = "0x163B6D8", VA = "0x163B6D8")]
	public void Enqueue(T item)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001150")]
	[Cpp2IlInjected.Address(RVA = "0x163B77C", Offset = "0x163B77C", VA = "0x163B77C")]
	public bool TryDequeue(out T result)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001151")]
	[Cpp2IlInjected.Address(RVA = "0x163B860", Offset = "0x163B860", VA = "0x163B860")]
	public bool TryDequeueAll(out T[] result)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001152")]
	[Cpp2IlInjected.Address(RVA = "0x163B93C", Offset = "0x163B93C", VA = "0x163B93C")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001153")]
	[Cpp2IlInjected.Address(RVA = "0x163B9D8", Offset = "0x163B9D8", VA = "0x163B9D8")]
	public SafeQueue()
	{
	}
}
