using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000177 RID: 375
[global::Cpp2ILInjected.Token(Token = "0x2000201")]
public class MainMenu_Layout : LayoutDefinition
{
	// Token: 0x06000B8D RID: 2957 RVA: 0x00023DEC File Offset: 0x00021FEC
	[global::Cpp2ILInjected.Token(Token = "0x6000CA2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF390", Offset = "0x9CF390", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x00023DEF File Offset: 0x00021FEF
	[global::Cpp2ILInjected.Token(Token = "0x6000CA3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF3DC", Offset = "0x9CF3DC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public MainMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04000E64 RID: 3684
	[global::Cpp2ILInjected.Token(Token = "0x40012B1")]
	public static MainMenu_Layout Instance;

	// Token: 0x04000E65 RID: 3685
	[global::Cpp2ILInjected.Token(Token = "0x40012B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x04000E66 RID: 3686
	[global::Cpp2ILInjected.Token(Token = "0x40012B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Singleplayer;

	// Token: 0x04000E67 RID: 3687
	[global::Cpp2ILInjected.Token(Token = "0x40012B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Multiplayer;

	// Token: 0x04000E68 RID: 3688
	[global::Cpp2ILInjected.Token(Token = "0x40012B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Achievements;

	// Token: 0x04000E69 RID: 3689
	[global::Cpp2ILInjected.Token(Token = "0x40012B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Settings;

	// Token: 0x04000E6A RID: 3690
	[global::Cpp2ILInjected.Token(Token = "0x40012B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Tutorial;

	// Token: 0x04000E6B RID: 3691
	[global::Cpp2ILInjected.Token(Token = "0x40012B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Credits;

	// Token: 0x04000E6C RID: 3692
	[global::Cpp2ILInjected.Token(Token = "0x40012B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout PurchaseFullGame;

	// Token: 0x04000E6D RID: 3693
	[global::Cpp2ILInjected.Token(Token = "0x40012BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout PlayerProfile;

	// Token: 0x04000E6E RID: 3694
	[global::Cpp2ILInjected.Token(Token = "0x40012BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public String_Layout VersionNumber;

	// Token: 0x04000E6F RID: 3695
	[global::Cpp2ILInjected.Token(Token = "0x40012BC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public string VersionNumberText;

	// Token: 0x04000E70 RID: 3696
	[global::Cpp2ILInjected.Token(Token = "0x40012BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout Copyright;

	// Token: 0x04000E71 RID: 3697
	[global::Cpp2ILInjected.Token(Token = "0x40012BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public string CopyrightText;
}
