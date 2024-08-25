using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Animations;
using Terraria.Graphics;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;
using Unity.IL2CPP.CompilerServices;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000366")]
	public class EffectPassCollection : IEnumerable<EffectPass>, IEnumerable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016B8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5098", Offset = "0xAA5098", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "get_Effect", ReturnType = typeof(ScreenShader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal EffectPassCollection(EffectPass[] passes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B9")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA50C0", Offset = "0xAA50C0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectTechnique), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(EffectTechnique)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectTechniqueCollection), Member = "Clone", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(EffectTechniqueCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal EffectPassCollection Clone(Effect effect)
		{
			throw null;
		}

		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x170002A2")]
		public EffectPass this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016BA")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA51DC", Offset = "0xAA51DC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "DrawNPC", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCs", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_LightsBane", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHelper), Member = "SetShaderForData", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(ref DrawData),
				typeof(ref EffectPass)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHelper), Member = "SetShaderForData", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(ref DrawData)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[]
			{
				typeof(ref PlayerDrawSet),
				typeof(Vector2[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FinalFractalHelper), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmpressBladeDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MagicMissileDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightDiscDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameLashDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RainbowRodDrawer), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderDataSet), Member = "Apply", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Entity),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderDataSet), Member = "ApplySecondary", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Entity),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HairShaderDataSet), Member = "Apply", MemberParameters = new object[]
			{
				typeof(short),
				typeof(Player),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "Draw", MemberParameters = new object[]
			{
				typeof(ref ParticleRendererSettings),
				typeof(SpriteBatch)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "RenderOutlines", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = "RenderDrawData", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "GetRealShader", MemberParameters = new object[]
			{
				typeof(int),
				typeof(TreePaintingSettings)
			}, ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = "AfterDrawing", MemberParameters = new object[]
			{
				typeof(ref GameAnimationSegment),
				typeof(ref DrawData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 39)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002A3")]
		public EffectPass this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016BB")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA51EC", Offset = "0xAA51EC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "GetDustEffect", ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShaderData), Member = "Apply", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002A4")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016BC")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5254", Offset = "0xAA5254", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016BD")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5260", Offset = "0xAA5260", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray2", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(Texture2D),
			typeof(EffectPass),
			typeof(int),
			typeof(int),
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public EffectPassCollection.Enumerator GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016BE")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA5284", Offset = "0xAA5284", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IEnumerator<EffectPass> System.Collections.Generic.IEnumerable<Microsoft.Xna.Framework.Graphics.EffectPass>.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016BF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA531C", Offset = "0xAA531C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40024E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly EffectPass[] _passes;

		[global::Cpp2ILInjected.Token(Token = "0x2000367")]
		public struct Enumerator : IEnumerator<EffectPass>, IEnumerator, IDisposable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016C0")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5274", Offset = "0xAA5274", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Enumerator(EffectPass[] array)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60016C1")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5328", Offset = "0xAA5328", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray2", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(int),
				typeof(int),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			public bool MoveNext()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170002A5")]
			public EffectPass Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60016C2")]
				[global::Cpp2ILInjected.Address(RVA = "0xAA5370", Offset = "0xAA5370", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170002A6")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60016C3")]
				[global::Cpp2ILInjected.Address(RVA = "0xAA5378", Offset = "0xAA5378", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60016C4")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53D4", Offset = "0xAA53D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60016C5")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA53E0", Offset = "0xAA53E0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "AddSubMesh", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatcher), Member = "RenderVertexArray2", MemberParameters = new object[]
			{
				typeof(Effect),
				typeof(Texture2D),
				typeof(EffectPass),
				typeof(int),
				typeof(int),
				typeof(Vector3),
				typeof(Vector3)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			public void Dispose()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40024E6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly EffectPass[] _array;

			[global::Cpp2ILInjected.Token(Token = "0x40024E7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private int _index;

			[global::Cpp2ILInjected.Token(Token = "0x40024E8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private EffectPass _current;
		}
	}
}
