using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000206")]
[Serializable]
public class MultiplayerLobby
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CAB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF628", Offset = "0x9CF628", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public MultiplayerLobby()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400131B")]
	public static FavoriteIcons Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400131C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	[global::Cpp2ILInjected.Token(Token = "0x400131D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout Disabled;
}
