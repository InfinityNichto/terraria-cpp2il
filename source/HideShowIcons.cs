using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001D3")]
[Serializable]
public class HideShowIcons
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C09")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6498", Offset = "0x9B6498", Length = "0x164")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public HideShowIcons()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40010A9")]
	public static FavoriteIcons Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40010AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	[global::Cpp2ILInjected.Token(Token = "0x40010AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout NormalHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x40010AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Texture_Layout Active;

	[global::Cpp2ILInjected.Token(Token = "0x40010AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Texture_Layout ActiveHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x40010AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout MinecartNormal;

	[global::Cpp2ILInjected.Token(Token = "0x40010AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Texture_Layout MinecartNormalHighlight;

	[global::Cpp2ILInjected.Token(Token = "0x40010B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Texture_Layout MinecartActive;

	[global::Cpp2ILInjected.Token(Token = "0x40010B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Texture_Layout MinecartActiveHighlight;
}
