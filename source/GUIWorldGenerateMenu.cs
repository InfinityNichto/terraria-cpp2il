using Cpp2IlInjected;
using Terraria.WorldBuilding;

[Cpp2IlInjected.Token(Token = "0x20001E7")]
public class GUIWorldGenerateMenu
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40015FB")]
	public GenerationProgress Progress;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40015FC")]
	public float totalProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40015FD")]
	public float progress;

	[Cpp2IlInjected.Token(Token = "0x6000DDD")]
	[Cpp2IlInjected.Address(RVA = "0x1165178", Offset = "0x1165178", VA = "0x1165178")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DDE")]
	[Cpp2IlInjected.Address(RVA = "0x11659E0", Offset = "0x11659E0", VA = "0x11659E0")]
	public GUIWorldGenerateMenu()
	{
	}
}
