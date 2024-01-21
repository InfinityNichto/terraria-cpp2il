using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000552")]
public class PlayerHeadDrawRenderTargetContent : AnOutlinedDrawRenderTargetContent
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40068F5")]
	private Player _player;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40068F6")]
	private readonly DrawData[] _drawData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40068F7")]
	private readonly List<int> _dust;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40068F8")]
	private readonly List<int> _gore;

	[Cpp2IlInjected.Token(Token = "0x6003A0D")]
	[Cpp2IlInjected.Address(RVA = "0x1198E70", Offset = "0x1198E70", VA = "0x1198E70")]
	public void UsePlayer(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A0E")]
	[Cpp2IlInjected.Address(RVA = "0x1198E78", Offset = "0x1198E78", VA = "0x1198E78", Slot = "8")]
	internal override void DrawTheContent(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A0F")]
	[Cpp2IlInjected.Address(RVA = "0x1198FE0", Offset = "0x1198FE0", VA = "0x1198FE0")]
	public PlayerHeadDrawRenderTargetContent()
	{
	}
}
