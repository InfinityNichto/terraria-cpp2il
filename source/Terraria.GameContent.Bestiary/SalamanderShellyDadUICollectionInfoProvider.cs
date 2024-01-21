using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000633")]
public class SalamanderShellyDadUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C6C")]
	private string _persistentIdentifierToCheck;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006C6D")]
	private int _killCountNeededToFullyUnlock;

	[Cpp2IlInjected.Token(Token = "0x6003EEF")]
	[Cpp2IlInjected.Address(RVA = "0x1102A68", Offset = "0x1102A68", VA = "0x1102A68")]
	public SalamanderShellyDadUICollectionInfoProvider(string persistentId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF0")]
	[Cpp2IlInjected.Address(RVA = "0x1102A94", Offset = "0x1102A94", VA = "0x1102A94", Slot = "4")]
	public BestiaryUICollectionInfo GetEntryUICollectionInfo()
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF1")]
	[Cpp2IlInjected.Address(RVA = "0x1102D48", Offset = "0x1102D48", VA = "0x1102D48")]
	private BestiaryEntryUnlockState GetLowestAvailableUnlockStateFromEntriesThatAreInWorld(BestiaryEntryUnlockState unlockstatus)
	{
		return default(BestiaryEntryUnlockState);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF2")]
	[Cpp2IlInjected.Address(RVA = "0x1102B90", Offset = "0x1102B90", VA = "0x1102B90")]
	private bool IsIncludedInCurrentWorld()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EF3")]
	[Cpp2IlInjected.Address(RVA = "0x1102F4C", Offset = "0x1102F4C", VA = "0x1102F4C")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
