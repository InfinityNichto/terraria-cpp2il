using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000117")]
public class Achievements_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x40008E4")]
	public static Achievements_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40008E5")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40008E6")]
	public DraggableItemGrid_Layout AchievementsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40008E7")]
	public StringButton_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40008E8")]
	public Panel_Layout MenuDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40008E9")]
	public Panel_Layout MenuDivider2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40008EA")]
	public TransactionButton_Layout Back;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40008EB")]
	public Panel_Layout ItemBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40008EC")]
	public Panel_Layout ItemSelectedBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40008ED")]
	public Button_Layout ItemDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40008EE")]
	public String_Layout ItemName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40008EF")]
	public String_Layout ItemNameCompleted;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40008F0")]
	public Panel_Layout ItemNameDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40008F1")]
	public String_Layout ItemDescription;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40008F2")]
	public int ItemDescWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40008F3")]
	public AchievementIcon ItemIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40008F4")]
	public Vector2 ItemCatIconsPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40008F5")]
	public float ItemCatIconsScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40008F6")]
	public String_Layout ProgressNumbers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40008F7")]
	public ProgressBar_Layout ProgressBar;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40008F8")]
	public Panel_Layout ItemInnerPanelTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40008F9")]
	public Panel_Layout ItemSelectedInnerPanelTop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40008FA")]
	public Panel_Layout ItemInnerPanelBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40008FB")]
	public Panel_Layout ItemSelectedInnerPanelBottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40008FC")]
	public Panel_Layout CategoryDivider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40008FD")]
	public Vector2 InGameWindowShift;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40008FE")]
	public TransactionButton_Layout Filters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40008FF")]
	public Panel_Layout FiltersBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000900")]
	public TransactionButton_Layout Slayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000901")]
	public TransactionButton_Layout Collector;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000902")]
	public TransactionButton_Layout Explorer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000903")]
	public TransactionButton_Layout Challenger;

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x11FC47C", Offset = "0x11FC47C", VA = "0x11FC47C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x11FC4D8", Offset = "0x11FC4D8", VA = "0x11FC4D8")]
	public Achievements_Layout()
	{
	}
}
