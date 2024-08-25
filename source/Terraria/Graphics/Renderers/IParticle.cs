using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x200074D")]
	public interface IParticle
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000783")]
		bool ShouldBeRemovedFromRenderer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DA8")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DA9")]
		void Update(ref ParticleRendererSettings settings);

		[global::Cpp2ILInjected.Token(Token = "0x6003DAA")]
		void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);
	}
}
