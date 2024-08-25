using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x200019D")]
public class Coins_Layout : PageControllerLayoutDefinition<Coins_Layout>
{
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

	[global::Cpp2ILInjected.Token(Token = "0x4000D05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000D06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000D07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000D08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout CoinGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000D09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemScale_Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000D0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float ItemHighlightScale_Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000D0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout CoinGrid_Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000D0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public AnimationCurve ItemDragPulseScale;
}
