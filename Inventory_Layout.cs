using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200015C")]
public class Inventory_Layout : PageControllerLayoutDefinition<Inventory_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D33")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000D34")]
	public float ItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D35")]
	public float ItemHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000D36")]
	public float ScaleSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000D37")]
	public ItemGrid_Layout HotbarGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000D38")]
	public ItemGrid_Layout HorizontalHotbarGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000D39")]
	public ItemGrid_Layout ItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000D3A")]
	public ItemGrid_Layout HorizontalItemGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000D3B")]
	public TransactionButton_Layout Favorite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000D3C")]
	public FavoriteIcons FavoriteIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000D3D")]
	public Vector2 BindingOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000D3E")]
	public float BindingScale;

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x11788D8", Offset = "0x11788D8", VA = "0x11788D8")]
	public Inventory_Layout()
	{
	}
}
