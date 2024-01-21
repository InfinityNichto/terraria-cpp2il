using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000154")]
public class Hotbar_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000CFB")]
	public static Hotbar_Layout InstanceNormal;

	[Cpp2IlInjected.Token(Token = "0x4000CFC")]
	public static Hotbar_Layout Instance4Page;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000CFD")]
	public float SelectedScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000CFE")]
	public float NormalScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000CFF")]
	public float ScaleSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000D00")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000D01")]
	public String_Layout HorizontalTitle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000D02")]
	public ItemGrid_Layout HotbarGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000D03")]
	public ItemGrid_Layout HorizontalHotbarGrid;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public static Hotbar_Layout Instance
	{
		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0x116F028", Offset = "0x116F028", VA = "0x116F028")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x116F0A8", Offset = "0x116F0A8", VA = "0x116F0A8")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x116F128", Offset = "0x116F128", VA = "0x116F128")]
	public Hotbar_Layout()
	{
	}
}
