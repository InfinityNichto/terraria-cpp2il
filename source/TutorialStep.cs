using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000238")]
public class TutorialStep
{
	[Cpp2IlInjected.Token(Token = "0x200080E")]
	public enum GuideOverLoadState
	{
		[Cpp2IlInjected.Token(Token = "0x4007D5C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4007D5D")]
		StepInProgessDialogue,
		[Cpp2IlInjected.Token(Token = "0x4007D5E")]
		StepCompleteDialogue
	}

	[Cpp2IlInjected.Token(Token = "0x600102B")]
	[Cpp2IlInjected.Address(RVA = "0x10D303C", Offset = "0x10D303C", VA = "0x10D303C", Slot = "4")]
	public virtual void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600102C")]
	[Cpp2IlInjected.Address(RVA = "0x10D3040", Offset = "0x10D3040", VA = "0x10D3040", Slot = "5")]
	public virtual void Begin()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600102D")]
	[Cpp2IlInjected.Address(RVA = "0x10D3044", Offset = "0x10D3044", VA = "0x10D3044", Slot = "6")]
	public virtual bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600102E")]
	[Cpp2IlInjected.Address(RVA = "0x10D304C", Offset = "0x10D304C", VA = "0x10D304C", Slot = "7")]
	public virtual GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x600102F")]
	[Cpp2IlInjected.Address(RVA = "0x10D3054", Offset = "0x10D3054", VA = "0x10D3054", Slot = "8")]
	public virtual string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001030")]
	[Cpp2IlInjected.Address(RVA = "0x10D30AC", Offset = "0x10D30AC", VA = "0x10D30AC", Slot = "9")]
	public virtual void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001031")]
	[Cpp2IlInjected.Address(RVA = "0x10D30B0", Offset = "0x10D30B0", VA = "0x10D30B0", Slot = "10")]
	public virtual void OnItemPlaced(int itemId, int tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001032")]
	[Cpp2IlInjected.Address(RVA = "0x10D30B8", Offset = "0x10D30B8", VA = "0x10D30B8")]
	protected void SetTime(int hour, int min, bool freeze)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001033")]
	[Cpp2IlInjected.Address(RVA = "0x10D324C", Offset = "0x10D324C", VA = "0x10D324C")]
	protected void SetSpawnRate(float spawnRate)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001034")]
	[Cpp2IlInjected.Address(RVA = "0x10D32D0", Offset = "0x10D32D0", VA = "0x10D32D0")]
	protected void GiveItem(short item, int stackCount)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001035")]
	[Cpp2IlInjected.Address(RVA = "0x10D342C", Offset = "0x10D342C", VA = "0x10D342C")]
	public TutorialStep()
	{
	}
}
