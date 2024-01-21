using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x200039E")]
public class WorkshopTagOption
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031E9")]
	public readonly string NameKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031EA")]
	public readonly string InternalNameForAPIs;

	[Cpp2IlInjected.Token(Token = "0x6002DFE")]
	[Cpp2IlInjected.Address(RVA = "0x14DF808", Offset = "0x14DF808", VA = "0x14DF808")]
	public WorkshopTagOption(string nameKey, string internalName)
	{
	}
}
