using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200023A")]
public class TutorialStep_02_CopperPickaxe : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B88")]
	private bool givenAxe;

	[Cpp2IlInjected.Token(Token = "0x600103A")]
	[Cpp2IlInjected.Address(RVA = "0x10D382C", Offset = "0x10D382C", VA = "0x10D382C", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x600103B")]
	[Cpp2IlInjected.Address(RVA = "0x10D3834", Offset = "0x10D3834", VA = "0x10D3834", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600103C")]
	[Cpp2IlInjected.Address(RVA = "0x10D3A04", Offset = "0x10D3A04", VA = "0x10D3A04", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600103D")]
	[Cpp2IlInjected.Address(RVA = "0x10D3A10", Offset = "0x10D3A10", VA = "0x10D3A10", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600103E")]
	[Cpp2IlInjected.Address(RVA = "0x10D3B20", Offset = "0x10D3B20", VA = "0x10D3B20", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600103F")]
	[Cpp2IlInjected.Address(RVA = "0x10D2F84", Offset = "0x10D2F84", VA = "0x10D2F84")]
	public TutorialStep_02_CopperPickaxe()
	{
	}
}
