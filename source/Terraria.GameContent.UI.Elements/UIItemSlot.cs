using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006D0")]
public class UIItemSlot : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4007032")]
	private Item[] _itemArray;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4007033")]
	private int _itemIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4007034")]
	private int _itemSlotContext;

	[Cpp2IlInjected.Token(Token = "0x60044AB")]
	[Cpp2IlInjected.Address(RVA = "0x1492344", Offset = "0x1492344", VA = "0x1492344")]
	public UIItemSlot(Item[] itemArray, int itemIndex, int itemSlotContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044AC")]
	[Cpp2IlInjected.Address(RVA = "0x1492440", Offset = "0x1492440", VA = "0x1492440")]
	private void HandleItemSlotLogic()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044AD")]
	[Cpp2IlInjected.Address(RVA = "0x14925A0", Offset = "0x14925A0", VA = "0x14925A0", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}
}
