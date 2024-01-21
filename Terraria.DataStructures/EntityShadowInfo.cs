using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200042C")]
public struct EntityShadowInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40062DA")]
	public Vector2 Position;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062DB")]
	public float Rotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062DC")]
	public Vector2 Origin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40062DD")]
	public int Direction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40062DE")]
	public int GravityDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40062DF")]
	public int BodyFrameIndex;

	[Cpp2IlInjected.Token(Token = "0x1700060C")]
	public Vector2 HeadgearOffset
	{
		[Cpp2IlInjected.Token(Token = "0x600310F")]
		[Cpp2IlInjected.Address(RVA = "0x39AE7C", Offset = "0x39AE7C", VA = "0x39AE7C")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600310E")]
	[Cpp2IlInjected.Address(RVA = "0x39AE18", Offset = "0x39AE18", VA = "0x39AE18")]
	public void CopyPlayer(Player player)
	{
	}
}
