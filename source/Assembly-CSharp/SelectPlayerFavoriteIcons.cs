using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000183 RID: 387
[global::Cpp2ILInjected.Token(Token = "0x200020D")]
[Serializable]
public class SelectPlayerFavoriteIcons
{
	// Token: 0x06000BA4 RID: 2980 RVA: 0x00023E31 File Offset: 0x00022031
	[global::Cpp2ILInjected.Token(Token = "0x6000CB9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFC00", Offset = "0x9CFC00", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public SelectPlayerFavoriteIcons()
	{
		throw null;
	}

	// Token: 0x04000F48 RID: 3912
	[global::Cpp2ILInjected.Token(Token = "0x4001395")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	// Token: 0x04000F49 RID: 3913
	[global::Cpp2ILInjected.Token(Token = "0x4001396")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout Disabled;
}
