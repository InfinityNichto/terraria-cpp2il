using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	[global::Cpp2ILInjected.Token(Token = "0x2000788")]
	public abstract class Overlay : GameEffect
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003F0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x741E50", Offset = "0x741E50", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Overlay(EffectPriority priority, RenderLayers layer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003F0F")]
		public abstract void Draw(SpriteBatch spriteBatch);

		[global::Cpp2ILInjected.Token(Token = "0x6003F10")]
		public abstract void Update(GameTime gameTime);

		[global::Cpp2ILInjected.Token(Token = "0x4007D8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public OverlayMode Mode;

		[global::Cpp2ILInjected.Token(Token = "0x4007D8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private RenderLayers _layer;
	}
}
