using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001BF")]
public class WireUI_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40013B0")]
	public static WireUI_Layout InstanceNormal;

	[Cpp2IlInjected.Token(Token = "0x40013B1")]
	public static WireUI_Layout Instance4Page;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40013B2")]
	public Vector2 BackingTLOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40013B3")]
	public Vector2 BackingBROffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40013B4")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40013B5")]
	public Panel_Layout CutterBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40013B6")]
	public ItemGrid_Layout ToolOptions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40013B7")]
	public Vector2 CursorPanelOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40013B8")]
	public Vector2 TouchPanelOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40013B9")]
	public TransactionButton_Layout PlacementBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40013BA")]
	public TransactionButton_Layout RemovalBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40013BB")]
	public FadeString_Layout TooltipDisplay;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public static WireUI_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0xE8F2A0", Offset = "0xE8F2A0", VA = "0xE8F2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0xE8F320", Offset = "0xE8F320", VA = "0xE8F320")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0xE8F3A0", Offset = "0xE8F3A0", VA = "0xE8F3A0")]
	public WireUI_Layout()
	{
	}
}
