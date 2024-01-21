using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000140")]
public class TransactionButtonStyleDefinitions : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4000B06")]
	public static TransactionButtonStyleDefinitions Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000B07")]
	public List<TransactionButtonStyle_Definition> Definitions;

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x10D105C", Offset = "0x10D105C", VA = "0x10D105C")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x10D10B8", Offset = "0x10D10B8", VA = "0x10D10B8")]
	public static TransactionButtonStyle_Definition GetDefinition(string id)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x10D1244", Offset = "0x10D1244", VA = "0x10D1244")]
	public TransactionButtonStyleDefinitions()
	{
	}
}
