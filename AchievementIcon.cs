using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000118")]
public class AchievementIcon
{
	[Cpp2IlInjected.Token(Token = "0x4000904")]
	public static AchievementIcon Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000905")]
	public string SpriteTextureID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000906")]
	public string BorderTextureID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000907")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000908")]
	public int SpriteIconSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000909")]
	public int SpriteIconSizeWithSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400090A")]
	public int SpriteIconsPerRow;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400090B")]
	public Vector2 BorderLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400090C")]
	public Vector2 IconLocation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400090D")]
	public float IconScale;

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x11FC2B0", Offset = "0x11FC2B0", VA = "0x11FC2B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x11FC30C", Offset = "0x11FC30C", VA = "0x11FC30C")]
	public AchievementIcon()
	{
	}
}
