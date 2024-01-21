using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000184")]
public class SelectPlayerFavoriteIcons
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000F51")]
	public Texture_Layout Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000F52")]
	public Texture_Layout Disabled;

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0xFA5BE8", Offset = "0xFA5BE8", VA = "0xFA5BE8")]
	public SelectPlayerFavoriteIcons()
	{
	}
}
