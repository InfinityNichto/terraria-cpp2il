using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20002D5")]
public class UserStaticState
{
	[global::Cpp2ILInjected.Token(Token = "0x60010B4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4C2C4", Offset = "0xA4C2C4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public UserStaticState()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001FAE")]
	public static UserStaticState CurrentlyBound;

	[global::Cpp2ILInjected.Token(Token = "0x4001FAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public LockOnHelperStaticData LockOnHelper;
}
