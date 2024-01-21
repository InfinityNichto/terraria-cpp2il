using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x2000361")]
public abstract class GenSearch : GenBase
{
	[Cpp2IlInjected.Token(Token = "0x40030C8")]
	public static Point NOT_FOUND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40030C9")]
	private bool _requireAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40030CA")]
	private GenCondition[] _conditions;

	[Cpp2IlInjected.Token(Token = "0x6002C70")]
	[Cpp2IlInjected.Address(RVA = "0x1300880", Offset = "0x1300880", VA = "0x1300880")]
	public GenSearch Conditions(params GenCondition[] conditions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C71")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract Point Find(Point origin);

	[Cpp2IlInjected.Token(Token = "0x6002C72")]
	[Cpp2IlInjected.Address(RVA = "0x1300888", Offset = "0x1300888", VA = "0x1300888")]
	protected bool Check(int x, int y)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002C73")]
	[Cpp2IlInjected.Address(RVA = "0x1300914", Offset = "0x1300914", VA = "0x1300914")]
	public GenSearch RequireAll(bool mode)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002C74")]
	[Cpp2IlInjected.Address(RVA = "0x130091C", Offset = "0x130091C", VA = "0x130091C")]
	protected GenSearch()
	{
	}
}
