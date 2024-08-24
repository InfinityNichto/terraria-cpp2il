using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200015E RID: 350
[global::Cpp2ILInjected.Token(Token = "0x20001E3")]
public class JourneyModeSettings_Layout : LayoutDefinition
{
	// Token: 0x06000B36 RID: 2870 RVA: 0x00023CE7 File Offset: 0x00021EE7
	[global::Cpp2ILInjected.Token(Token = "0x6000C49")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAEFC", Offset = "0x9CAEFC", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x00023CEA File Offset: 0x00021EEA
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

	// Token: 0x04000D6C RID: 3436
	[global::Cpp2ILInjected.Token(Token = "0x400116F")]
	public static JourneyModeSettings_Layout Instance;

	// Token: 0x04000D6D RID: 3437
	[global::Cpp2ILInjected.Token(Token = "0x4001170")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout JWSettingsButton;

	// Token: 0x04000D6E RID: 3438
	[global::Cpp2ILInjected.Token(Token = "0x4001171")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public StringButton_Layout Title;

	// Token: 0x04000D6F RID: 3439
	[global::Cpp2ILInjected.Token(Token = "0x4001172")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout Backing;

	// Token: 0x04000D70 RID: 3440
	[global::Cpp2ILInjected.Token(Token = "0x4001173")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public DraggableItemGrid_Layout OptionGrid;

	// Token: 0x04000D71 RID: 3441
	[global::Cpp2ILInjected.Token(Token = "0x4001174")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout MenuDivider;

	// Token: 0x04000D72 RID: 3442
	[global::Cpp2ILInjected.Token(Token = "0x4001175")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout MenuDivider2;

	// Token: 0x04000D73 RID: 3443
	[global::Cpp2ILInjected.Token(Token = "0x4001176")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout CloseButton;

	// Token: 0x04000D74 RID: 3444
	[global::Cpp2ILInjected.Token(Token = "0x4001177")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout CategoryBacking;

	// Token: 0x04000D75 RID: 3445
	[global::Cpp2ILInjected.Token(Token = "0x4001178")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout CategoryTime;

	// Token: 0x04000D76 RID: 3446
	[global::Cpp2ILInjected.Token(Token = "0x4001179")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout CategoryWeather;

	// Token: 0x04000D77 RID: 3447
	[global::Cpp2ILInjected.Token(Token = "0x400117A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout CategoryPowers;

	// Token: 0x04000D78 RID: 3448
	[global::Cpp2ILInjected.Token(Token = "0x400117B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public JourneySettingsSlider_Layout SliderLayout;

	// Token: 0x04000D79 RID: 3449
	[global::Cpp2ILInjected.Token(Token = "0x400117C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public JourneySettingsButton_Layout ButtonLayout;

	// Token: 0x04000D7A RID: 3450
	[global::Cpp2ILInjected.Token(Token = "0x400117D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public JourneySettingsToggle_Layout ToggleLayout;

	// Token: 0x04000D7B RID: 3451
	[global::Cpp2ILInjected.Token(Token = "0x400117E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout WindEastNotch;

	// Token: 0x04000D7C RID: 3452
	[global::Cpp2ILInjected.Token(Token = "0x400117F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public TransactionButton_Layout WindNoneNotch;

	// Token: 0x04000D7D RID: 3453
	[global::Cpp2ILInjected.Token(Token = "0x4001180")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public TransactionButton_Layout WindWestNotch;

	// Token: 0x04000D7E RID: 3454
	[global::Cpp2ILInjected.Token(Token = "0x4001181")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public float WindNoneThreashold;

	// Token: 0x04000D7F RID: 3455
	[global::Cpp2ILInjected.Token(Token = "0x4001182")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public float WindWestThreashold;

	// Token: 0x04000D80 RID: 3456
	[global::Cpp2ILInjected.Token(Token = "0x4001183")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public TransactionButton_Layout RainClearNotch;

	// Token: 0x04000D81 RID: 3457
	[global::Cpp2ILInjected.Token(Token = "0x4001184")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public TransactionButton_Layout RainDrizzleNotch;

	// Token: 0x04000D82 RID: 3458
	[global::Cpp2ILInjected.Token(Token = "0x4001185")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public TransactionButton_Layout RainMonsoonNotch;

	// Token: 0x04000D83 RID: 3459
	[global::Cpp2ILInjected.Token(Token = "0x4001186")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public float RainDrizzleThreshold;

	// Token: 0x04000D84 RID: 3460
	[global::Cpp2ILInjected.Token(Token = "0x4001187")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public float RainMonsoonThreshold;

	// Token: 0x04000D85 RID: 3461
	[global::Cpp2ILInjected.Token(Token = "0x4001188")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public TransactionButton_Layout DifficultyJourneyNotch;

	// Token: 0x04000D86 RID: 3462
	[global::Cpp2ILInjected.Token(Token = "0x4001189")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public TransactionButton_Layout DifficultyClassicNotch;

	// Token: 0x04000D87 RID: 3463
	[global::Cpp2ILInjected.Token(Token = "0x400118A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public TransactionButton_Layout DifficultyExpertNotch;

	// Token: 0x04000D88 RID: 3464
	[global::Cpp2ILInjected.Token(Token = "0x400118B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public TransactionButton_Layout DifficultyMasterNotch;

	// Token: 0x04000D89 RID: 3465
	[global::Cpp2ILInjected.Token(Token = "0x400118C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public float DifficultyClassicThreshold;

	// Token: 0x04000D8A RID: 3466
	[global::Cpp2ILInjected.Token(Token = "0x400118D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public float DifficultyExpertThreshold;

	// Token: 0x04000D8B RID: 3467
	[global::Cpp2ILInjected.Token(Token = "0x400118E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public float DifficultyMasterThreshold;

	// Token: 0x04000D8C RID: 3468
	[global::Cpp2ILInjected.Token(Token = "0x400118F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public bool ControllerFosusShowItems;
}
