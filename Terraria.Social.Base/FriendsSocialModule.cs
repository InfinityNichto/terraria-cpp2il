using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000392")]
public abstract class FriendsSocialModule : ISocialModule
{
	[Cpp2IlInjected.Token(Token = "0x6002DAF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract string GetUsername();

	[Cpp2IlInjected.Token(Token = "0x6002DB0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void OpenJoinInterface();

	[Cpp2IlInjected.Token(Token = "0x6002DB1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void Initialize();

	[Cpp2IlInjected.Token(Token = "0x6002DB2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002DB3")]
	[Cpp2IlInjected.Address(RVA = "0x14DFC90", Offset = "0x14DFC90", VA = "0x14DFC90")]
	protected FriendsSocialModule()
	{
	}
}
