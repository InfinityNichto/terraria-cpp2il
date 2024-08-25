using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001E1")]
[Serializable]
public class FavoriteIcons
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C47")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAD68", Offset = "0x9CAD68", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public FavoriteIcons()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001139")]
	public static FavoriteIcons Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400113A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	[global::Cpp2ILInjected.Token(Token = "0x400113B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout NormalSelected;

	[global::Cpp2ILInjected.Token(Token = "0x400113C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Texture_Layout Favorite;

	[global::Cpp2ILInjected.Token(Token = "0x400113D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Texture_Layout FavoriteSelected;

	[global::Cpp2ILInjected.Token(Token = "0x400113E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout Disabled;
}
