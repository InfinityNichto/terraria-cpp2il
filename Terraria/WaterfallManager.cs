using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000353")]
public class WaterfallManager
{
	[Cpp2IlInjected.Token(Token = "0x200086E")]
	public struct WaterfallData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4007F9D")]
		public int x;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4007F9E")]
		public int y;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007F9F")]
		public int type;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007FA0")]
		public int stopAtStep;
	}

	[Cpp2IlInjected.Token(Token = "0x4002FC8")]
	private const int minWet = 160;

	[Cpp2IlInjected.Token(Token = "0x4002FC9")]
	private const int maxWaterfallCountDefault = 1000;

	[Cpp2IlInjected.Token(Token = "0x4002FCA")]
	private const int maxLength = 100;

	[Cpp2IlInjected.Token(Token = "0x4002FCB")]
	private const int maxTypes = 26;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002FCC")]
	public int maxWaterfallCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002FCD")]
	private int qualityMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002FCE")]
	private int currentMax;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002FCF")]
	private WaterfallData[] waterfalls;

	[Cpp2IlInjected.Token(Token = "0x4002FD0")]
	private static Asset<Texture2D>[] waterfallTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002FD1")]
	private int wFallFrCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002FD2")]
	private int regularFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002FD3")]
	private int wFallFrCounter2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4002FD4")]
	private int slowFrame;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4002FD5")]
	private int rainFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4002FD6")]
	private int rainFrameForeground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4002FD7")]
	private int rainFrameBackground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4002FD8")]
	private int snowFrameCounter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4002FD9")]
	private int snowFrameForeground;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4002FDA")]
	private int findWaterfallCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4002FDB")]
	private int waterfallDist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4002FDC")]
	private VertexColors shimmerWaterFallColours;

	[Cpp2IlInjected.Token(Token = "0x6002977")]
	[Cpp2IlInjected.Address(RVA = "0x10EE01C", Offset = "0x10EE01C", VA = "0x10EE01C")]
	public WaterfallManager()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002978")]
	[Cpp2IlInjected.Address(RVA = "0x10EE124", Offset = "0x10EE124", VA = "0x10EE124")]
	public void LoadContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002979")]
	[Cpp2IlInjected.Address(RVA = "0x10EE318", Offset = "0x10EE318", VA = "0x10EE318")]
	public bool CheckForWaterfall(int i, int j)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600297A")]
	[Cpp2IlInjected.Address(RVA = "0x10EE368", Offset = "0x10EE368", VA = "0x10EE368")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600297B")]
	[Cpp2IlInjected.Address(RVA = "0x10EE37C", Offset = "0x10EE37C", VA = "0x10EE37C")]
	public void FindWaterfalls(bool forced = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600297C")]
	[Cpp2IlInjected.Address(RVA = "0x10EEE20", Offset = "0x10EEE20", VA = "0x10EEE20")]
	public void UpdateFrame()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600297D")]
	[Cpp2IlInjected.Address(RVA = "0x10EEF00", Offset = "0x10EEF00", VA = "0x10EEF00")]
	private void DrawWaterfall(SpriteBatch spriteBatch, int Style = 0, float Alpha = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600297E")]
	[Cpp2IlInjected.Address(RVA = "0x10F3D88", Offset = "0x10F3D88", VA = "0x10F3D88")]
	private void DrawWaterfall(int waterfallType, int x, int y, float opacity, Vector2 position, ref Rectangle sourceRect, ref Color color, SpriteEffects effects)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600297F")]
	[Cpp2IlInjected.Address(RVA = "0x10F3AC8", Offset = "0x10F3AC8", VA = "0x10F3AC8")]
	private static void TrySparkling(int x, int y, int direction, Color aColor2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002980")]
	[Cpp2IlInjected.Address(RVA = "0x10F4018", Offset = "0x10F4018", VA = "0x10F4018")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}
}
