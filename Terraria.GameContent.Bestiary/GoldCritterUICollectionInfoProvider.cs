using Cpp2IlInjected;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000632")]
public class GoldCritterUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C6A")]
	private string[] _normalCritterPersistentId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C6B")]
	private string _goldCritterPersistentId;

	[Cpp2IlInjected.Token(Token = "0x6003EEB")]
	[Cpp2IlInjected.Address(RVA = "0x10FCFC0", Offset = "0x10FCFC0", VA = "0x10FCFC0")]
	public GoldCritterUICollectionInfoProvider(int[] normalCritterPersistentId, string goldCritterPersistentId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EEC")]
	[Cpp2IlInjected.Address(RVA = "0x10FD0F4", Offset = "0x10FD0F4", VA = "0x10FD0F4", Slot = "4")]
	public BestiaryUICollectionInfo GetEntryUICollectionInfo()
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EED")]
	[Cpp2IlInjected.Address(RVA = "0x10FD20C", Offset = "0x10FD20C", VA = "0x10FD20C")]
	private bool TryFindingOneGoldCritterThatIsAlreadyUnlocked()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EEE")]
	[Cpp2IlInjected.Address(RVA = "0x10FD17C", Offset = "0x10FD17C", VA = "0x10FD17C")]
	private BestiaryEntryUnlockState GetUnlockStateForCritter(string persistentId)
	{
		return default(BestiaryEntryUnlockState);
	}
}
