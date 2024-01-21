using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000218")]
public struct PlatformUser
{
	[Cpp2IlInjected.Token(Token = "0x20007FF")]
	public enum Platform
	{
		[Cpp2IlInjected.Token(Token = "0x4007CE6")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007CE7")]
		Stadia,
		[Cpp2IlInjected.Token(Token = "0x4007CE8")]
		XBO,
		[Cpp2IlInjected.Token(Token = "0x4007CE9")]
		PSN,
		[Cpp2IlInjected.Token(Token = "0x4007CEA")]
		Editor,
		[Cpp2IlInjected.Token(Token = "0x4007CEB")]
		Nintendo
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001A0A")]
	public string PlayerId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001A0B")]
	public Platform PlatformId;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public static PlatformUser CurrentUser
	{
		[Cpp2IlInjected.Token(Token = "0x6000F27")]
		[Cpp2IlInjected.Address(RVA = "0x10B6878", Offset = "0x10B6878", VA = "0x10B6878")]
		get
		{
			return default(PlatformUser);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000F26")]
	[Cpp2IlInjected.Address(RVA = "0x39BFF0", Offset = "0x39BFF0", VA = "0x39BFF0")]
	public PlatformUser(string id, Platform platform)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F28")]
	[Cpp2IlInjected.Address(RVA = "0x10B6944", Offset = "0x10B6944", VA = "0x10B6944")]
	public static PlatformUser[] GetFriends()
	{
		return null;
	}
}
