using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.Elements;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004F9 RID: 1273
	[global::Cpp2ILInjected.Token(Token = "0x2000755")]
	public class CreativeSacrificeParticle : IParticle
	{
		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003758 RID: 14168 RVA: 0x0002BE3B File Offset: 0x0002A03B
		// (set) Token: 0x06003759 RID: 14169 RVA: 0x0002BE3E File Offset: 0x0002A03E
		[global::Cpp2ILInjected.Token(Token = "0x17000789")]
		public bool ShouldBeRemovedFromRenderer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DCF")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A5CF0", Offset = "0x14A5CF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A5CF8", Offset = "0x14A5CF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x0002BE41 File Offset: 0x0002A041
		[global::Cpp2ILInjected.Token(Token = "0x6003DD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A5D04", Offset = "0x14A5D04", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "UpdateResearchAnimation", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public CreativeSacrificeParticle(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
			throw null;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x0002BE44 File Offset: 0x0002A044
		[global::Cpp2ILInjected.Token(Token = "0x6003DD2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A5E84", Offset = "0x14A5E84", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "UpdateResearchAnimation", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0002BE47 File Offset: 0x0002A047
		[global::Cpp2ILInjected.Token(Token = "0x6003DD3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A5F40", Offset = "0x14A5F40", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIResearch), Member = "DrawResearchParticles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		// Token: 0x04006798 RID: 26520
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x04006799 RID: 26521
		[global::Cpp2ILInjected.Token(Token = "0x4007C81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2 AccelerationPerFrame;

		// Token: 0x0400679A RID: 26522
		[global::Cpp2ILInjected.Token(Token = "0x4007C82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Velocity;

		// Token: 0x0400679B RID: 26523
		[global::Cpp2ILInjected.Token(Token = "0x4007C83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Vector2 LocalPosition;

		// Token: 0x0400679C RID: 26524
		[global::Cpp2ILInjected.Token(Token = "0x4007C84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public float ScaleOffsetPerFrame;

		// Token: 0x0400679D RID: 26525
		[global::Cpp2ILInjected.Token(Token = "0x4007C85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public float StopWhenBelowXScale;

		// Token: 0x0400679E RID: 26526
		[global::Cpp2ILInjected.Token(Token = "0x4007C86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400679F RID: 26527
		[global::Cpp2ILInjected.Token(Token = "0x4007C87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Rectangle _frame;

		// Token: 0x040067A0 RID: 26528
		[global::Cpp2ILInjected.Token(Token = "0x4007C88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Vector2 _origin;

		// Token: 0x040067A1 RID: 26529
		[global::Cpp2ILInjected.Token(Token = "0x4007C89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private float _scale;
	}
}
