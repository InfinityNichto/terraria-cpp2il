using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200023B")]
public class TutorialStep_03_CraftWorkbench : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B89")]
	private bool got10Wood;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001B8A")]
	private bool craftedWorkbench;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4001B8B")]
	private bool placedWorkbench;

	[Cpp2IlInjected.Token(Token = "0x6001040")]
	[Cpp2IlInjected.Address(RVA = "0x10D3BD0", Offset = "0x10D3BD0", VA = "0x10D3BD0", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001041")]
	[Cpp2IlInjected.Address(RVA = "0x10D3BD8", Offset = "0x10D3BD8", VA = "0x10D3BD8", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001042")]
	[Cpp2IlInjected.Address(RVA = "0x10D3F6C", Offset = "0x10D3F6C", VA = "0x10D3F6C", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001043")]
	[Cpp2IlInjected.Address(RVA = "0x10D3F7C", Offset = "0x10D3F7C", VA = "0x10D3F7C", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001044")]
	[Cpp2IlInjected.Address(RVA = "0x10D3FC0", Offset = "0x10D3FC0", VA = "0x10D3FC0", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001045")]
	[Cpp2IlInjected.Address(RVA = "0x10D4064", Offset = "0x10D4064", VA = "0x10D4064", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001046")]
	[Cpp2IlInjected.Address(RVA = "0x10D2F8C", Offset = "0x10D2F8C", VA = "0x10D2F8C")]
	public TutorialStep_03_CraftWorkbench()
	{
	}
}
