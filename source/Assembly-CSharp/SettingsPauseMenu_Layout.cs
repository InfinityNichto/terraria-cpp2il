using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000191 RID: 401
[global::Cpp2ILInjected.Token(Token = "0x200021D")]
public class SettingsPauseMenu_Layout : LayoutDefinition
{
	// Token: 0x06000BB8 RID: 3000 RVA: 0x00023E6D File Offset: 0x0002206D
	[global::Cpp2ILInjected.Token(Token = "0x6000CCE")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0470", Offset = "0x9D0470", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00023E70 File Offset: 0x00022070
	[global::Cpp2ILInjected.Token(Token = "0x6000CCF")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D04BC", Offset = "0x9D04BC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public SettingsPauseMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04001058 RID: 4184
	[global::Cpp2ILInjected.Token(Token = "0x40014BC")]
	public static SettingsPauseMenu_Layout Instance;

	// Token: 0x04001059 RID: 4185
	[global::Cpp2ILInjected.Token(Token = "0x40014BD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	// Token: 0x0400105A RID: 4186
	[global::Cpp2ILInjected.Token(Token = "0x40014BE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout JourneyBacking;

	// Token: 0x0400105B RID: 4187
	[global::Cpp2ILInjected.Token(Token = "0x40014BF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Settings;

	// Token: 0x0400105C RID: 4188
	[global::Cpp2ILInjected.Token(Token = "0x40014C0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Home;

	// Token: 0x0400105D RID: 4189
	[global::Cpp2ILInjected.Token(Token = "0x40014C1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout Achievements;

	// Token: 0x0400105E RID: 4190
	[global::Cpp2ILInjected.Token(Token = "0x40014C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Bestiary;

	// Token: 0x0400105F RID: 4191
	[global::Cpp2ILInjected.Token(Token = "0x40014C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout JourneySettings;

	// Token: 0x04001060 RID: 4192
	[global::Cpp2ILInjected.Token(Token = "0x40014C4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Close;

	// Token: 0x04001061 RID: 4193
	[global::Cpp2ILInjected.Token(Token = "0x40014C5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public float ButtonExtraPadding;
}
