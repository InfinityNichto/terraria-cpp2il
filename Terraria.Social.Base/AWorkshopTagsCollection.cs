using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x200038F")]
public abstract class AWorkshopTagsCollection
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031D2")]
	public readonly List<WorkshopTagOption> WorldTags;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031D3")]
	public readonly List<WorkshopTagOption> ResourcePackTags;

	[Cpp2IlInjected.Token(Token = "0x6002D93")]
	[Cpp2IlInjected.Address(RVA = "0x14DF774", Offset = "0x14DF774", VA = "0x14DF774")]
	protected void AddWorldTag(string tagNameKey, string tagInternalName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D94")]
	[Cpp2IlInjected.Address(RVA = "0x14DF830", Offset = "0x14DF830", VA = "0x14DF830")]
	protected void AddResourcePackTag(string tagNameKey, string tagInternalName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D95")]
	[Cpp2IlInjected.Address(RVA = "0x14DF8C4", Offset = "0x14DF8C4", VA = "0x14DF8C4")]
	protected AWorkshopTagsCollection()
	{
	}
}
