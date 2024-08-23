using System;
using Cpp2ILInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004F2 RID: 1266
	[global::Cpp2ILInjected.Token(Token = "0x200074D")]
	public interface IParticle
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06003735 RID: 14133
		[global::Cpp2ILInjected.Token(Token = "0x17000783")]
		bool ShouldBeRemovedFromRenderer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DA8")]
			get;
		}

		// Token: 0x06003736 RID: 14134
		[global::Cpp2ILInjected.Token(Token = "0x6003DA9")]
		void Update(ref ParticleRendererSettings settings);

		// Token: 0x06003737 RID: 14135
		[global::Cpp2ILInjected.Token(Token = "0x6003DAA")]
		void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);
	}
}
