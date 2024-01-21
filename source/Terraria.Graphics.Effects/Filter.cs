using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x200051D")]
public class Filter : GameEffect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006855")]
	public bool Active;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006856")]
	private ScreenShaderData _shader;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006857")]
	public bool IsHidden;

	[Cpp2IlInjected.Token(Token = "0x600388E")]
	[Cpp2IlInjected.Address(RVA = "0x1507868", Offset = "0x1507868", VA = "0x1507868")]
	public Filter(ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600388F")]
	[Cpp2IlInjected.Address(RVA = "0x1507890", Offset = "0x1507890", VA = "0x1507890")]
	public void Update(GameTime gameTime)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003890")]
	[Cpp2IlInjected.Address(RVA = "0x15078CC", Offset = "0x15078CC", VA = "0x15078CC")]
	public void Apply()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003891")]
	[Cpp2IlInjected.Address(RVA = "0x15078E0", Offset = "0x15078E0", VA = "0x15078E0")]
	public ScreenShaderData GetShader()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003892")]
	[Cpp2IlInjected.Address(RVA = "0x15078E8", Offset = "0x15078E8", VA = "0x15078E8", Slot = "6")]
	public override void Activate(Vector2 position, params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003893")]
	[Cpp2IlInjected.Address(RVA = "0x150792C", Offset = "0x150792C", VA = "0x150792C", Slot = "7")]
	public override void Deactivate(params object[] args)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003894")]
	[Cpp2IlInjected.Address(RVA = "0x1507938", Offset = "0x1507938", VA = "0x1507938")]
	public bool IsInUse()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003895")]
	[Cpp2IlInjected.Address(RVA = "0x1507964", Offset = "0x1507964", VA = "0x1507964")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003896")]
	[Cpp2IlInjected.Address(RVA = "0x150796C", Offset = "0x150796C", VA = "0x150796C", Slot = "5")]
	public override bool IsVisible()
	{
		return default(bool);
	}
}
