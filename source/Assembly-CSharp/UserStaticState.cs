using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000228 RID: 552
[global::Cpp2ILInjected.Token(Token = "0x20002D5")]
public class UserStaticState
{
	// Token: 0x06000F7B RID: 3963 RVA: 0x0002496E File Offset: 0x00022B6E
	[global::Cpp2ILInjected.Token(Token = "0x60010B4")]
	[global::Cpp2ILInjected.Address(RVA = "0xA4C2C4", Offset = "0xA4C2C4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public UserStaticState()
	{
		throw null;
	}

	// Token: 0x04001A59 RID: 6745
	[global::Cpp2ILInjected.Token(Token = "0x4001FAE")]
	public static UserStaticState CurrentlyBound;

	// Token: 0x04001A5A RID: 6746
	[global::Cpp2ILInjected.Token(Token = "0x4001FAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public LockOnHelperStaticData LockOnHelper;
}
