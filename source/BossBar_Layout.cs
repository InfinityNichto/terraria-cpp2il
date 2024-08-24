using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200011A RID: 282
[global::Cpp2ILInjected.Token(Token = "0x2000192")]
public class BossBar_Layout : LayoutDefinition
{
	// Token: 0x06000A43 RID: 2627 RVA: 0x00023A0E File Offset: 0x00021C0E
	[global::Cpp2ILInjected.Token(Token = "0x6000B50")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABB50", Offset = "0x9ABB50", Length = "0x84")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00023A11 File Offset: 0x00021C11
	[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABBD4", Offset = "0x9ABBD4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public BossBar_Layout()
	{
		throw null;
	}

	// Token: 0x0400094D RID: 2381
	[global::Cpp2ILInjected.Token(Token = "0x4000C6F")]
	public static BossBar_Layout Instance;

	// Token: 0x0400094E RID: 2382
	[global::Cpp2ILInjected.Token(Token = "0x4000C70")]
	public static BossBar_Layout InstanceMobile;

	// Token: 0x0400094F RID: 2383
	[global::Cpp2ILInjected.Token(Token = "0x4000C71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout BarBacking;

	// Token: 0x04000950 RID: 2384
	[global::Cpp2ILInjected.Token(Token = "0x4000C72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout BarFrame;

	// Token: 0x04000951 RID: 2385
	[global::Cpp2ILInjected.Token(Token = "0x4000C73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout BossIcon;

	// Token: 0x04000952 RID: 2386
	[global::Cpp2ILInjected.Token(Token = "0x4000C74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout ControllerBarBacking;

	// Token: 0x04000953 RID: 2387
	[global::Cpp2ILInjected.Token(Token = "0x4000C75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout ControllerBarFrame;

	// Token: 0x04000954 RID: 2388
	[global::Cpp2ILInjected.Token(Token = "0x4000C76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ControllerBossIcon;

	// Token: 0x04000955 RID: 2389
	[global::Cpp2ILInjected.Token(Token = "0x4000C77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Texture_Layout LifeCap;

	// Token: 0x04000956 RID: 2390
	[global::Cpp2ILInjected.Token(Token = "0x4000C78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout LifeFill;

	// Token: 0x04000957 RID: 2391
	[global::Cpp2ILInjected.Token(Token = "0x4000C79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout ShieldCap;

	// Token: 0x04000958 RID: 2392
	[global::Cpp2ILInjected.Token(Token = "0x4000C7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout ShieldFill;

	// Token: 0x04000959 RID: 2393
	[global::Cpp2ILInjected.Token(Token = "0x4000C7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public bool RemainingOnly;

	// Token: 0x0400095A RID: 2394
	[global::Cpp2ILInjected.Token(Token = "0x4000C7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout HealthAmount;
}
