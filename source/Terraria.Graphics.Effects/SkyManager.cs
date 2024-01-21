using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x2000526")]
public class SkyManager : EffectManager<CustomSky>
{
	[Cpp2IlInjected.Token(Token = "0x400687A")]
	public static SkyManager Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400687B")]
	private float _lastDepth;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400687C")]
	private LinkedList<CustomSky> _activeSkies;

	[Cpp2IlInjected.Token(Token = "0x60038BA")]
	[Cpp2IlInjected.Address(RVA = "0x150A138", Offset = "0x150A138", VA = "0x150A138")]
	public void Reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038BB")]
	[Cpp2IlInjected.Address(RVA = "0x150A278", Offset = "0x150A278", VA = "0x150A278")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038BC")]
	[Cpp2IlInjected.Address(RVA = "0x150A3B8", Offset = "0x150A3B8", VA = "0x150A3B8")]
	public void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038BD")]
	[Cpp2IlInjected.Address(RVA = "0x150A678", Offset = "0x150A678", VA = "0x150A678")]
	public void DrawToDepth(SpriteBatch spriteBatch, float minDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038BE")]
	[Cpp2IlInjected.Address(RVA = "0x150A3DC", Offset = "0x150A3DC", VA = "0x150A3DC")]
	public void DrawDepthRange(SpriteBatch spriteBatch, float minDepth, float maxDepth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038BF")]
	[Cpp2IlInjected.Address(RVA = "0x150A6B8", Offset = "0x150A6B8", VA = "0x150A6B8")]
	public void DrawRemainingDepth(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038C0")]
	[Cpp2IlInjected.Address(RVA = "0x150A6E4", Offset = "0x150A6E4", VA = "0x150A6E4")]
	public void ResetDepthTracker()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038C1")]
	[Cpp2IlInjected.Address(RVA = "0x150A6F4", Offset = "0x150A6F4", VA = "0x150A6F4")]
	public void SetStartingDepth(float depth)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038C2")]
	[Cpp2IlInjected.Address(RVA = "0x150A6FC", Offset = "0x150A6FC", VA = "0x150A6FC", Slot = "4")]
	public override void OnActivate(CustomSky effect, Vector2 position)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038C3")]
	[Cpp2IlInjected.Address(RVA = "0x150A77C", Offset = "0x150A77C", VA = "0x150A77C")]
	public Color ProcessTileColor(Color color)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60038C4")]
	[Cpp2IlInjected.Address(RVA = "0x150A8AC", Offset = "0x150A8AC", VA = "0x150A8AC")]
	public float ProcessCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60038C5")]
	[Cpp2IlInjected.Address(RVA = "0x150A9F0", Offset = "0x150A9F0", VA = "0x150A9F0")]
	public SkyManager()
	{
	}
}
