using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200023F")]
public class TutorialStep_07_Armour : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B97")]
	private bool furnacePlaced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001B98")]
	private bool collectedBars;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4001B99")]
	private bool anvilPlaced;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4001B9A")]
	private bool copperGiven;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001B9B")]
	private bool armourHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4001B9C")]
	private bool armourBody;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
	[Cpp2IlInjected.Token(Token = "0x4001B9D")]
	private bool armourLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF")]
	[Cpp2IlInjected.Token(Token = "0x4001B9E")]
	private bool complete;

	[Cpp2IlInjected.Token(Token = "0x600105C")]
	[Cpp2IlInjected.Address(RVA = "0x10D4BF8", Offset = "0x10D4BF8", VA = "0x10D4BF8", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x600105D")]
	[Cpp2IlInjected.Address(RVA = "0x10D4C00", Offset = "0x10D4C00", VA = "0x10D4C00", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600105E")]
	[Cpp2IlInjected.Address(RVA = "0x10D4EB8", Offset = "0x10D4EB8", VA = "0x10D4EB8", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600105F")]
	[Cpp2IlInjected.Address(RVA = "0x10D4EC8", Offset = "0x10D4EC8", VA = "0x10D4EC8", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001060")]
	[Cpp2IlInjected.Address(RVA = "0x10D4EF0", Offset = "0x10D4EF0", VA = "0x10D4EF0", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001061")]
	[Cpp2IlInjected.Address(RVA = "0x10D4F78", Offset = "0x10D4F78", VA = "0x10D4F78", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001062")]
	[Cpp2IlInjected.Address(RVA = "0x10D2FAC", Offset = "0x10D2FAC", VA = "0x10D2FAC")]
	public TutorialStep_07_Armour()
	{
	}
}
