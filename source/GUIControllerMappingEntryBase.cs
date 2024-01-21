using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GUIControllerMappingEntryBase : GUISettingEntry
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public ControllerMappingsCategories_Layout.Category Category;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public int SortOrder;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xF6B028", Offset = "0xF6B028", VA = "0xF6B028")]
	public GUIControllerMappingEntryBase(GUISettingID id)
	{
	}
}
