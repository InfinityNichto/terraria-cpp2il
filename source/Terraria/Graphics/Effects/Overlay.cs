using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x0200051F RID: 1311
	[global::Cpp2ILInjected.Token(Token = "0x2000788")]
	public abstract class Overlay : GameEffect
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x0002C138 File Offset: 0x0002A338
		[global::Cpp2ILInjected.Token(Token = "0x170007A7")]
		public RenderLayers Layer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003F0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x741E48", Offset = "0x741E48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x0002C13B File Offset: 0x0002A33B
		[global::Cpp2ILInjected.Token(Token = "0x6003F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x741E50", Offset = "0x741E50", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Overlay(EffectPriority priority, RenderLayers layer)
		{
			throw null;
		}

		// Token: 0x06003870 RID: 14448
		[global::Cpp2ILInjected.Token(Token = "0x6003F0F")]
		public abstract void Draw(SpriteBatch spriteBatch);

		// Token: 0x06003871 RID: 14449
		[global::Cpp2ILInjected.Token(Token = "0x6003F10")]
		public abstract void Update(GameTime gameTime);

		// Token: 0x04006866 RID: 26726
		[global::Cpp2ILInjected.Token(Token = "0x4007D8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public OverlayMode Mode;

		// Token: 0x04006867 RID: 26727
		[global::Cpp2ILInjected.Token(Token = "0x4007D8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RenderLayers _layer;
	}
}
