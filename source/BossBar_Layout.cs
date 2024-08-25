using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000192")]
public class BossBar_Layout : LayoutDefinition
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000B51")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ABBD4", Offset = "0x9ABBD4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public BossBar_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000C6F")]
	public static BossBar_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000C70")]
	public static BossBar_Layout InstanceMobile;

	[global::Cpp2ILInjected.Token(Token = "0x4000C71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout BarBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout BarFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4000C73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout BossIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000C74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Panel_Layout ControllerBarBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout ControllerBarFrame;

	[global::Cpp2ILInjected.Token(Token = "0x4000C76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ControllerBossIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000C77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Texture_Layout LifeCap;

	[global::Cpp2ILInjected.Token(Token = "0x4000C78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Texture_Layout LifeFill;

	[global::Cpp2ILInjected.Token(Token = "0x4000C79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Texture_Layout ShieldCap;

	[global::Cpp2ILInjected.Token(Token = "0x4000C7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Texture_Layout ShieldFill;

	[global::Cpp2ILInjected.Token(Token = "0x4000C7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public bool RemainingOnly;

	[global::Cpp2ILInjected.Token(Token = "0x4000C7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public String_Layout HealthAmount;
}
