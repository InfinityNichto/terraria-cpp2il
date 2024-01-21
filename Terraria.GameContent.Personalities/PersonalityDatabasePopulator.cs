using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x2000595")]
public class PersonalityDatabasePopulator
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B37")]
	private PersonalityDatabase _currentDatabase;

	[Cpp2IlInjected.Token(Token = "0x6003C06")]
	[Cpp2IlInjected.Address(RVA = "0x119820C", Offset = "0x119820C", VA = "0x119820C")]
	public void Populate(PersonalityDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C07")]
	[Cpp2IlInjected.Address(RVA = "0x1198214", Offset = "0x1198214", VA = "0x1198214")]
	private void Populate_BiomePreferences(PersonalityDatabase database)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003C08")]
	[Cpp2IlInjected.Address(RVA = "0x1198A6C", Offset = "0x1198A6C", VA = "0x1198A6C")]
	public PersonalityDatabasePopulator()
	{
	}
}
