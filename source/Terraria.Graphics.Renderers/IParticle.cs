using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers;

[Cpp2IlInjected.Token(Token = "0x20004F5")]
public interface IParticle
{
	[Cpp2IlInjected.Token(Token = "0x170006EA")]
	bool ShouldBeRemovedFromRenderer
	{
		[Cpp2IlInjected.Token(Token = "0x6003771")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6003772")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void Update(ref ParticleRendererSettings settings);

	[Cpp2IlInjected.Token(Token = "0x6003773")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);
}
