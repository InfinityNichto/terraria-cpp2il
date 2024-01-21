using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000504")]
public class LegacyPlayerRenderer : IPlayerRenderer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067DD")]
	private readonly DrawData[] _drawData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067DE")]
	private readonly List<int> _dust;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40067DF")]
	private readonly List<int> _gore;

	[Cpp2IlInjected.Token(Token = "0x40067E0")]
	private static Vector2[] OutlineOffsets;

	[Cpp2IlInjected.Token(Token = "0x170006F3")]
	public static SamplerState MountedSamplerState
	{
		[Cpp2IlInjected.Token(Token = "0x60037BF")]
		[Cpp2IlInjected.Address(RVA = "0x123F174", Offset = "0x123F174", VA = "0x123F174")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60037C0")]
	[Cpp2IlInjected.Address(RVA = "0x123F25C", Offset = "0x123F25C", VA = "0x123F25C", Slot = "4")]
	public void DrawPlayers(Camera camera, IEnumerable<Player> players)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C1")]
	[Cpp2IlInjected.Address(RVA = "0x12408A4", Offset = "0x12408A4", VA = "0x12408A4", Slot = "5")]
	public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C2")]
	[Cpp2IlInjected.Address(RVA = "0x1240B84", Offset = "0x1240B84", VA = "0x1240B84")]
	private void RenderOutlines(int count, float alpha, float scale, Color borderColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C3")]
	[Cpp2IlInjected.Address(RVA = "0x12413F0", Offset = "0x12413F0", VA = "0x12413F0", Slot = "6")]
	public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C4")]
	[Cpp2IlInjected.Address(RVA = "0x1241C8C", Offset = "0x1241C8C", VA = "0x1241C8C")]
	private static void DrawPlayer_MountTransformation(ref PlayerDrawSet drawInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C5")]
	[Cpp2IlInjected.Address(RVA = "0x124170C", Offset = "0x124170C", VA = "0x124170C")]
	private static void DrawPlayer_UseNormalLayers(ref PlayerDrawSet drawInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C6")]
	[Cpp2IlInjected.Address(RVA = "0x123F5E8", Offset = "0x123F5E8", VA = "0x123F5E8")]
	private void DrawPlayerFull(Camera camera, Player drawPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C7")]
	[Cpp2IlInjected.Address(RVA = "0x1242274", Offset = "0x1242274", VA = "0x1242274")]
	private void DrawPlayerStoned(Camera camera, Player drawPlayer, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C8")]
	[Cpp2IlInjected.Address(RVA = "0x1241D7C", Offset = "0x1241D7C", VA = "0x1241D7C")]
	private void DrawGhost(Camera camera, Player drawPlayer, Vector2 position, float shadow = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037C9")]
	[Cpp2IlInjected.Address(RVA = "0x12426F0", Offset = "0x12426F0", VA = "0x12426F0")]
	public LegacyPlayerRenderer()
	{
	}
}
