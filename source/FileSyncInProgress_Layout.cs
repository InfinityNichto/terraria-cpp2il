using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200016F")]
public class FileSyncInProgress_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000E09")]
	public static FileSyncInProgress_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000E0A")]
	public Panel_Layout Greyout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000E0B")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000E0C")]
	public StringButton_Layout Status;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000E0D")]
	public Button_Layout SearchingIcon;

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x20D408C", Offset = "0x20D408C", VA = "0x20D408C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x20D40E8", Offset = "0x20D40E8", VA = "0x20D40E8")]
	public FileSyncInProgress_Layout()
	{
	}
}
