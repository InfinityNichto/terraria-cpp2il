using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000190")]
public class Ammo_Layout : PageControllerLayoutDefinition<Ammo_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B4D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB9F8", Offset = "0x9AB9F8", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Ammo_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000C27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000C28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000C2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout AmmoGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000C2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float ItemScale_Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000C2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float ItemHighlightScale_Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000C2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout AmmoGrid_Collapsed;

	[global::Cpp2ILInjected.Token(Token = "0x4000C2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public AnimationCurve ItemDragPulseScale;
}
