using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000243")]
public class TrashCan_Layout : PageControllerLayoutDefinition<TrashCan_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D2D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5880", Offset = "0x9D5880", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public TrashCan_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400180A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x400180B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout TrashGrid;

	[global::Cpp2ILInjected.Token(Token = "0x400180C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400180D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Color BackingColour;
}
