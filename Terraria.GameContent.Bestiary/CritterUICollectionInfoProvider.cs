using Cpp2IlInjected;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x200062E")]
public class CritterUICollectionInfoProvider : IBestiaryUICollectionInfoProvider
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C63")]
	private string _persistentIdentifierToCheck;

	[Cpp2IlInjected.Token(Token = "0x6003EDC")]
	[Cpp2IlInjected.Address(RVA = "0x10F8750", Offset = "0x10F8750", VA = "0x10F8750")]
	public CritterUICollectionInfoProvider(string persistentId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003EDD")]
	[Cpp2IlInjected.Address(RVA = "0x10FA4D4", Offset = "0x10FA4D4", VA = "0x10FA4D4", Slot = "4")]
	public BestiaryUICollectionInfo GetEntryUICollectionInfo()
	{
		return default(BestiaryUICollectionInfo);
	}

	[Cpp2IlInjected.Token(Token = "0x6003EDE")]
	[Cpp2IlInjected.Address(RVA = "0x10FA5F0", Offset = "0x10FA5F0", VA = "0x10FA5F0")]
	public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
	{
		return null;
	}
}
