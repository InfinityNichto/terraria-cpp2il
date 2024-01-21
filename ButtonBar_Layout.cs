using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200011F")]
public class ButtonBar_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x400098A")]
	public static ButtonBar_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400098B")]
	public float GridItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400098C")]
	public Stretched_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400098D")]
	public ItemGrid_Layout ButtonGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400098E")]
	public TransactionButton_Layout ButtonCollapsed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400098F")]
	public TransactionButton_Layout ButtonTemplateFirst;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000990")]
	public TransactionButton_Layout ButtonTemplateEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000991")]
	public TransactionButton_Layout ButtonTemplateLast;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000992")]
	public Texture_Layout ExpandIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000993")]
	public Texture_Layout CollapseIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000994")]
	public Texture_Layout ChatIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000995")]
	public Texture_Layout TutorialIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000996")]
	public Texture_Layout TutorialIconSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000997")]
	public Texture_Layout JourneyWorldSettingsIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000998")]
	public Texture_Layout HousingIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000999")]
	public Texture_Layout PVPIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400099A")]
	public Texture_Layout BestiaryIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400099B")]
	public Texture_Layout DuplicateIcon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400099C")]
	public Texture_Layout MapIcon;

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x1201E30", Offset = "0x1201E30", VA = "0x1201E30")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x1201E8C", Offset = "0x1201E8C", VA = "0x1201E8C")]
	public ButtonBar_Layout()
	{
	}
}
