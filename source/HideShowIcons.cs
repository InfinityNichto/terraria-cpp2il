using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200014E RID: 334
[global::Cpp2ILInjected.Token(Token = "0x20001D3")]
[Serializable]
public class HideShowIcons
{
	// Token: 0x06000AF6 RID: 2806 RVA: 0x00023C27 File Offset: 0x00021E27
	[global::Cpp2ILInjected.Token(Token = "0x6000C09")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6498", Offset = "0x9B6498", Length = "0x164")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public HideShowIcons()
	{
		throw null;
	}

	// Token: 0x04000CA6 RID: 3238
	[global::Cpp2ILInjected.Token(Token = "0x40010A9")]
	public static FavoriteIcons Instance;

	// Token: 0x04000CA7 RID: 3239
	[global::Cpp2ILInjected.Token(Token = "0x40010AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Texture_Layout Normal;

	// Token: 0x04000CA8 RID: 3240
	[global::Cpp2ILInjected.Token(Token = "0x40010AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Texture_Layout NormalHighlight;

	// Token: 0x04000CA9 RID: 3241
	[global::Cpp2ILInjected.Token(Token = "0x40010AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Texture_Layout Active;

	// Token: 0x04000CAA RID: 3242
	[global::Cpp2ILInjected.Token(Token = "0x40010AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Texture_Layout ActiveHighlight;

	// Token: 0x04000CAB RID: 3243
	[global::Cpp2ILInjected.Token(Token = "0x40010AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Texture_Layout MinecartNormal;

	// Token: 0x04000CAC RID: 3244
	[global::Cpp2ILInjected.Token(Token = "0x40010AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Texture_Layout MinecartNormalHighlight;

	// Token: 0x04000CAD RID: 3245
	[global::Cpp2ILInjected.Token(Token = "0x40010B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Texture_Layout MinecartActive;

	// Token: 0x04000CAE RID: 3246
	[global::Cpp2ILInjected.Token(Token = "0x40010B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Texture_Layout MinecartActiveHighlight;
}
