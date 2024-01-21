using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000241")]
public class TutorialStep_09_Bestiary : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001BA5")]
	private bool openedBestiary;

	[Cpp2IlInjected.Token(Token = "0x600106A")]
	[Cpp2IlInjected.Address(RVA = "0x10D5680", Offset = "0x10D5680", VA = "0x10D5680", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x600106B")]
	[Cpp2IlInjected.Address(RVA = "0x10D5688", Offset = "0x10D5688", VA = "0x10D5688", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600106C")]
	[Cpp2IlInjected.Address(RVA = "0x10D57AC", Offset = "0x10D57AC", VA = "0x10D57AC", Slot = "5")]
	public override void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600106D")]
	[Cpp2IlInjected.Address(RVA = "0x10D582C", Offset = "0x10D582C", VA = "0x10D582C", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600106E")]
	[Cpp2IlInjected.Address(RVA = "0x10D5838", Offset = "0x10D5838", VA = "0x10D5838", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600106F")]
	[Cpp2IlInjected.Address(RVA = "0x10D583C", Offset = "0x10D583C", VA = "0x10D583C", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001070")]
	[Cpp2IlInjected.Address(RVA = "0x10D2FBC", Offset = "0x10D2FBC", VA = "0x10D2FBC")]
	public TutorialStep_09_Bestiary()
	{
	}
}
