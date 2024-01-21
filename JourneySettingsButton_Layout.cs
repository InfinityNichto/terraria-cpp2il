using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000160")]
public class JourneySettingsButton_Layout : SettingsOverlayListOption_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000D96")]
	public TransactionButton_Layout Icon;

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x1178C88", Offset = "0x1178C88", VA = "0x1178C88")]
	public JourneySettingsButton_Layout()
	{
	}
}
