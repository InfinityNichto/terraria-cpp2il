using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000201")]
public class MainMenu_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CA2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF390", Offset = "0x9CF390", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CA3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF3DC", Offset = "0x9CF3DC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MainMenu_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40012B1")]
	public static MainMenu_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40012B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x40012B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Singleplayer;

	[global::Cpp2ILInjected.Token(Token = "0x40012B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Multiplayer;

	[global::Cpp2ILInjected.Token(Token = "0x40012B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Achievements;

	[global::Cpp2ILInjected.Token(Token = "0x40012B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Settings;

	[global::Cpp2ILInjected.Token(Token = "0x40012B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Tutorial;

	[global::Cpp2ILInjected.Token(Token = "0x40012B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Credits;

	[global::Cpp2ILInjected.Token(Token = "0x40012B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout PurchaseFullGame;

	[global::Cpp2ILInjected.Token(Token = "0x40012BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout PlayerProfile;

	[global::Cpp2ILInjected.Token(Token = "0x40012BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout VersionNumber;

	[global::Cpp2ILInjected.Token(Token = "0x40012BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public string VersionNumberText;

	[global::Cpp2ILInjected.Token(Token = "0x40012BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout Copyright;

	[global::Cpp2ILInjected.Token(Token = "0x40012BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public string CopyrightText;
}
