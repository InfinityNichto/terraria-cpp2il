using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001E9")]
public class GUIWorldNameMenu
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001602")]
	private float NewScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001603")]
	public bool editingWorldName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
	[Cpp2IlInjected.Token(Token = "0x4001604")]
	public bool editWorldNameForCreate;

	[Cpp2IlInjected.Token(Token = "0x6000DE2")]
	[Cpp2IlInjected.Address(RVA = "0x1166004", Offset = "0x1166004", VA = "0x1166004")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000DE3")]
	[Cpp2IlInjected.Address(RVA = "0x1166654", Offset = "0x1166654", VA = "0x1166654")]
	public GUIWorldNameMenu()
	{
	}
}
