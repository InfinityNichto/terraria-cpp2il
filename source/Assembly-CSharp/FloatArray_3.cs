using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000010 RID: 16
[global::Cpp2ILInjected.Token(Token = "0x2000010")]
public struct FloatArray_3
{
	// Token: 0x17000019 RID: 25
	[global::Cpp2ILInjected.Token(Token = "0x17000019")]
	public float this[int index]
	{
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBA88", Offset = "0x6FBA88", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2814)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBAAC", Offset = "0x6FBAAC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1239)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00021C74 File Offset: 0x0001FE74
	[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
	public int Length
	{
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBAD0", Offset = "0x6FBAD0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04000023 RID: 35
	[global::Cpp2ILInjected.Token(Token = "0x4000023")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	private float val0;

	// Token: 0x04000024 RID: 36
	[global::Cpp2ILInjected.Token(Token = "0x4000024")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
	private float val1;

	// Token: 0x04000025 RID: 37
	[global::Cpp2ILInjected.Token(Token = "0x4000025")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
	private float val2;
}
