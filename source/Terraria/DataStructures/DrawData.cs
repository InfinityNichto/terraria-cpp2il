using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Animations;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Shaders;
using Terraria.GameContent.Skies.CreditsRoll;
using Terraria.Graphics;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;

namespace Terraria.DataStructures
{
	// Token: 0x02000426 RID: 1062
	[global::Cpp2ILInjected.Token(Token = "0x2000621")]
	public struct DrawData
	{
		// Token: 0x060030C3 RID: 12483 RVA: 0x0002AB93 File Offset: 0x00028D93
		[global::Cpp2ILInjected.Token(Token = "0x60035E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBF4C", Offset = "0x13DBF4C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public DrawData(Texture2D texture, Vector2 position, Color color)
		{
			throw null;
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0002AB96 File Offset: 0x00028D96
		[global::Cpp2ILInjected.Token(Token = "0x60035E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC098", Offset = "0x13DC098", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_ForbiddenSetRing", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_05_2_SafemanSun", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_06_WebbedDebuffBack", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_26_SolarShield", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_27_HeldItem", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_33_FrozenOrWebbedDebuff", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_GuideEmotingAtRainbowPanel", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_SkeletonMerchantSearchesThroughBones", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreditsRollComposer), Member = "PlaySegment_Grox_ZoologistAndPetsAnnoyGolfer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(SegmentInforReport))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			throw null;
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0002AB99 File Offset: 0x00028D99
		[global::Cpp2ILInjected.Token(Token = "0x60035E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC194", Offset = "0x13DC194", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawStarboardRainbowTrail", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawMeowcartTrail", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DrawData(Texture2D texture, Vector2 position, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			throw null;
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0002AB9C File Offset: 0x00028D9C
		[global::Cpp2ILInjected.Token(Token = "0x60035E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC284", Offset = "0x13DC284", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 247)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			throw null;
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0002AB9F File Offset: 0x00028D9F
		[global::Cpp2ILInjected.Token(Token = "0x60035E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC2E0", Offset = "0x13DC2E0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EntitySpriteDraw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_09_Wings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_13_Leggings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref ParticleRendererSettings),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public DrawData(Texture2D texture, Vector2 position, Rectangle sourceRect, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effect, int inactiveLayerDepth)
		{
			throw null;
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x0002ABA2 File Offset: 0x00028DA2
		[global::Cpp2ILInjected.Token(Token = "0x60035E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC308", Offset = "0x13DC308", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "DrawNPC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect_HallowBoss", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(ref Vector2),
			typeof(int),
			typeof(ref Color),
			typeof(ref Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EntitySpriteDraw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EntitySpriteDraw", MemberParameters = new object[] { typeof(DrawData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref ParticleRendererSettings),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = "RenderDrawData", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "DrawReturnGateInWorld", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment), Member = "Draw", MemberParameters = new object[] { typeof(ref GameAnimationSegment) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVoidLenses", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		public void Draw(SpriteBatch sb)
		{
			throw null;
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x0002ABA5 File Offset: 0x00028DA5
		[global::Cpp2ILInjected.Token(Token = "0x60035E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC338", Offset = "0x13DC338", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWithOutlines", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "RenderOutlines", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(ref Vector2),
			typeof(ref Rectangle),
			typeof(ref Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Draw(SpriteBatch sb, Vector2 offset)
		{
			throw null;
		}

		// Token: 0x040062C9 RID: 25289
		[global::Cpp2ILInjected.Token(Token = "0x40076B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Texture2D texture;

		// Token: 0x040062CA RID: 25290
		[global::Cpp2ILInjected.Token(Token = "0x40076B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Vector2 position;

		// Token: 0x040062CB RID: 25291
		[global::Cpp2ILInjected.Token(Token = "0x40076B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Rectangle sourceRect;

		// Token: 0x040062CC RID: 25292
		[global::Cpp2ILInjected.Token(Token = "0x40076B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Color color;

		// Token: 0x040062CD RID: 25293
		[global::Cpp2ILInjected.Token(Token = "0x40076B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float rotation;

		// Token: 0x040062CE RID: 25294
		[global::Cpp2ILInjected.Token(Token = "0x40076B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public Vector2 origin;

		// Token: 0x040062CF RID: 25295
		[global::Cpp2ILInjected.Token(Token = "0x40076B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Vector2 scale;

		// Token: 0x040062D0 RID: 25296
		[global::Cpp2ILInjected.Token(Token = "0x40076BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public SpriteEffects effect;

		// Token: 0x040062D1 RID: 25297
		[global::Cpp2ILInjected.Token(Token = "0x40076BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int shader;

		// Token: 0x040062D2 RID: 25298
		[global::Cpp2ILInjected.Token(Token = "0x40076BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool ignorePlayerRotation;

		// Token: 0x040062D3 RID: 25299
		[global::Cpp2ILInjected.Token(Token = "0x40076BD")]
		public static Rectangle? nullRectangle;
	}
}
