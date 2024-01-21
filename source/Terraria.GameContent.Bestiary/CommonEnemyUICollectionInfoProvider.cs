using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000630")]
public class CommonEnemyUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C65")]
	private string _persistentIdentifierToCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C66")]
	private bool _quickUnlock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C67")]
	private int _killCountNeededToFullyUnlock;

	[Cpp2IlInjected.Token(Token = "0x6003EE2")]
	[Cpp2IlInjected.Address(RVA = "0x10F7ED0", Offset = "0x10F7ED0", VA = "0x10F7ED0")]
	public CommonEnemyUICollectionInfoProvider(string persistentId, bool quickUnlock)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE3")]
	[Cpp2IlInjected.Address(RVA = "0x10FA0A0", Offset = "0x10FA0A0", VA = "0x10FA0A0")]
	public static int GetKillCountNeeded(string persistentId)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE4")]
	[Cpp2IlInjected.Address(RVA = "0x10FA26C", Offset = "0x10FA26C", VA = "0x10FA26C", Slot = "4")]
	public BestiaryUICollectionInfo GetEntryUICollectionInfo()
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE5")]
	[Cpp2IlInjected.Address(RVA = "0x10FA3F0", Offset = "0x10FA3F0", VA = "0x10FA3F0")]
	public BestiaryEntryUnlockState GetUnlockStateByKillCount(int killCount, bool quickUnlock)
	{
		return default(BestiaryEntryUnlockState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE6")]
	[Cpp2IlInjected.Address(RVA = "0x10FA460", Offset = "0x10FA460", VA = "0x10FA460")]
	public static BestiaryEntryUnlockState GetUnlockStateByKillCount(int killCount, bool quickUnlock, int fullKillCountNeeded)
	{
		return default(BestiaryEntryUnlockState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE7")]
	[Cpp2IlInjected.Address(RVA = "0x10FA4CC", Offset = "0x10FA4CC", VA = "0x10FA4CC")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
