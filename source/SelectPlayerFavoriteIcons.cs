using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200020D")]
[Serializable]
public class SelectPlayerFavoriteIcons
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CB9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFC00", Offset = "0x9CFC00", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public SelectPlayerFavoriteIcons()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001395")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	[global::Cpp2ILInjected.Token(Token = "0x4001396")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout Disabled;
}
