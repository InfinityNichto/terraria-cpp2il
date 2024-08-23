using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000198 RID: 408
[global::Cpp2ILInjected.Token(Token = "0x2000226")]
[Serializable]
public class SelectWorldFavoriteIcons
{
	// Token: 0x06000BC7 RID: 3015 RVA: 0x00023E9A File Offset: 0x0002209A
	[global::Cpp2ILInjected.Token(Token = "0x6000CE0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0BC0", Offset = "0x9D0BC0", Length = "0xB0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public SelectWorldFavoriteIcons()
	{
		throw null;
	}

	// Token: 0x040010F3 RID: 4339
	[global::Cpp2ILInjected.Token(Token = "0x400158D")]
	public static FavoriteIcons Instance;

	// Token: 0x040010F4 RID: 4340
	[global::Cpp2ILInjected.Token(Token = "0x400158E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	// Token: 0x040010F5 RID: 4341
	[global::Cpp2ILInjected.Token(Token = "0x400158F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout Disabled;
}
