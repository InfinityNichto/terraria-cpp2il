using System;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000240")]
public class TutorialStep_08_KillZombies : TutorialStep
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001B9F")]
	private bool armourHead;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4001BA0")]
	private bool armourBody;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4001BA1")]
	private bool armourLegs;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
	[Cpp2IlInjected.Token(Token = "0x4001BA2")]
	private bool complete;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001BA3")]
	private bool killing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001BA4")]
	private DateTime killStart;

	[Cpp2IlInjected.Token(Token = "0x6001063")]
	[Cpp2IlInjected.Address(RVA = "0x10D5104", Offset = "0x10D5104", VA = "0x10D5104", Slot = "7")]
	public override GuideOverLoadState GetGuideState()
	{
		return default(GuideOverLoadState);
	}

	[Cpp2IlInjected.Token(Token = "0x6001064")]
	[Cpp2IlInjected.Address(RVA = "0x10D510C", Offset = "0x10D510C", VA = "0x10D510C", Slot = "8")]
	public override string GetGuideString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001065")]
	[Cpp2IlInjected.Address(RVA = "0x10D53AC", Offset = "0x10D53AC", VA = "0x10D53AC", Slot = "4")]
	public override void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001066")]
	[Cpp2IlInjected.Address(RVA = "0x10D53BC", Offset = "0x10D53BC", VA = "0x10D53BC", Slot = "10")]
	public override void OnItemPlaced(int itemId, int tileId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001067")]
	[Cpp2IlInjected.Address(RVA = "0x10D53C0", Offset = "0x10D53C0", VA = "0x10D53C0", Slot = "9")]
	public override void OnGuideDialogueOpen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001068")]
	[Cpp2IlInjected.Address(RVA = "0x10D54C0", Offset = "0x10D54C0", VA = "0x10D54C0", Slot = "6")]
	public override bool Update()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001069")]
	[Cpp2IlInjected.Address(RVA = "0x10D2FB4", Offset = "0x10D2FB4", VA = "0x10D2FB4")]
	public TutorialStep_08_KillZombies()
	{
	}
}
