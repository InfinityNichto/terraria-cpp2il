using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200017D")]
public class MultiplayerLobby
{
	[Cpp2IlInjected.Token(Token = "0x4000ED7")]
	public static FavoriteIcons Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000ED8")]
	public Texture_Layout Normal;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000ED9")]
	public Texture_Layout Disabled;

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x10B27E0", Offset = "0x10B27E0", VA = "0x10B27E0")]
	public MultiplayerLobby()
	{
	}
}
