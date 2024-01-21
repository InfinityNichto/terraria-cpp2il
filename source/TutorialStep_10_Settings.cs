using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000242")]
public class TutorialStep_10_Settings : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001BA6")]
	private bool complete;

	[Cpp2IlInjected.Token(Token = "0x6001071")]
	[Cpp2IlInjected.Address(RVA = "0x10D58C0", Offset = "0x10D58C0", VA = "0x10D58C0", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001072")]
	[Cpp2IlInjected.Address(RVA = "0x10D58C8", Offset = "0x10D58C8", VA = "0x10D58C8", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001073")]
	[Cpp2IlInjected.Address(RVA = "0x10D59BC", Offset = "0x10D59BC", VA = "0x10D59BC", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001074")]
	[Cpp2IlInjected.Address(RVA = "0x10D59C8", Offset = "0x10D59C8", VA = "0x10D59C8", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001075")]
	[Cpp2IlInjected.Address(RVA = "0x10D59CC", Offset = "0x10D59CC", VA = "0x10D59CC", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001076")]
	[Cpp2IlInjected.Address(RVA = "0x10D59D8", Offset = "0x10D59D8", VA = "0x10D59D8", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001077")]
	[Cpp2IlInjected.Address(RVA = "0x10D2FC4", Offset = "0x10D2FC4", VA = "0x10D2FC4")]
	public TutorialStep_10_Settings()
	{
	}
}
