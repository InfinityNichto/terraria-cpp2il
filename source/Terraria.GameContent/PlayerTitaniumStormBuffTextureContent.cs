using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;

namespace Terraria.GameContent;

[Cpp2IlInjected.Token(Token = "0x2000556")]
public class PlayerTitaniumStormBuffTextureContent : ARenderTargetContentByRequest
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40068FA")]
	private EffectPass renderEffect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40068FB")]
	private MiscShaderData _shaderData;

	[Cpp2IlInjected.Token(Token = "0x6003A17")]
	[Cpp2IlInjected.Address(RVA = "0x119BA98", Offset = "0x119BA98", VA = "0x119BA98")]
	public PlayerTitaniumStormBuffTextureContent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A18")]
	[Cpp2IlInjected.Address(RVA = "0x119BBB0", Offset = "0x119BBB0", VA = "0x119BBB0")]
	public EffectPass GetRenderEffect()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003A19")]
	[Cpp2IlInjected.Address(RVA = "0x119BD24", Offset = "0x119BD24", VA = "0x119BD24", Slot = "7")]
	protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003A1A")]
	[Cpp2IlInjected.Address(RVA = "0x119BCD8", Offset = "0x119BCD8", VA = "0x119BCD8")]
	public void UpdateSettingsForRendering(float gradientContributionFromOriginalTexture, float gradientScrollingSpeed, float flatGradientOffset, float gradientColorDominance)
	{
	}
}
