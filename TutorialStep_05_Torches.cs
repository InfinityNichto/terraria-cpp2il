using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200023D")]
public class TutorialStep_05_Torches : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B90")]
	private bool givenSword;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001B91")]
	private bool collectedGels;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4001B92")]
	private bool craftedTorches;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4001B93")]
	private bool torchesPlaced;

	[Cpp2IlInjected.Token(Token = "0x600104E")]
	[Cpp2IlInjected.Address(RVA = "0x10D43D4", Offset = "0x10D43D4", VA = "0x10D43D4", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x600104F")]
	[Cpp2IlInjected.Address(RVA = "0x10D43DC", Offset = "0x10D43DC", VA = "0x10D43DC", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001050")]
	[Cpp2IlInjected.Address(RVA = "0x10D4644", Offset = "0x10D4644", VA = "0x10D4644", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001051")]
	[Cpp2IlInjected.Address(RVA = "0x10D4650", Offset = "0x10D4650", VA = "0x10D4650", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001052")]
	[Cpp2IlInjected.Address(RVA = "0x10D46E4", Offset = "0x10D46E4", VA = "0x10D46E4", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001053")]
	[Cpp2IlInjected.Address(RVA = "0x10D4768", Offset = "0x10D4768", VA = "0x10D4768", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001054")]
	[Cpp2IlInjected.Address(RVA = "0x10D2F9C", Offset = "0x10D2F9C", VA = "0x10D2F9C")]
	public TutorialStep_05_Torches()
	{
	}
}
