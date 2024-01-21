using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.Graphics;

[StructLayout(0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20004E0")]
public struct SpriteRenderTargetHelper
{
	[Cpp2IlInjected.Token(Token = "0x60036CF")]
	[Cpp2IlInjected.Address(RVA = "0x124B440", Offset = "0x124B440", VA = "0x124B440")]
	public static void GetDrawBoundary(int playerDrawDataCount, DrawData[] playerDrawData, out Vector2 lowest, out Vector2 highest)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036D0")]
	[Cpp2IlInjected.Address(RVA = "0x124B658", Offset = "0x124B658", VA = "0x124B658")]
	public static void GetHighsAndLowsOf(ref Vector2 lowest, ref Vector2 highest, ref DrawData cdd)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036D1")]
	[Cpp2IlInjected.Address(RVA = "0x124B7DC", Offset = "0x124B7DC", VA = "0x124B7DC")]
	public static void GetHighsAndLowsOf(ref Vector2 lowest, ref Vector2 highest, ref DrawData cdd, ref Vector2 pos, ref Vector2 origin, Vector2 corner)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60036D2")]
	[Cpp2IlInjected.Address(RVA = "0x124B8E0", Offset = "0x124B8E0", VA = "0x124B8E0")]
	public static Vector2 GetCorner(ref DrawData cdd, ref Vector2 pos, ref Vector2 origin, Vector2 corner)
	{
		return default(Vector2);
	}
}
