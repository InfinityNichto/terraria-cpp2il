using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200014F")]
public class HideShowIcons
{
	[Cpp2IlInjected.Token(Token = "0x4000CAF")]
	public static FavoriteIcons Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000CB0")]
	public Texture_Layout Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000CB1")]
	public Texture_Layout NormalHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000CB2")]
	public Texture_Layout Active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000CB3")]
	public Texture_Layout ActiveHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000CB4")]
	public Texture_Layout MinecartNormal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000CB5")]
	public Texture_Layout MinecartNormalHighlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000CB6")]
	public Texture_Layout MinecartActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000CB7")]
	public Texture_Layout MinecartActiveHighlight;

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x116EEE0", Offset = "0x116EEE0", VA = "0x116EEE0")]
	public HideShowIcons()
	{
	}
}
