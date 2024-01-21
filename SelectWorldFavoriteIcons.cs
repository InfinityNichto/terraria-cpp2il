using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class SelectWorldFavoriteIcons
{
	[Cpp2IlInjected.Token(Token = "0x40010FC")]
	public static FavoriteIcons Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40010FD")]
	public Texture_Layout Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40010FE")]
	public Texture_Layout Disabled;

	[Cpp2IlInjected.Token(Token = "0x6000BD9")]
	[Cpp2IlInjected.Address(RVA = "0xFA5C9C", Offset = "0xFA5C9C", VA = "0xFA5C9C")]
	public SelectWorldFavoriteIcons()
	{
	}
}
