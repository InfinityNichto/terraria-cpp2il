using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x20006A3")]
public class NewMultiplayerClosePlayersOverlay : IMultiplayerClosePlayersOverlay
{
	[Cpp2IlInjected.Token(Token = "0x2000A98")]
	private struct PlayerOnScreenCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008EDE")]
		private string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008EDF")]
		private Vector2 _pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008EE0")]
		private Color _color;

		[Cpp2IlInjected.Token(Token = "0x6005262")]
		[Cpp2IlInjected.Address(RVA = "0x39BC20", Offset = "0x39BC20", VA = "0x39BC20")]
		public PlayerOnScreenCache(string name, Vector2 pos, Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005263")]
		[Cpp2IlInjected.Address(RVA = "0x39BC30", Offset = "0x39BC30", VA = "0x39BC30")]
		public void DrawPlayerName_WhenPlayerIsOnScreen(SpriteBatch spriteBatch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A99")]
	private struct PlayerOffScreenCache
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008EE1")]
		private Player player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008EE2")]
		private string nameToShow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008EE3")]
		private Vector2 namePlatePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008EE4")]
		private Color namePlateColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008EE5")]
		private Vector2 distanceDrawPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008EE6")]
		private string distanceString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008EE7")]
		private Vector2 measurement;

		[Cpp2IlInjected.Token(Token = "0x6005264")]
		[Cpp2IlInjected.Address(RVA = "0x39BB2C", Offset = "0x39BB2C", VA = "0x39BB2C")]
		public PlayerOffScreenCache(string name, Vector2 pos, Color color, Vector2 npDistPos, string npDist, Player thePlayer, Vector2 theMeasurement)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005265")]
		[Cpp2IlInjected.Address(RVA = "0x39BB80", Offset = "0x39BB80", VA = "0x39BB80")]
		public void DrawPlayerName(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005266")]
		[Cpp2IlInjected.Address(RVA = "0x39BB88", Offset = "0x39BB88", VA = "0x39BB88")]
		public void DrawPlayerHead()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005267")]
		[Cpp2IlInjected.Address(RVA = "0x39BB90", Offset = "0x39BB90", VA = "0x39BB90")]
		public void DrawLifeBar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005268")]
		[Cpp2IlInjected.Address(RVA = "0x39BB98", Offset = "0x39BB98", VA = "0x39BB98")]
		public void DrawPlayerDistance(SpriteBatch spriteBatch)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006ECB")]
	private List<PlayerOnScreenCache> _playerOnScreenCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006ECC")]
	private List<PlayerOffScreenCache> _playerOffScreenCache;

	[Cpp2IlInjected.Token(Token = "0x60042CA")]
	[Cpp2IlInjected.Address(RVA = "0x109DB7C", Offset = "0x109DB7C", VA = "0x109DB7C", Slot = "4")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042CB")]
	[Cpp2IlInjected.Address(RVA = "0x109E810", Offset = "0x109E810", VA = "0x109E810")]
	private static void GetDistance(int testWidth, int testHeight, Vector2 testPosition, Player localPlayer, SpriteFont font, Player player, string nameToShow, out Vector2 namePlatePos, out float namePlateDist, out Vector2 measurement)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042CC")]
	[Cpp2IlInjected.Address(RVA = "0x109FD24", Offset = "0x109FD24", VA = "0x109FD24")]
	public NewMultiplayerClosePlayersOverlay()
	{
	}
}
