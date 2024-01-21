using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200062F")]
public class TownNPCUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C64")]
	private string _persistentIdentifierToCheck;

	[Cpp2IlInjected.Token(Token = "0x6003EDF")]
	[Cpp2IlInjected.Address(RVA = "0x10F83B4", Offset = "0x10F83B4", VA = "0x10F83B4")]
	public TownNPCUICollectionInfoProvider(string persistentId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE0")]
	[Cpp2IlInjected.Address(RVA = "0x1104E58", Offset = "0x1104E58", VA = "0x1104E58", Slot = "4")]
	public BestiaryUICollectionInfo GetEntryUICollectionInfo()
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EE1")]
	[Cpp2IlInjected.Address(RVA = "0x1104F10", Offset = "0x1104F10", VA = "0x1104F10")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
