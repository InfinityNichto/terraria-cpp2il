using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x200049A")]
public class LegacyNetBufferPool
{
	[Cpp2IlInjected.Token(Token = "0x400653F")]
	private const int SMALL_BUFFER_SIZE = 256;

	[Cpp2IlInjected.Token(Token = "0x4006540")]
	private const int MEDIUM_BUFFER_SIZE = 1024;

	[Cpp2IlInjected.Token(Token = "0x4006541")]
	private const int LARGE_BUFFER_SIZE = 16384;

	[Cpp2IlInjected.Token(Token = "0x4006542")]
	private static object bufferLock;

	[Cpp2IlInjected.Token(Token = "0x4006543")]
	private static Queue<byte[]> _smallBufferQueue;

	[Cpp2IlInjected.Token(Token = "0x4006544")]
	private static Queue<byte[]> _mediumBufferQueue;

	[Cpp2IlInjected.Token(Token = "0x4006545")]
	private static Queue<byte[]> _largeBufferQueue;

	[Cpp2IlInjected.Token(Token = "0x4006546")]
	private static int _smallBufferCount;

	[Cpp2IlInjected.Token(Token = "0x4006547")]
	private static int _mediumBufferCount;

	[Cpp2IlInjected.Token(Token = "0x4006548")]
	private static int _largeBufferCount;

	[Cpp2IlInjected.Token(Token = "0x4006549")]
	private static int _customBufferCount;

	[Cpp2IlInjected.Token(Token = "0x600338A")]
	[Cpp2IlInjected.Address(RVA = "0x14295DC", Offset = "0x14295DC", VA = "0x14295DC")]
	public static byte[] RequestBuffer(int size)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600338B")]
	[Cpp2IlInjected.Address(RVA = "0x14299DC", Offset = "0x14299DC", VA = "0x14299DC")]
	public static byte[] RequestBuffer(byte[] data, int offset, int size)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600338C")]
	[Cpp2IlInjected.Address(RVA = "0x1429A8C", Offset = "0x1429A8C", VA = "0x1429A8C")]
	public static void ReturnBuffer(byte[] buffer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600338D")]
	[Cpp2IlInjected.Address(RVA = "0x1429C80", Offset = "0x1429C80", VA = "0x1429C80")]
	public static void DisplayBufferSizes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600338E")]
	[Cpp2IlInjected.Address(RVA = "0x142A268", Offset = "0x142A268", VA = "0x142A268")]
	public static void PrintBufferSizes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600338F")]
	[Cpp2IlInjected.Address(RVA = "0x142A828", Offset = "0x142A828", VA = "0x142A828")]
	public LegacyNetBufferPool()
	{
	}
}
