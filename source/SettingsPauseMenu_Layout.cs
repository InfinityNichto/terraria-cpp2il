using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200021D")]
public class SettingsPauseMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CCE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0470", Offset = "0x9D0470", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CCF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D04BC", Offset = "0x9D04BC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SettingsPauseMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40014BC")]
	public static SettingsPauseMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40014BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40014BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout JourneyBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40014BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Settings;

	[global::Cpp2ILInjected.Token(Token = "0x40014C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Home;

	[global::Cpp2ILInjected.Token(Token = "0x40014C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Achievements;

	[global::Cpp2ILInjected.Token(Token = "0x40014C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Bestiary;

	[global::Cpp2ILInjected.Token(Token = "0x40014C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout JourneySettings;

	[global::Cpp2ILInjected.Token(Token = "0x40014C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x40014C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float ButtonExtraPadding;
}
