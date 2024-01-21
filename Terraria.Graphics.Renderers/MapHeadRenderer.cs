using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x2000505")]
public class MapHeadRenderer : INeedRenderTargetContent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40067E1")]
	private bool _anyDirty;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40067E2")]
	private PlayerHeadDrawRenderTargetContent[] _playerRenders;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40067E3")]
	private readonly List<DrawData> _drawData;

	[Cpp2IlInjected.Token(Token = "0x170006F4")]
	public bool IsReady
	{
		[Cpp2IlInjected.Token(Token = "0x60037CF")]
		[Cpp2IlInjected.Address(RVA = "0x1243934", Offset = "0x1243934", VA = "0x1243934", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60037CB")]
	[Cpp2IlInjected.Address(RVA = "0x12432C0", Offset = "0x12432C0", VA = "0x12432C0")]
	public MapHeadRenderer()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037CC")]
	[Cpp2IlInjected.Address(RVA = "0x12433DC", Offset = "0x12433DC", VA = "0x12433DC", Slot = "6")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037CD")]
	[Cpp2IlInjected.Address(RVA = "0x1243474", Offset = "0x1243474", VA = "0x1243474")]
	public void DrawPlayerHead(Camera camera, Player drawPlayer, Vector2 position, float alpha = 1f, float scale = 1f, [Optional] Color borderColor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037CE")]
	[Cpp2IlInjected.Address(RVA = "0x124373C", Offset = "0x124373C", VA = "0x124373C")]
	private void RenderDrawData(Player drawPlayer)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D0")]
	[Cpp2IlInjected.Address(RVA = "0x1243944", Offset = "0x1243944", VA = "0x1243944", Slot = "5")]
	public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60037D1")]
	[Cpp2IlInjected.Address(RVA = "0x12439B0", Offset = "0x12439B0", VA = "0x12439B0")]
	private void CreateOutlines(float alpha, float scale, Color borderColor)
	{
	}
}
