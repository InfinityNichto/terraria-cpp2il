using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent.UI;

[Cpp2IlInjected.Token(Token = "0x20006A4")]
public class WiresUI
{
	[Cpp2IlInjected.Token(Token = "0x2000A9A")]
	public static class Settings
	{
		[Cpp2IlInjected.Token(Token = "0x2000BC9")]
		[Flags]
		public enum MultiToolMode
		{
			[Cpp2IlInjected.Token(Token = "0x400914D")]
			Red = 1,
			[Cpp2IlInjected.Token(Token = "0x400914E")]
			Green = 2,
			[Cpp2IlInjected.Token(Token = "0x400914F")]
			Blue = 4,
			[Cpp2IlInjected.Token(Token = "0x4009150")]
			Yellow = 8,
			[Cpp2IlInjected.Token(Token = "0x4009151")]
			Actuator = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4009152")]
			Cutter = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x17000904")]
		public static MultiToolMode ToolMode
		{
			[Cpp2IlInjected.Token(Token = "0x6005269")]
			[Cpp2IlInjected.Address(RVA = "0xE1080C", Offset = "0xE1080C", VA = "0xE1080C")]
			get
			{
				return default(MultiToolMode);
			}
			[Cpp2IlInjected.Token(Token = "0x600526A")]
			[Cpp2IlInjected.Address(RVA = "0xE10868", Offset = "0xE10868", VA = "0xE10868")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000905")]
		public static bool DrawWires
		{
			[Cpp2IlInjected.Token(Token = "0x600526B")]
			[Cpp2IlInjected.Address(RVA = "0xE108C8", Offset = "0xE108C8", VA = "0xE108C8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000906")]
		public static bool HideWires
		{
			[Cpp2IlInjected.Token(Token = "0x600526C")]
			[Cpp2IlInjected.Address(RVA = "0xE10AA4", Offset = "0xE10AA4", VA = "0xE10AA4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000907")]
		public static bool DrawToolModeUI
		{
			[Cpp2IlInjected.Token(Token = "0x600526D")]
			[Cpp2IlInjected.Address(RVA = "0xE10B6C", Offset = "0xE10B6C", VA = "0xE10B6C")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000908")]
		private static int _lastActuatorEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600526E")]
			[Cpp2IlInjected.Address(RVA = "0xE10C48", Offset = "0xE10C48", VA = "0xE10C48")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600526F")]
			[Cpp2IlInjected.Address(RVA = "0xE10CA4", Offset = "0xE10CA4", VA = "0xE10CA4")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000909")]
		public static bool DrawToolAllowActuators
		{
			[Cpp2IlInjected.Token(Token = "0x6005270")]
			[Cpp2IlInjected.Address(RVA = "0xE10D04", Offset = "0xE10D04", VA = "0xE10D04")]
			get
			{
				return default(bool);
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A9B")]
	public class WiresRadial
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008EE8")]
		public Vector2 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008EE9")]
		public bool active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4008EEA")]
		public bool OnWiresMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008EEB")]
		private float _lineOpacity;

		[Cpp2IlInjected.Token(Token = "0x6005271")]
		[Cpp2IlInjected.Address(RVA = "0xE10744", Offset = "0xE10744", VA = "0xE10744")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005272")]
		[Cpp2IlInjected.Address(RVA = "0xE11258", Offset = "0xE11258", VA = "0xE11258")]
		private void LineUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005273")]
		[Cpp2IlInjected.Address(RVA = "0xE10EC0", Offset = "0xE10EC0", VA = "0xE10EC0")]
		private void FlowerUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005274")]
		[Cpp2IlInjected.Address(RVA = "0xE10760", Offset = "0xE10760", VA = "0xE10760")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005275")]
		[Cpp2IlInjected.Address(RVA = "0xE13CEC", Offset = "0xE13CEC", VA = "0xE13CEC")]
		private void DrawLine(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005276")]
		[Cpp2IlInjected.Address(RVA = "0xE1168C", Offset = "0xE1168C", VA = "0xE1168C")]
		private void DrawFlower(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005277")]
		[Cpp2IlInjected.Address(RVA = "0xE12E78", Offset = "0xE12E78", VA = "0xE12E78")]
		private void DrawCursorArea(SpriteBatch spriteBatch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6005278")]
		[Cpp2IlInjected.Address(RVA = "0xE10804", Offset = "0xE10804", VA = "0xE10804")]
		public WiresRadial()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006ECD")]
	private static WiresRadial radial;

	[Cpp2IlInjected.Token(Token = "0x170007A9")]
	public static bool Open
	{
		[Cpp2IlInjected.Token(Token = "0x60042CD")]
		[Cpp2IlInjected.Address(RVA = "0xE10618", Offset = "0xE10618", VA = "0xE10618")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60042CE")]
	[Cpp2IlInjected.Address(RVA = "0xE10694", Offset = "0xE10694", VA = "0xE10694")]
	public static void HandleWiresUI(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60042CF")]
	[Cpp2IlInjected.Address(RVA = "0xE10784", Offset = "0xE10784", VA = "0xE10784")]
	public WiresUI()
	{
	}
}
