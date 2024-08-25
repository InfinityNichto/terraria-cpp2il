using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000197")]
public class CachedGridLayoutSettings
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B5D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC180", Offset = "0x9AC180", Length = "0x1E8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	public bool Dirty(ItemGrid_Layout layout)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B5E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC368", Offset = "0x9AC368", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = "GetHeartsRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = "GetManaRegion", ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Cache(ItemGrid_Layout layout)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B5F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC41C", Offset = "0x9AC41C", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHearts), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMana), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public CachedGridLayoutSettings()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000CB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool Horizontal;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public ItemGrid_Layout.ReorderStyle Reorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int ItemCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000CB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int ItemLineCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000CBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Vector2 PickingBorder;

	[global::Cpp2ILInjected.Token(Token = "0x4000CBB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Vector2 PickingOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4000CBC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Vector2 ExtraElementSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000CBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ControlAnchor.ControlId FirstAnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4000CBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public LayoutCalculator.AnchorType FirstItemAnchor;

	[global::Cpp2ILInjected.Token(Token = "0x4000CBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Vector2 FirstItemLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public int ScreenWidth;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public int ScreenHeight;
}
