using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.Events;

[Cpp2IlInjected.Token(Token = "0x2000694")]
public class MoonlordDeathDrama
{
	[Cpp2IlInjected.Token(Token = "0x2000A94")]
	public class MoonlordPiece
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008EC6")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008EC7")]
		private Vector2 _position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008EC8")]
		private Vector2 _velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008EC9")]
		private Vector2 _origin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008ECA")]
		private float _rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4008ECB")]
		private float _rotationVelocity;

		[Cpp2IlInjected.Token(Token = "0x17000901")]
		public bool Dead
		{
			[Cpp2IlInjected.Token(Token = "0x6005252")]
			[Cpp2IlInjected.Address(RVA = "0xF5E210", Offset = "0xF5E210", VA = "0xF5E210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600524F")]
		[Cpp2IlInjected.Address(RVA = "0xF5FDE0", Offset = "0xF5FDE0", VA = "0xF5FDE0")]
		public MoonlordPiece(Texture2D pieceTexture, Vector2 textureOrigin, Vector2 centerPos, Vector2 velocity, float rot, float angularVelocity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005250")]
		[Cpp2IlInjected.Address(RVA = "0xF5E124", Offset = "0xF5E124", VA = "0xF5E124")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005251")]
		[Cpp2IlInjected.Address(RVA = "0xF5E8B0", Offset = "0xF5E8B0", VA = "0xF5E8B0")]
		public void Draw(SpriteBatch sp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005253")]
		[Cpp2IlInjected.Address(RVA = "0xF5E7F8", Offset = "0xF5E7F8", VA = "0xF5E7F8")]
		public bool InDrawRange(Rectangle playerScreen)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6005254")]
		[Cpp2IlInjected.Address(RVA = "0xF603C8", Offset = "0xF603C8", VA = "0xF603C8")]
		public Color GetLight()
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A95")]
	public class MoonlordExplosion
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008ECC")]
		private Texture2D _texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008ECD")]
		private Vector2 _position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008ECE")]
		private Vector2 _origin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008ECF")]
		private Rectangle _frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4008ED0")]
		private int _frameCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4008ED1")]
		private int _frameSpeed;

		[Cpp2IlInjected.Token(Token = "0x17000902")]
		public bool Dead
		{
			[Cpp2IlInjected.Token(Token = "0x6005258")]
			[Cpp2IlInjected.Address(RVA = "0xF5E3F8", Offset = "0xF5E3F8", VA = "0xF5E3F8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005255")]
		[Cpp2IlInjected.Address(RVA = "0xF60014", Offset = "0xF60014", VA = "0xF60014")]
		public MoonlordExplosion(Texture2D pieceTexture, Vector2 centerPos, int frameSpeed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005256")]
		[Cpp2IlInjected.Address(RVA = "0xF5E324", Offset = "0xF5E324", VA = "0xF5E324")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005257")]
		[Cpp2IlInjected.Address(RVA = "0xF5ED7C", Offset = "0xF5ED7C", VA = "0xF5ED7C")]
		public void Draw(SpriteBatch sp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005259")]
		[Cpp2IlInjected.Address(RVA = "0xF5ECC4", Offset = "0xF5ECC4", VA = "0xF5ECC4")]
		public bool InDrawRange(Rectangle playerScreen)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600525A")]
		[Cpp2IlInjected.Address(RVA = "0xF60388", Offset = "0xF60388", VA = "0xF60388")]
		public Color GetLight()
		{
			return default(Color);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006DFE")]
	private static List<MoonlordPiece> _pieces;

	[Cpp2IlInjected.Token(Token = "0x4006DFF")]
	private static List<MoonlordExplosion> _explosions;

	[Cpp2IlInjected.Token(Token = "0x4006E00")]
	private static List<Vector2> _lightSources;

	[Cpp2IlInjected.Token(Token = "0x4006E01")]
	private static float whitening;

	[Cpp2IlInjected.Token(Token = "0x4006E02")]
	private static float requestedLight;

	[Cpp2IlInjected.Token(Token = "0x6004252")]
	[Cpp2IlInjected.Address(RVA = "0xF5DBE4", Offset = "0xF5DBE4", VA = "0xF5DBE4")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004253")]
	[Cpp2IlInjected.Address(RVA = "0xF5E520", Offset = "0xF5E520", VA = "0xF5E520")]
	public static void DrawPieces(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004254")]
	[Cpp2IlInjected.Address(RVA = "0xF5E9EC", Offset = "0xF5E9EC", VA = "0xF5E9EC")]
	public static void DrawExplosions(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004255")]
	[Cpp2IlInjected.Address(RVA = "0xF5EF24", Offset = "0xF5EF24", VA = "0xF5EF24")]
	public static void DrawWhite(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004256")]
	[Cpp2IlInjected.Address(RVA = "0xF5F198", Offset = "0xF5F198", VA = "0xF5F198")]
	public static void ThrowPieces(Vector2 MoonlordCoreCenter, int DramaSeed)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004257")]
	[Cpp2IlInjected.Address(RVA = "0xF5FE38", Offset = "0xF5FE38", VA = "0xF5FE38")]
	public static void AddExplosion(Vector2 spot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004258")]
	[Cpp2IlInjected.Address(RVA = "0xF60164", Offset = "0xF60164", VA = "0xF60164")]
	public static void RequestLight(float light, Vector2 spot)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004259")]
	[Cpp2IlInjected.Address(RVA = "0xF60280", Offset = "0xF60280", VA = "0xF60280")]
	public MoonlordDeathDrama()
	{
	}
}
