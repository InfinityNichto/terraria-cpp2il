using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

// Token: 0x02000116 RID: 278
[global::Cpp2ILInjected.Token(Token = "0x200018E")]
[Serializable]
public class AchievementIcon
{
	// Token: 0x06000A3C RID: 2620 RVA: 0x000239F9 File Offset: 0x00021BF9
	[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB888", Offset = "0x9AB888", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x000239FC File Offset: 0x00021BFC
	[global::Cpp2ILInjected.Token(Token = "0x6000B4A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB8D4", Offset = "0x9AB8D4", Length = "0x74")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public AchievementIcon()
	{
		throw null;
	}

	// Token: 0x040008F4 RID: 2292
	[global::Cpp2ILInjected.Token(Token = "0x4000C16")]
	public static AchievementIcon Instance;

	// Token: 0x040008F5 RID: 2293
	[global::Cpp2ILInjected.Token(Token = "0x4000C17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string SpriteTextureID;

	// Token: 0x040008F6 RID: 2294
	[global::Cpp2ILInjected.Token(Token = "0x4000C18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string BorderTextureID;

	// Token: 0x040008F7 RID: 2295
	[global::Cpp2ILInjected.Token(Token = "0x4000C19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	// Token: 0x040008F8 RID: 2296
	[global::Cpp2ILInjected.Token(Token = "0x4000C1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int SpriteIconSize;

	// Token: 0x040008F9 RID: 2297
	[global::Cpp2ILInjected.Token(Token = "0x4000C1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int SpriteIconSizeWithSpace;

	// Token: 0x040008FA RID: 2298
	[global::Cpp2ILInjected.Token(Token = "0x4000C1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int SpriteIconsPerRow;

	// Token: 0x040008FB RID: 2299
	[global::Cpp2ILInjected.Token(Token = "0x4000C1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 BorderLocation;

	// Token: 0x040008FC RID: 2300
	[global::Cpp2ILInjected.Token(Token = "0x4000C1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 IconLocation;

	// Token: 0x040008FD RID: 2301
	[global::Cpp2ILInjected.Token(Token = "0x4000C1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float IconScale;
}
