using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000117 RID: 279
[global::Cpp2ILInjected.Token(Token = "0x200018F")]
public class AchievementToast_Layout : LayoutDefinition
{
	// Token: 0x06000A3E RID: 2622 RVA: 0x000239FF File Offset: 0x00021BFF
	[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB948", Offset = "0x9AB948", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00023A02 File Offset: 0x00021C02
	[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB994", Offset = "0x9AB994", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public AchievementToast_Layout()
	{
		throw null;
	}

	// Token: 0x040008FE RID: 2302
	[global::Cpp2ILInjected.Token(Token = "0x4000C20")]
	public static AchievementToast_Layout Instance;

	// Token: 0x040008FF RID: 2303
	[global::Cpp2ILInjected.Token(Token = "0x4000C21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout achievementBacking;

	// Token: 0x04000900 RID: 2304
	[global::Cpp2ILInjected.Token(Token = "0x4000C22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout achievementTitle;

	// Token: 0x04000901 RID: 2305
	[global::Cpp2ILInjected.Token(Token = "0x4000C23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout achievementIcon;

	// Token: 0x04000902 RID: 2306
	[global::Cpp2ILInjected.Token(Token = "0x4000C24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int ToastsSpacing;

	// Token: 0x04000903 RID: 2307
	[global::Cpp2ILInjected.Token(Token = "0x4000C25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int ToastsTime;

	// Token: 0x04000904 RID: 2308
	[global::Cpp2ILInjected.Token(Token = "0x4000C26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool ReverseOrder;
}
