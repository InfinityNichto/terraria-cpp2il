using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000155")]
public class HousingMenu_Layout : PageControllerLayoutDefinition<HousingMenu_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D04")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000D05")]
	public float NPCScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D06")]
	public float NPCHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000D07")]
	public DraggableItemGrid_Layout NPCGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000D08")]
	public DraggableItemGrid_Layout NPCGridCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000D09")]
	public TransactionButton_Layout HousingQuery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000D0A")]
	public TransactionButton_Layout HousingClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000D0B")]
	public EmptyHousingSlot EmptySlot;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public DraggableItemGrid_Layout DisplayNPCGrid
	{
		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x116F1C0", Offset = "0x116F1C0", VA = "0x116F1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x116F258", Offset = "0x116F258", VA = "0x116F258")]
	public HousingMenu_Layout()
	{
	}
}
