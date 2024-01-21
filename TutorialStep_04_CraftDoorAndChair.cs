using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200023C")]
public class TutorialStep_04_CraftDoorAndChair : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B8C")]
	private bool doorPlaced;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001B8D")]
	private bool chairPlaced;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4001B8E")]
	private bool tablePlaced;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4001B8F")]
	private bool complete;

	[Cpp2IlInjected.Token(Token = "0x6001047")]
	[Cpp2IlInjected.Address(RVA = "0x10D4238", Offset = "0x10D4238", VA = "0x10D4238", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001048")]
	[Cpp2IlInjected.Address(RVA = "0x10D4240", Offset = "0x10D4240", VA = "0x10D4240", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001049")]
	[Cpp2IlInjected.Address(RVA = "0x10D4334", Offset = "0x10D4334", VA = "0x10D4334", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600104A")]
	[Cpp2IlInjected.Address(RVA = "0x10D4344", Offset = "0x10D4344", VA = "0x10D4344", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600104B")]
	[Cpp2IlInjected.Address(RVA = "0x10D4368", Offset = "0x10D4368", VA = "0x10D4368", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600104C")]
	[Cpp2IlInjected.Address(RVA = "0x10D43A4", Offset = "0x10D43A4", VA = "0x10D43A4", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600104D")]
	[Cpp2IlInjected.Address(RVA = "0x10D2F94", Offset = "0x10D2F94", VA = "0x10D2F94")]
	public TutorialStep_04_CraftDoorAndChair()
	{
	}
}
