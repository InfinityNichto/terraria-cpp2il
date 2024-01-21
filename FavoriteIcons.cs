using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200015D")]
public class FavoriteIcons
{
	[Cpp2IlInjected.Token(Token = "0x4000D3F")]
	public static FavoriteIcons Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000D40")]
	public Texture_Layout Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000D41")]
	public Texture_Layout NormalSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D42")]
	public Texture_Layout Favorite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000D43")]
	public Texture_Layout FavoriteSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D44")]
	public Texture_Layout Disabled;

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x20D292C", Offset = "0x20D292C", VA = "0x20D292C")]
	public FavoriteIcons()
	{
	}
}
