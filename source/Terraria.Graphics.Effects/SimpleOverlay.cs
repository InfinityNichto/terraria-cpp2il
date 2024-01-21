using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x2000525")]
public class SimpleOverlay : Overlay
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006877")]
	private Asset<Texture2D> _texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4006878")]
	private ScreenShaderData _shader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4006879")]
	public Vector2 TargetPosition;

	[Cpp2IlInjected.Token(Token = "0x60038B2")]
	[Cpp2IlInjected.Address(RVA = "0x1509B30", Offset = "0x1509B30", VA = "0x1509B30")]
	public SimpleOverlay(string textureName, ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B3")]
	[Cpp2IlInjected.Address(RVA = "0x1509D38", Offset = "0x1509D38", VA = "0x1509D38")]
	public SimpleOverlay(string textureName, string shaderName = "Default", EffectPriority priority = EffectPriority.VeryLow, RenderLayers layer = RenderLayers.All)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B4")]
	[Cpp2IlInjected.Address(RVA = "0x1509F9C", Offset = "0x1509F9C", VA = "0x1509F9C")]
	public ScreenShaderData GetShader()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60038B5")]
	[Cpp2IlInjected.Address(RVA = "0x1509FA4", Offset = "0x1509FA4", VA = "0x1509FA4", Slot = "8")]
	public override void Draw(SpriteBatch spriteBatch)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B6")]
	[Cpp2IlInjected.Address(RVA = "0x150A0D4", Offset = "0x150A0D4", VA = "0x150A0D4", Slot = "9")]
	public override void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B7")]
	[Cpp2IlInjected.Address(RVA = "0x150A0E8", Offset = "0x150A0E8", VA = "0x150A0E8", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B8")]
	[Cpp2IlInjected.Address(RVA = "0x150A0FC", Offset = "0x150A0FC", VA = "0x150A0FC", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60038B9")]
	[Cpp2IlInjected.Address(RVA = "0x150A108", Offset = "0x150A108", VA = "0x150A108", Slot = "5")]
	public override bool IsVisible()
	{
		return default(bool);
	}
}
