using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers;

[Cpp2IlInjected.Token(Token = "0x200050E")]
public struct CameraInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006807")]
	public Vector2 CameraPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006808")]
	public Vector2 OriginalCameraCenter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006809")]
	public Vector2 OriginalCameraPosition;

	[Cpp2IlInjected.Token(Token = "0x600380F")]
	[Cpp2IlInjected.Address(RVA = "0x39E4C8", Offset = "0x39E4C8", VA = "0x39E4C8")]
	public CameraInfo(Vector2 position)
	{
	}
}
