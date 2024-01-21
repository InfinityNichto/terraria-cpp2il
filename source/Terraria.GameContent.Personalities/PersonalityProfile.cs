using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.GameContent.Personalities;

[Cpp2IlInjected.Token(Token = "0x20005A2")]
public class PersonalityProfile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B39")]
	public List<IShopPersonalityTrait> ShopModifiers;

	[Cpp2IlInjected.Token(Token = "0x6003C23")]
	[Cpp2IlInjected.Address(RVA = "0x1197F78", Offset = "0x1197F78", VA = "0x1197F78")]
	public PersonalityProfile()
	{
	}
}
