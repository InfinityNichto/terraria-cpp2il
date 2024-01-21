using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Generation;

[Cpp2IlInjected.Token(Token = "0x20005E9")]
public class ActionVines : GenAction
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006BCD")]
	private int _minLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006BCE")]
	private int _maxLength;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006BCF")]
	private int _vineId;

	[Cpp2IlInjected.Token(Token = "0x6003D63")]
	[Cpp2IlInjected.Address(RVA = "0xE645B8", Offset = "0xE645B8", VA = "0xE645B8")]
	public ActionVines(int minLength = 6, int maxLength = 10, int vineId = 52)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003D64")]
	[Cpp2IlInjected.Address(RVA = "0xE645E8", Offset = "0xE645E8", VA = "0xE645E8", Slot = "4")]
	public override bool Apply(Point origin, int x, int y, params object[] args)
	{
		return default(bool);
	}
}
