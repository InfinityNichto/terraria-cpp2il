using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005E8")]
public class ActionStalagtite : GenAction
{
	[Cpp2IlInjected.Token(Token = "0x6003D61")]
	[Cpp2IlInjected.Address(RVA = "0xE644F0", Offset = "0xE644F0", VA = "0xE644F0", Slot = "4")]
	public override bool Apply(Point origin, int x, int y, params object[] args)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D62")]
	[Cpp2IlInjected.Address(RVA = "0xE645B0", Offset = "0xE645B0", VA = "0xE645B0")]
	public ActionStalagtite()
	{
	}
}
