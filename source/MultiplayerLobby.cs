using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200017C RID: 380
[global::Cpp2ILInjected.Token(Token = "0x2000206")]
[Serializable]
public class MultiplayerLobby
{
	// Token: 0x06000B96 RID: 2966 RVA: 0x00023E07 File Offset: 0x00022007
	[global::Cpp2ILInjected.Token(Token = "0x6000CAB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CF628", Offset = "0x9CF628", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public MultiplayerLobby()
	{
		throw null;
	}

	// Token: 0x04000ECE RID: 3790
	[global::Cpp2ILInjected.Token(Token = "0x400131B")]
	public static FavoriteIcons Instance;

	// Token: 0x04000ECF RID: 3791
	[global::Cpp2ILInjected.Token(Token = "0x400131C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	// Token: 0x04000ED0 RID: 3792
	[global::Cpp2ILInjected.Token(Token = "0x400131D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout Disabled;
}
