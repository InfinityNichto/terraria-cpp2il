using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Enums;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200043F")]
public struct NPCAimedTarget
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006309")]
	public NPCTargetType Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400630A")]
	public Rectangle Hitbox;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400630B")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400630C")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400630D")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400630E")]
	public Vector2 Velocity;

	[Cpp2IlInjected.Token(Token = "0x1700061B")]
	public bool Invalid
	{
		[Cpp2IlInjected.Token(Token = "0x6003151")]
		[Cpp2IlInjected.Address(RVA = "0x39B0D0", Offset = "0x39B0D0", VA = "0x39B0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700061C")]
	public Vector2 Center
	{
		[Cpp2IlInjected.Token(Token = "0x6003152")]
		[Cpp2IlInjected.Address(RVA = "0x39B0E0", Offset = "0x39B0E0", VA = "0x39B0E0")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700061D")]
	public Vector2 Size
	{
		[Cpp2IlInjected.Token(Token = "0x6003153")]
		[Cpp2IlInjected.Address(RVA = "0x39B0F4", Offset = "0x39B0F4", VA = "0x39B0F4")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003154")]
	[Cpp2IlInjected.Address(RVA = "0x39B12C", Offset = "0x39B12C", VA = "0x39B12C")]
	public NPCAimedTarget(NPC npc)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003155")]
	[Cpp2IlInjected.Address(RVA = "0x39B134", Offset = "0x39B134", VA = "0x39B134")]
	public NPCAimedTarget(Player player, bool ignoreTank = true)
	{
	}
}
