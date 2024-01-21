using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000056")]
public class GUIControllerToggleEntry : GUIControllerMappingEntryBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private GUIToggleSetting Worker;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x121E498", Offset = "0x121E498", VA = "0x121E498")]
	public GUIControllerToggleEntry(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x121E554", Offset = "0x121E554", VA = "0x121E554", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x121E568", Offset = "0x121E568", VA = "0x121E568", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x121E57C", Offset = "0x121E57C", VA = "0x121E57C", Slot = "6")]
	public override void DrawOverlay()
	{
	}
}
