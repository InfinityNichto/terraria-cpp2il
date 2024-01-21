using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200023E")]
public class TutorialStep_06_Mining : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B94")]
	private bool givenPickaxe;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001B95")]
	private bool collectedOres;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4001B96")]
	private bool givenFurnace;

	[Cpp2IlInjected.Token(Token = "0x6001055")]
	[Cpp2IlInjected.Address(RVA = "0x10D49F4", Offset = "0x10D49F4", VA = "0x10D49F4", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001056")]
	[Cpp2IlInjected.Address(RVA = "0x10D49FC", Offset = "0x10D49FC", VA = "0x10D49FC", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001057")]
	[Cpp2IlInjected.Address(RVA = "0x10D4A90", Offset = "0x10D4A90", VA = "0x10D4A90", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001058")]
	[Cpp2IlInjected.Address(RVA = "0x10D4AA0", Offset = "0x10D4AA0", VA = "0x10D4AA0", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001059")]
	[Cpp2IlInjected.Address(RVA = "0x10D4AA4", Offset = "0x10D4AA4", VA = "0x10D4AA4", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600105A")]
	[Cpp2IlInjected.Address(RVA = "0x10D4B10", Offset = "0x10D4B10", VA = "0x10D4B10", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600105B")]
	[Cpp2IlInjected.Address(RVA = "0x10D2FA4", Offset = "0x10D2FA4", VA = "0x10D2FA4")]
	public TutorialStep_06_Mining()
	{
	}
}
