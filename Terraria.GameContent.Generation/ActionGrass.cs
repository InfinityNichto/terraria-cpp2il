using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005E6")]
public class ActionGrass : GenAction
{
	[Cpp2IlInjected.Token(Token = "0x6003D5D")]
	[Cpp2IlInjected.Address(RVA = "0xE640CC", Offset = "0xE640CC", VA = "0xE640CC", Slot = "4")]
	public override bool Apply(Point origin, int x, int y, params object[] args)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003D5E")]
	[Cpp2IlInjected.Address(RVA = "0xE64344", Offset = "0xE64344", VA = "0xE64344")]
	public ActionGrass()
	{
	}
}
