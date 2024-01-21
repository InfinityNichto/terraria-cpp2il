using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements;

[Cpp2IlInjected.Token(Token = "0x20006CF")]
public class UIDynamicItemCollection : UIElement
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400702B")]
	private List<int> _itemIdsAvailableToShow;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400702C")]
	private List<int> _itemIdsToLoadTexturesFor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400702D")]
	private int _itemsPerLine;

	[Cpp2IlInjected.Token(Token = "0x400702E")]
	private const int sizePerEntryX = 44;

	[Cpp2IlInjected.Token(Token = "0x400702F")]
	private const int sizePerEntryY = 44;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4007030")]
	private List<SnapPoint> _dummySnapPoints;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4007031")]
	private Item _item;

	[Cpp2IlInjected.Token(Token = "0x60044A1")]
	[Cpp2IlInjected.Address(RVA = "0x1488DFC", Offset = "0x1488DFC", VA = "0x1488DFC")]
	public UIDynamicItemCollection()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044A2")]
	[Cpp2IlInjected.Address(RVA = "0x148DB0C", Offset = "0x148DB0C", VA = "0x148DB0C", Slot = "6")]
	protected override void DrawSelf(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044A3")]
	[Cpp2IlInjected.Address(RVA = "0x148E260", Offset = "0x148E260", VA = "0x148E260")]
	private Rectangle GetItemSlotHitbox(int startX, int startY, int startItemIndex, int i)
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60044A4")]
	[Cpp2IlInjected.Address(RVA = "0x148E0A0", Offset = "0x148E0A0", VA = "0x148E0A0")]
	private void GetGridParameters(out int startX, out int startY, out int startItemIndex, out int endItemIndex)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044A5")]
	[Cpp2IlInjected.Address(RVA = "0x148E2CC", Offset = "0x148E2CC", VA = "0x148E2CC", Slot = "11")]
	public override void Recalculate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044A6")]
	[Cpp2IlInjected.Address(RVA = "0x148E2EC", Offset = "0x148E2EC", VA = "0x148E2EC", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044A7")]
	[Cpp2IlInjected.Address(RVA = "0x148B99C", Offset = "0x148B99C", VA = "0x148B99C")]
	public void SetContentsToShow(List<int> itemIdsToShow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60044A8")]
	[Cpp2IlInjected.Address(RVA = "0x148E38C", Offset = "0x148E38C", VA = "0x148E38C")]
	public int GetItemsPerLine()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60044A9")]
	[Cpp2IlInjected.Address(RVA = "0x148E394", Offset = "0x148E394", VA = "0x148E394", Slot = "10")]
	public override List<SnapPoint> GetSnapPoints()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60044AA")]
	[Cpp2IlInjected.Address(RVA = "0x148DA08", Offset = "0x148DA08", VA = "0x148DA08")]
	public void UpdateSize()
	{
	}
}
