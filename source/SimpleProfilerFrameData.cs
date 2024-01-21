using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200003B")]
public class SimpleProfilerFrameData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public long Overheads;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public long FrameTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly int[] CallCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly long[] ExececutionTime;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x105FF64", Offset = "0x105FF64", VA = "0x105FF64")]
	public SimpleProfilerFrameData(int size)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1060328", Offset = "0x1060328", VA = "0x1060328")]
	public void Reset()
	{
	}
}
