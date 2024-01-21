using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria;

[Cpp2IlInjected.Token(Token = "0x20000CD")]
public class GUIBuilderAccToggles
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private float toggleButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private int blockReplaceIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private int torchGodIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private int totalDrawnIcons;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private int hoverItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private GUIInputRegionExclusive pickingInterceptor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	public Vector2 toggleSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private List<int> items;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private float TimeSinceChanged;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private string TooltipString;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int ItemCount
	{
		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xF7CF6C", Offset = "0xF7CF6C", VA = "0xF7CF6C")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0xF7C090", Offset = "0xF7C090", VA = "0xF7C090")]
	public Rectangle GetRegion()
	{
		return default(Rectangle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0xF7C22C", Offset = "0xF7C22C", VA = "0xF7C22C")]
	public TransactionButton_Layout SetupLayout()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0xF7C2CC", Offset = "0xF7C2CC", VA = "0xF7C2CC")]
	public void FinaliseLayout(TransactionButton_Layout layout)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0xF7C2FC", Offset = "0xF7C2FC", VA = "0xF7C2FC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0xF7CE0C", Offset = "0xF7CE0C", VA = "0xF7CE0C")]
	private void RefreshList(Player plr)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0xF7CFC4", Offset = "0xF7CFC4", VA = "0xF7CFC4")]
	private float ItemScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0xF7CFDC", Offset = "0xF7CFDC", VA = "0xF7CFDC")]
	private void ItemOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0xF7D064", Offset = "0xF7D064", VA = "0xF7D064")]
	private void ItemDraw(ItemGrid_Layout gridLayout, int z, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0xF7CD80", Offset = "0xF7CD80", VA = "0xF7CD80")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0xF7E0C4", Offset = "0xF7E0C4", VA = "0xF7E0C4")]
	private bool IsOverBuilderTools(Vector2 position)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0xF7E2E4", Offset = "0xF7E2E4", VA = "0xF7E2E4")]
	public GUIBuilderAccToggles()
	{
	}
}
