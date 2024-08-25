using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x20001E0")]
[Serializable]
public class Inventory_Layout : PageControllerLayoutDefinition<Inventory_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C46")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAD04", Offset = "0x9CAD04", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public Inventory_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400112D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400112E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float ItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x400112F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ItemHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001130")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float ScaleSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x4001131")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout HotbarGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001132")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ItemGrid_Layout HorizontalHotbarGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001133")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout ItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001134")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout HorizontalItemGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001135")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x4001136")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public FavoriteIcons FavoriteIcons;

	[global::Cpp2ILInjected.Token(Token = "0x4001137")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Vector2 BindingOffset;

	[global::Cpp2ILInjected.Token(Token = "0x4001138")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public float BindingScale;
}
