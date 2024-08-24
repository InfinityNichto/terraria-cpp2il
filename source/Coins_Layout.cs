using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000125 RID: 293
[global::Cpp2ILInjected.Token(Token = "0x200019D")]
public class Coins_Layout : PageControllerLayoutDefinition<Coins_Layout>
{
	// Token: 0x06000A5A RID: 2650 RVA: 0x00023A53 File Offset: 0x00021C53
	[global::Cpp2ILInjected.Token(Token = "0x6000B67")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC8B0", Offset = "0x9AC8B0", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Coins_Layout()
	{
		throw null;
	}

	// Token: 0x040009E3 RID: 2531
	[global::Cpp2ILInjected.Token(Token = "0x4000D05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	// Token: 0x040009E4 RID: 2532
	[global::Cpp2ILInjected.Token(Token = "0x4000D06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	// Token: 0x040009E5 RID: 2533
	[global::Cpp2ILInjected.Token(Token = "0x4000D07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	// Token: 0x040009E6 RID: 2534
	[global::Cpp2ILInjected.Token(Token = "0x4000D08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout CoinGrid;

	// Token: 0x040009E7 RID: 2535
	[global::Cpp2ILInjected.Token(Token = "0x4000D09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemScale_Collapsed;

	// Token: 0x040009E8 RID: 2536
	[global::Cpp2ILInjected.Token(Token = "0x4000D0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float ItemHighlightScale_Collapsed;

	// Token: 0x040009E9 RID: 2537
	[global::Cpp2ILInjected.Token(Token = "0x4000D0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout CoinGrid_Collapsed;

	// Token: 0x040009EA RID: 2538
	[global::Cpp2ILInjected.Token(Token = "0x4000D0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public AnimationCurve ItemDragPulseScale;
}
