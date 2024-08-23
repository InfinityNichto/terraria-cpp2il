using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200015C RID: 348
[global::Cpp2ILInjected.Token(Token = "0x20001E1")]
[Serializable]
public class FavoriteIcons
{
	// Token: 0x06000B34 RID: 2868 RVA: 0x00023CE1 File Offset: 0x00021EE1
	[global::Cpp2ILInjected.Token(Token = "0x6000C47")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAD68", Offset = "0x9CAD68", Length = "0x104")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture_Layout), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
	public FavoriteIcons()
	{
		throw null;
	}

	// Token: 0x04000D36 RID: 3382
	[global::Cpp2ILInjected.Token(Token = "0x4001139")]
	public static FavoriteIcons Instance;

	// Token: 0x04000D37 RID: 3383
	[global::Cpp2ILInjected.Token(Token = "0x400113A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	// Token: 0x04000D38 RID: 3384
	[global::Cpp2ILInjected.Token(Token = "0x400113B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout NormalSelected;

	// Token: 0x04000D39 RID: 3385
	[global::Cpp2ILInjected.Token(Token = "0x400113C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Texture_Layout Favorite;

	// Token: 0x04000D3A RID: 3386
	[global::Cpp2ILInjected.Token(Token = "0x400113D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Texture_Layout FavoriteSelected;

	// Token: 0x04000D3B RID: 3387
	[global::Cpp2ILInjected.Token(Token = "0x400113E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout Disabled;
}
