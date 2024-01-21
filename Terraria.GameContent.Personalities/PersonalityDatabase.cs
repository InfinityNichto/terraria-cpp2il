using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000594")]
public class PersonalityDatabase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B35")]
	private Dictionary<int, PersonalityProfile> _personalityProfiles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006B36")]
	private PersonalityProfile _trashEntry;

	[Cpp2IlInjected.Token(Token = "0x6003C02")]
	[Cpp2IlInjected.Address(RVA = "0x1197ED4", Offset = "0x1197ED4", VA = "0x1197ED4")]
	public PersonalityDatabase()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C03")]
	[Cpp2IlInjected.Address(RVA = "0x1197FFC", Offset = "0x1197FFC", VA = "0x1197FFC")]
	public void Register(int npcId, IShopPersonalityTrait trait)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C04")]
	[Cpp2IlInjected.Address(RVA = "0x11980E4", Offset = "0x11980E4", VA = "0x11980E4")]
	public void Register(IShopPersonalityTrait trait, params int[] npcIds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C05")]
	[Cpp2IlInjected.Address(RVA = "0x1198184", Offset = "0x1198184", VA = "0x1198184")]
	public PersonalityProfile GetByNPCID(int npcId)
	{
		return null;
	}
}
