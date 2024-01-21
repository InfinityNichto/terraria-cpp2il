using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x2000148")]
public class ControlsTutorial_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000BC2")]
	public static ControlsTutorial_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000BC3")]
	public float TooltipTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000BC4")]
	public float TooltipFadeTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000BC5")]
	public int MaximumTooltipWidth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000BC6")]
	public int InteractPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000BC7")]
	public int AutoSelectPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000BC8")]
	public int AutoFirePriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000BC9")]
	public int QuickHealPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000BCA")]
	public int QuickManaPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000BCB")]
	public int QuickBuffPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000BCC")]
	public int InventoryTogglePriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000BCD")]
	public int ZoomOutPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000BCE")]
	public int MovementAxisPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000BCF")]
	public ControlAnchor.ControlId LeftAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000BD0")]
	public LayoutCalculator.AnchorType LeftAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000BD1")]
	public Vector2 LeftLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000BD2")]
	public int FirePriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000BD3")]
	public int TargetLockOnPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000BD4")]
	public int SmartCursorPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000BD5")]
	public int JumpPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000BD6")]
	public int QuickMountPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000BD7")]
	public int ZoomInPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000BD8")]
	public int FireAxisPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000BD9")]
	public int GrappleAxisPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000BDA")]
	public int ProfileSwitchPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000BDB")]
	public ControlAnchor.ControlId RightAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000BDC")]
	public LayoutCalculator.AnchorType RightAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000BDD")]
	public Vector2 RightLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000BDE")]
	public TransactionButton_Layout TutorialButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000BDF")]
	public TransactionButton_Layout TutorialButtonOpen;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000BE0")]
	public ControlAnchor.ControlId ToggleAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000BE1")]
	public LayoutCalculator.AnchorType ToggleAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000BE2")]
	public Vector2 ToggleLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000BE3")]
	public String_Layout TitleFormat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000BE4")]
	public ControlAnchor.ControlId MenuAnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000BE5")]
	public LayoutCalculator.AnchorType MenuAnchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000BE6")]
	public Vector2 MenuLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000BE7")]
	public Vector2 MenuTopLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000BE8")]
	public Vector2 MenuBottomLocation;

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x20C5330", Offset = "0x20C5330", VA = "0x20C5330")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x20C538C", Offset = "0x20C538C", VA = "0x20C538C")]
	public ControlsTutorial_Layout()
	{
	}
}
