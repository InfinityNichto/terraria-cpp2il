using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GUIControllerSliderEntry : GUIControllerMappingEntryBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private GUISliderSetting Worker;

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x121D718", Offset = "0x121D718", VA = "0x121D718")]
	public GUIControllerSliderEntry(GUISettingID id)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x121D7D4", Offset = "0x121D7D4", VA = "0x121D7D4", Slot = "4")]
	public override void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x121D7E8", Offset = "0x121D7E8", VA = "0x121D7E8", Slot = "5")]
	public override float GetElementHeight()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x121D7FC", Offset = "0x121D7FC", VA = "0x121D7FC", Slot = "6")]
	public override void DrawOverlay()
	{
	}
}
