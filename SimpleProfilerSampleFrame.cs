using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200003C")]
public class SimpleProfilerSampleFrame
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public SimpleProfilerSampleFrame Next;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public int Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public DateTime StartTime;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x10600A8", Offset = "0x10600A8", VA = "0x10600A8")]
	public SimpleProfilerSampleFrame()
	{
	}
}
