using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200000F")]
public struct FloatArray_2
{
	[global::Cpp2ILInjected.Token(Token = "0x17000017")]
	public float this[int index]
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBA60", Offset = "0x6FBA60", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBA70", Offset = "0x6FBA70", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000018")]
	public int Length
	{
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBA80", Offset = "0x6FBA80", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000021")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	private float val0;

	[global::Cpp2ILInjected.Token(Token = "0x4000022")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
	private float val1;
}
