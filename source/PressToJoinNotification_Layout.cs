using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200022F")]
public class PressToJoinNotification_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CF6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1470", Offset = "0x9D1470", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CF7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D14BC", Offset = "0x9D14BC", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PressToJoinNotification_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001680")]
	public static PressToJoinNotification_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001681")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001682")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout JoinText;

	[global::Cpp2ILInjected.Token(Token = "0x4001683")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float DisplayTime;
}
