using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000422")]
public static class BufferPool
{
	[Cpp2IlInjected.Token(Token = "0x40062AA")]
	private const int SMALL_BUFFER_SIZE = 32;

	[Cpp2IlInjected.Token(Token = "0x40062AB")]
	private const int MEDIUM_BUFFER_SIZE = 256;

	[Cpp2IlInjected.Token(Token = "0x40062AC")]
	private const int LARGE_BUFFER_SIZE = 16384;

	[Cpp2IlInjected.Token(Token = "0x40062AD")]
	private static object bufferLock;

	[Cpp2IlInjected.Token(Token = "0x40062AE")]
	private static Queue<CachedBuffer> SmallBufferQueue;

	[Cpp2IlInjected.Token(Token = "0x40062AF")]
	private static Queue<CachedBuffer> MediumBufferQueue;

	[Cpp2IlInjected.Token(Token = "0x40062B0")]
	private static Queue<CachedBuffer> LargeBufferQueue;

	[Cpp2IlInjected.Token(Token = "0x60030DA")]
	[Cpp2IlInjected.Address(RVA = "0x1011BD8", Offset = "0x1011BD8", VA = "0x1011BD8")]
	public static CachedBuffer Request(int size)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030DB")]
	[Cpp2IlInjected.Address(RVA = "0x1012140", Offset = "0x1012140", VA = "0x1012140")]
	public static CachedBuffer Request(byte[] data, int offset, int size)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60030DC")]
	[Cpp2IlInjected.Address(RVA = "0x10121F0", Offset = "0x10121F0", VA = "0x10121F0")]
	public static void Recycle(CachedBuffer buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60030DD")]
	[Cpp2IlInjected.Address(RVA = "0x10123F4", Offset = "0x10123F4", VA = "0x10123F4")]
	public static void PrintBufferSizes()
	{
	}
}
