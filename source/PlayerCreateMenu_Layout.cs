using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200020A")]
public class PlayerCreateMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CB2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF8C4", Offset = "0x9CF8C4", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CB3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF910", Offset = "0x9CF910", Length = "0x128")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Slider_Layout), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public PlayerCreateMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400132E")]
	public static PlayerCreateMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400132F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001330")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Greyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001331")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001332")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout CharacterBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001333")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout CharacterPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4001334")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Info;

	[global::Cpp2ILInjected.Token(Token = "0x4001335")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Gender;

	[global::Cpp2ILInjected.Token(Token = "0x4001336")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout ChangeHair;

	[global::Cpp2ILInjected.Token(Token = "0x4001337")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout Hair;

	[global::Cpp2ILInjected.Token(Token = "0x4001338")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Eyes;

	[global::Cpp2ILInjected.Token(Token = "0x4001339")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout Skin;

	[global::Cpp2ILInjected.Token(Token = "0x400133A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout Shirt;

	[global::Cpp2ILInjected.Token(Token = "0x400133B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout Undershirt;

	[global::Cpp2ILInjected.Token(Token = "0x400133C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout Pants;

	[global::Cpp2ILInjected.Token(Token = "0x400133D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout Shoes;

	[global::Cpp2ILInjected.Token(Token = "0x400133E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x400133F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public String_Layout NameTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001340")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public TransactionButton_Layout PlayerName;

	[global::Cpp2ILInjected.Token(Token = "0x4001341")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public String_Layout PlayerNameEdit;

	[global::Cpp2ILInjected.Token(Token = "0x4001342")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public String_Layout DifficultyTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4001343")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout Difficulty;

	[global::Cpp2ILInjected.Token(Token = "0x4001344")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public TransactionButton_Layout TypeDescription;

	[global::Cpp2ILInjected.Token(Token = "0x4001345")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Panel_Layout OptionsGreyout;

	[global::Cpp2ILInjected.Token(Token = "0x4001346")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout OptionsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001347")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout SoftcoreOption;

	[global::Cpp2ILInjected.Token(Token = "0x4001348")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout MediumCoreOption;

	[global::Cpp2ILInjected.Token(Token = "0x4001349")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public TransactionButton_Layout HardCoreOption;

	[global::Cpp2ILInjected.Token(Token = "0x400134A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public TransactionButton_Layout JourneyOption;

	[global::Cpp2ILInjected.Token(Token = "0x400134B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public StringButton_Layout Softcore;

	[global::Cpp2ILInjected.Token(Token = "0x400134C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public StringButton_Layout MediumCore;

	[global::Cpp2ILInjected.Token(Token = "0x400134D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public StringButton_Layout HardCore;

	[global::Cpp2ILInjected.Token(Token = "0x400134E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public StringButton_Layout DifficultyDescription;

	[global::Cpp2ILInjected.Token(Token = "0x400134F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public Panel_Layout StyleBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001350")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public Panel_Layout SelectedStyleBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001351")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public ItemGrid_Layout MalePresetsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001352")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public ItemGrid_Layout FemalePresetsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001353")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public TransactionButton_Layout Male;

	[global::Cpp2ILInjected.Token(Token = "0x4001354")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public TransactionButton_Layout Female;

	[global::Cpp2ILInjected.Token(Token = "0x4001355")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public TransactionButton_Layout Randomise;

	[global::Cpp2ILInjected.Token(Token = "0x4001356")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x4001357")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public DraggableItemGrid_Layout HairGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001358")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public float HairScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001359")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
	public float HairHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400135A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public Panel_Layout SliderBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400135B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public TransactionButton_Layout LightnessBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400135C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public Slider_Layout Lightness;

	[global::Cpp2ILInjected.Token(Token = "0x400135D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public TransactionButton_Layout SaturationBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400135E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public Slider_Layout Saturation;

	[global::Cpp2ILInjected.Token(Token = "0x400135F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public TransactionButton_Layout HueBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001360")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Slider_Layout Hue;

	[global::Cpp2ILInjected.Token(Token = "0x4001361")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public TransactionButton_Layout ColourValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001362")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public TransactionButton_Layout ColourRandomise;

	[global::Cpp2ILInjected.Token(Token = "0x4001363")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public TransactionButton_Layout Create;

	[global::Cpp2ILInjected.Token(Token = "0x4001364")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public TransactionButton_Layout Back;
}
