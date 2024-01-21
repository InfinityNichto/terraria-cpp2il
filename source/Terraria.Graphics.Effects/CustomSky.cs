using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects;

[Cpp2IlInjected.Token(Token = "0x200051A")]
public abstract class CustomSky : GameEffect
{
	[Cpp2IlInjected.Token(Token = "0x600387C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void Update(GameTime gameTime);

	[Cpp2IlInjected.Token(Token = "0x600387D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth);

	[Cpp2IlInjected.Token(Token = "0x600387E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract bool IsActive();

	[Cpp2IlInjected.Token(Token = "0x600387F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract void Reset();

	[Cpp2IlInjected.Token(Token = "0x6003880")]
	[Cpp2IlInjected.Address(RVA = "0x1507840", Offset = "0x1507840", VA = "0x1507840", Slot = "12")]
	public virtual Color OnTileColor(Color inColor)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6003881")]
	[Cpp2IlInjected.Address(RVA = "0x1507848", Offset = "0x1507848", VA = "0x1507848", Slot = "13")]
	public virtual float GetCloudAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6003882")]
	[Cpp2IlInjected.Address(RVA = "0x1507850", Offset = "0x1507850", VA = "0x1507850", Slot = "5")]
	public override bool IsVisible()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6003883")]
	[Cpp2IlInjected.Address(RVA = "0x1507858", Offset = "0x1507858", VA = "0x1507858")]
	protected CustomSky()
	{
	}
}
