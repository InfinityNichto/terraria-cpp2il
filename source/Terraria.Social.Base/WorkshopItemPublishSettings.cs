using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x200039D")]
public class WorkshopItemPublishSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031E6")]
	public WorkshopTagOption[] UsedTags;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031E7")]
	public WorkshopItemPublicSettingId Publicity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40031E8")]
	public string PreviewImagePath;

	[Cpp2IlInjected.Token(Token = "0x6002DFC")]
	[Cpp2IlInjected.Address(RVA = "0x14E13B8", Offset = "0x14E13B8", VA = "0x14E13B8")]
	public string[] GetUsedTagsInternalNames()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002DFD")]
	[Cpp2IlInjected.Address(RVA = "0x14E14E8", Offset = "0x14E14E8", VA = "0x14E14E8")]
	public WorkshopItemPublishSettings()
	{
	}
}
