using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000476")]
public class SettingsForCharacterPreview
{
	[Cpp2IlInjected.Token(Token = "0x200092A")]
	public delegate void CustomAnimationCode(Projectile proj, bool walking);

	[Cpp2IlInjected.Token(Token = "0x200092B")]
	public struct SelectionBasedSettings
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008ABF")]
		public int StartFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008AC0")]
		public int FrameCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008AC1")]
		public int DelayPerFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008AC2")]
		public bool BounceLoop;

		[Cpp2IlInjected.Token(Token = "0x6004CD1")]
		[Cpp2IlInjected.Address(RVA = "0x39DAF8", Offset = "0x39DAF8", VA = "0x39DAF8")]
		public void ApplyTo(Projectile proj)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400642A")]
	public Vector2 Offset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400642B")]
	public SelectionBasedSettings Selected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400642C")]
	public SelectionBasedSettings NotSelected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400642D")]
	public int SpriteDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400642E")]
	public CustomAnimationCode CustomAnimation;

	[Cpp2IlInjected.Token(Token = "0x600323D")]
	[Cpp2IlInjected.Address(RVA = "0x122E850", Offset = "0x122E850", VA = "0x122E850")]
	public void ApplyTo(Projectile proj, bool walking)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600323E")]
	[Cpp2IlInjected.Address(RVA = "0x122EED4", Offset = "0x122EED4", VA = "0x122EED4")]
	public SettingsForCharacterPreview WhenSelected([Optional] int? startFrame, [Optional] int? frameCount, [Optional] int? delayPerFrame, [Optional] bool? bounceLoop)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600323F")]
	[Cpp2IlInjected.Address(RVA = "0x122F0A0", Offset = "0x122F0A0", VA = "0x122F0A0")]
	public SettingsForCharacterPreview WhenNotSelected([Optional] int? startFrame, [Optional] int? frameCount, [Optional] int? delayPerFrame, [Optional] bool? bounceLoop)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003240")]
	[Cpp2IlInjected.Address(RVA = "0x122EF0C", Offset = "0x122EF0C", VA = "0x122EF0C")]
	private static void Modify(ref SelectionBasedSettings target, int? startFrame, int? frameCount, int? delayPerFrame, bool? bounceLoop)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003241")]
	[Cpp2IlInjected.Address(RVA = "0x122F0D8", Offset = "0x122F0D8", VA = "0x122F0D8")]
	public SettingsForCharacterPreview WithOffset(Vector2 offset)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003242")]
	[Cpp2IlInjected.Address(RVA = "0x122F0E4", Offset = "0x122F0E4", VA = "0x122F0E4")]
	public SettingsForCharacterPreview WithOffset(float x, float y)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003243")]
	[Cpp2IlInjected.Address(RVA = "0x122F124", Offset = "0x122F124", VA = "0x122F124")]
	public SettingsForCharacterPreview WithSpriteDirection(int spriteDirection)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003244")]
	[Cpp2IlInjected.Address(RVA = "0x122F12C", Offset = "0x122F12C", VA = "0x122F12C")]
	public SettingsForCharacterPreview WithCode(CustomAnimationCode customAnimation)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003245")]
	[Cpp2IlInjected.Address(RVA = "0x122F134", Offset = "0x122F134", VA = "0x122F134")]
	public SettingsForCharacterPreview()
	{
	}
}
