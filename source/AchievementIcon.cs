using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x200018E")]
[Serializable]
public class AchievementIcon
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B49")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AB888", Offset = "0x9AB888", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

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

	[global::Cpp2ILInjected.Token(Token = "0x4000C16")]
	public static AchievementIcon Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000C17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string SpriteTextureID;

	[global::Cpp2ILInjected.Token(Token = "0x4000C18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string BorderTextureID;

	[global::Cpp2ILInjected.Token(Token = "0x4000C19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000C1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int SpriteIconSize;

	[global::Cpp2ILInjected.Token(Token = "0x4000C1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int SpriteIconSizeWithSpace;

	[global::Cpp2ILInjected.Token(Token = "0x4000C1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int SpriteIconsPerRow;

	[global::Cpp2ILInjected.Token(Token = "0x4000C1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public Vector2 BorderLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000C1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public Vector2 IconLocation;

	[global::Cpp2ILInjected.Token(Token = "0x4000C1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float IconScale;
}
