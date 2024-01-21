using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004EC")]
public struct VirtualCamera
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006741")]
	public readonly Player Player;

	[Cpp2IlInjected.Token(Token = "0x170006E3")]
	public Vector2 Position
	{
		[Cpp2IlInjected.Token(Token = "0x6003711")]
		[Cpp2IlInjected.Address(RVA = "0x39E038", Offset = "0x39E038", VA = "0x39E038")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006E4")]
	public Vector2 Size
	{
		[Cpp2IlInjected.Token(Token = "0x6003712")]
		[Cpp2IlInjected.Address(RVA = "0x39E04C", Offset = "0x39E04C", VA = "0x39E04C")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170006E5")]
	public Vector2 Center
	{
		[Cpp2IlInjected.Token(Token = "0x6003713")]
		[Cpp2IlInjected.Address(RVA = "0x39E05C", Offset = "0x39E05C", VA = "0x39E05C")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003710")]
	[Cpp2IlInjected.Address(RVA = "0x39E030", Offset = "0x39E030", VA = "0x39E030")]
	public VirtualCamera(Player player)
	{
	}
}
