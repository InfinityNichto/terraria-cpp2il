using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class AutoPinner : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private GCHandle _pinnedArray;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x11FF98C", Offset = "0x11FF98C", VA = "0x11FF98C")]
	public AutoPinner(object obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x11FF9BC", Offset = "0x11FF9BC", VA = "0x11FF9BC")]
	public static implicit operator IntPtr(AutoPinner ap)
	{
		return default(IntPtr);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x11FF9C8", Offset = "0x11FF9C8", VA = "0x11FF9C8", Slot = "4")]
	public void Dispose()
	{
	}
}
