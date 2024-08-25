using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200018F")]
public class AchievementToast_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B4B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB948", Offset = "0x9AB948", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B4C")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB994", Offset = "0x9AB994", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public AchievementToast_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000C20")]
	public static AchievementToast_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000C21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout achievementBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000C22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout achievementTitle;

	[global::Cpp2ILInjected.Token(Token = "0x4000C23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout achievementIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000C24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int ToastsSpacing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int ToastsTime;

	[global::Cpp2ILInjected.Token(Token = "0x4000C26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool ReverseOrder;
}
