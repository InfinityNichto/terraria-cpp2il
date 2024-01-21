using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000237")]
public class TutorialLevel
{
	[Cpp2IlInjected.Token(Token = "0x4001B81")]
	public static TutorialLevel Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B82")]
	public readonly TutorialStep[] Steps;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001B83")]
	public bool JMSettingsDisabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4001B84")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001B85")]
	private int activeStep;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001B86")]
	public string TutorialPopupText;

	[Cpp2IlInjected.Token(Token = "0x6001022")]
	[Cpp2IlInjected.Address(RVA = "0x10D298C", Offset = "0x10D298C", VA = "0x10D298C")]
	public void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001023")]
	[Cpp2IlInjected.Address(RVA = "0x10D29EC", Offset = "0x10D29EC", VA = "0x10D29EC")]
	public void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001024")]
	[Cpp2IlInjected.Address(RVA = "0x10D2A6C", Offset = "0x10D2A6C", VA = "0x10D2A6C")]
	public TutorialStep.GuideOverLoadState GetGuideState()
	{
		return default(TutorialStep.GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001025")]
	[Cpp2IlInjected.Address(RVA = "0x10D2A9C", Offset = "0x10D2A9C", VA = "0x10D2A9C")]
	public string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001026")]
	[Cpp2IlInjected.Address(RVA = "0x10D2B28", Offset = "0x10D2B28", VA = "0x10D2B28")]
	public bool IsComplete()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001027")]
	[Cpp2IlInjected.Address(RVA = "0x10D2B44", Offset = "0x10D2B44", VA = "0x10D2B44")]
	public void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001028")]
	[Cpp2IlInjected.Address(RVA = "0x10D2B70", Offset = "0x10D2B70", VA = "0x10D2B70")]
	public void OnItemPlaced(int itemId, int tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001029")]
	[Cpp2IlInjected.Address(RVA = "0x10D2B9C", Offset = "0x10D2B9C", VA = "0x10D2B9C")]
	public TutorialLevel()
	{
	}
}
