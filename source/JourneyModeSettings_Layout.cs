using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001E3")]
public class JourneyModeSettings_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C49")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAEFC", Offset = "0x9CAEFC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C4A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAF48", Offset = "0x9CAF48", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public JourneyModeSettings_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400116F")]
	public static JourneyModeSettings_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001170")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout JWSettingsButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001171")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4001172")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001173")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout OptionGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4001174")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider;

	[global::Cpp2ILInjected.Token(Token = "0x4001175")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider2;

	[global::Cpp2ILInjected.Token(Token = "0x4001176")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout CloseButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001177")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout CategoryBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001178")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout CategoryTime;

	[global::Cpp2ILInjected.Token(Token = "0x4001179")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout CategoryWeather;

	[global::Cpp2ILInjected.Token(Token = "0x400117A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout CategoryPowers;

	[global::Cpp2ILInjected.Token(Token = "0x400117B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public JourneySettingsSlider_Layout SliderLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400117C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public JourneySettingsButton_Layout ButtonLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400117D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public JourneySettingsToggle_Layout ToggleLayout;

	[global::Cpp2ILInjected.Token(Token = "0x400117E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout WindEastNotch;

	[global::Cpp2ILInjected.Token(Token = "0x400117F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout WindNoneNotch;

	[global::Cpp2ILInjected.Token(Token = "0x4001180")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout WindWestNotch;

	[global::Cpp2ILInjected.Token(Token = "0x4001181")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public float WindNoneThreashold;

	[global::Cpp2ILInjected.Token(Token = "0x4001182")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public float WindWestThreashold;

	[global::Cpp2ILInjected.Token(Token = "0x4001183")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout RainClearNotch;

	[global::Cpp2ILInjected.Token(Token = "0x4001184")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout RainDrizzleNotch;

	[global::Cpp2ILInjected.Token(Token = "0x4001185")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout RainMonsoonNotch;

	[global::Cpp2ILInjected.Token(Token = "0x4001186")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public float RainDrizzleThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x4001187")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public float RainMonsoonThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x4001188")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout DifficultyJourneyNotch;

	[global::Cpp2ILInjected.Token(Token = "0x4001189")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout DifficultyClassicNotch;

	[global::Cpp2ILInjected.Token(Token = "0x400118A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout DifficultyExpertNotch;

	[global::Cpp2ILInjected.Token(Token = "0x400118B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout DifficultyMasterNotch;

	[global::Cpp2ILInjected.Token(Token = "0x400118C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public float DifficultyClassicThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x400118D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public float DifficultyExpertThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x400118E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public float DifficultyMasterThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x400118F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public bool ControllerFosusShowItems;
}
