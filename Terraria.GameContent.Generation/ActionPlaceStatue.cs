using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005E7")]
public class ActionPlaceStatue : GenAction
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006BCC")]
	private int _statueIndex;

	[Cpp2IlInjected.Token(Token = "0x6003D5F")]
	[Cpp2IlInjected.Address(RVA = "0xE6434C", Offset = "0xE6434C", VA = "0xE6434C")]
	public ActionPlaceStatue(int index = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D60")]
	[Cpp2IlInjected.Address(RVA = "0xE6436C", Offset = "0xE6436C", VA = "0xE6436C", Slot = "4")]
	public override bool Apply(Point origin, int x, int y, params object[] args)
	{
		return default(bool);
	}
}
