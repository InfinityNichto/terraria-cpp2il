using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.ObjectInteractions;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000507")]
internal class ReturnGatePlayerRenderer : IPlayerRenderer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067E6")]
	private List<DrawData> _voidLensData;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067E7")]
	private PotionOfReturnGateInteractionChecker _interactionChecker;

	[Cpp2IlInjected.Token(Token = "0x60037D7")]
	[Cpp2IlInjected.Address(RVA = "0x1245958", Offset = "0x1245958", VA = "0x1245958", Slot = "4")]
	public void DrawPlayers(Camera camera, IEnumerable<Player> players)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D8")]
	[Cpp2IlInjected.Address(RVA = "0x1246438", Offset = "0x1246438", VA = "0x1246438", Slot = "5")]
	public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D9")]
	[Cpp2IlInjected.Address(RVA = "0x1246440", Offset = "0x1246440", VA = "0x1246440", Slot = "6")]
	public void DrawPlayer(Camera camera, Player drawPlayer, Vector2 position, float rotation, Vector2 rotationOrigin, float shadow = 0f, float scale = 1f, [Optional] Vector2[] positionalOffsets)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037DA")]
	[Cpp2IlInjected.Address(RVA = "0x124643C", Offset = "0x124643C", VA = "0x124643C")]
	private void DrawReturnGateInMap(Camera camera, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037DB")]
	[Cpp2IlInjected.Address(RVA = "0x1246444", Offset = "0x1246444", VA = "0x1246444")]
	public void OverReturnGateInWorld(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037DC")]
	[Cpp2IlInjected.Address(RVA = "0x1245BF8", Offset = "0x1245BF8", VA = "0x1245BF8")]
	private void DrawReturnGateInWorld(Camera camera, Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037DD")]
	[Cpp2IlInjected.Address(RVA = "0x12469EC", Offset = "0x12469EC", VA = "0x12469EC")]
	public ReturnGatePlayerRenderer()
	{
	}
}
