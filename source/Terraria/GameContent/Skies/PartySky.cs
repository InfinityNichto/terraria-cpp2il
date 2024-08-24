using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x02000658 RID: 1624
	[global::Cpp2ILInjected.Token(Token = "0x20009B2")]
	public class PartySky : CustomSky
	{
		// Token: 0x06003F86 RID: 16262 RVA: 0x0002D56F File Offset: 0x0002B76F
		[global::Cpp2ILInjected.Token(Token = "0x6004973")]
		[global::Cpp2ILInjected.Address(RVA = "0x82EBFC", Offset = "0x82EBFC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003F87 RID: 16263 RVA: 0x0002D572 File Offset: 0x0002B772
		[global::Cpp2ILInjected.Token(Token = "0x6004974")]
		[global::Cpp2ILInjected.Address(RVA = "0x82ECFC", Offset = "0x82ECFC", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Activate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PartySky), Member = "ResetBalloon", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void GenerateBalloons(bool onlyMissing)
		{
			throw null;
		}

		// Token: 0x06003F88 RID: 16264 RVA: 0x0002D575 File Offset: 0x0002B775
		[global::Cpp2ILInjected.Token(Token = "0x6004975")]
		[global::Cpp2ILInjected.Address(RVA = "0x82EEF4", Offset = "0x82EEF4", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "GenerateBalloons", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ResetBalloon(int i)
		{
			throw null;
		}

		// Token: 0x06003F89 RID: 16265 RVA: 0x0002D578 File Offset: 0x0002B778
		[global::Cpp2ILInjected.Token(Token = "0x6004976")]
		[global::Cpp2ILInjected.Address(RVA = "0x82F0B8", Offset = "0x82F0B8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SceneMetrics", ReturnType = typeof(SceneMetrics))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool IsNearParty()
		{
			throw null;
		}

		// Token: 0x06003F8A RID: 16266 RVA: 0x0002D57B File Offset: 0x0002B77B
		[global::Cpp2ILInjected.Token(Token = "0x6004977")]
		[global::Cpp2ILInjected.Address(RVA = "0x82F158", Offset = "0x82F158", Length = "0x368")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PartySky), Member = "IsNearParty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToDirectionInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PartySky), Member = "ResetBalloon", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003F8B RID: 16267 RVA: 0x0002D57E File Offset: 0x0002B77E
		[global::Cpp2ILInjected.Token(Token = "0x6004978")]
		[global::Cpp2ILInjected.Address(RVA = "0x82F4E8", Offset = "0x82F4E8", Length = "0x724")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PartySky.Balloon), Member = "GetSourceRectangle", ReturnType = typeof(Rectangle))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003F8C RID: 16268 RVA: 0x0002D581 File Offset: 0x0002B781
		[global::Cpp2ILInjected.Token(Token = "0x6004979")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FC64", Offset = "0x82FC64", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PartySky), Member = "GenerateBalloons", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x0002D584 File Offset: 0x0002B784
		[global::Cpp2ILInjected.Token(Token = "0x600497A")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FCA4", Offset = "0x82FCA4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x0002D587 File Offset: 0x0002B787
		[global::Cpp2ILInjected.Token(Token = "0x600497B")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FCB0", Offset = "0x82FCB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x0002D58A File Offset: 0x0002B78A
		[global::Cpp2ILInjected.Token(Token = "0x600497C")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FCB8", Offset = "0x82FCB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x0002D58D File Offset: 0x0002B78D
		[global::Cpp2ILInjected.Token(Token = "0x600497D")]
		[global::Cpp2ILInjected.Address(RVA = "0x82FCC0", Offset = "0x82FCC0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PartySky()
		{
			throw null;
		}

		// Token: 0x04006CC2 RID: 27842
		[global::Cpp2ILInjected.Token(Token = "0x4008454")]
		public static bool MultipleSkyWorkaroundFix;

		// Token: 0x04006CC3 RID: 27843
		[global::Cpp2ILInjected.Token(Token = "0x4008455")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _active;

		// Token: 0x04006CC4 RID: 27844
		[global::Cpp2ILInjected.Token(Token = "0x4008456")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
		private bool _leaving;

		// Token: 0x04006CC5 RID: 27845
		[global::Cpp2ILInjected.Token(Token = "0x4008457")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float _opacity;

		// Token: 0x04006CC6 RID: 27846
		[global::Cpp2ILInjected.Token(Token = "0x4008458")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Asset<Texture2D>[] _textures;

		// Token: 0x04006CC7 RID: 27847
		[global::Cpp2ILInjected.Token(Token = "0x4008459")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private PartySky.Balloon[] _balloons;

		// Token: 0x04006CC8 RID: 27848
		[global::Cpp2ILInjected.Token(Token = "0x400845A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private UnifiedRandom _random;

		// Token: 0x04006CC9 RID: 27849
		[global::Cpp2ILInjected.Token(Token = "0x400845B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _balloonsDrawing;

		// Token: 0x02000A39 RID: 2617
		[global::Cpp2ILInjected.Token(Token = "0x20009B3")]
		private struct Balloon
		{
			// Token: 0x170008DD RID: 2269
			// (get) Token: 0x06005019 RID: 20505 RVA: 0x0003020F File Offset: 0x0002E40F
			// (set) Token: 0x0600501A RID: 20506 RVA: 0x00030212 File Offset: 0x0002E412
			[global::Cpp2ILInjected.Token(Token = "0x1700084D")]
			public Texture2D Texture
			{
				[global::Cpp2ILInjected.Token(Token = "0x600497E")]
				[global::Cpp2ILInjected.Address(RVA = "0x82FD20", Offset = "0x82FD20", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600497F")]
				[global::Cpp2ILInjected.Address(RVA = "0x82F078", Offset = "0x82F078", Length = "0x40")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170008DE RID: 2270
			// (get) Token: 0x0600501B RID: 20507 RVA: 0x00030215 File Offset: 0x0002E415
			// (set) Token: 0x0600501C RID: 20508 RVA: 0x00030218 File Offset: 0x0002E418
			[global::Cpp2ILInjected.Token(Token = "0x1700084E")]
			public int Frame
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004980")]
				[global::Cpp2ILInjected.Address(RVA = "0x82FD28", Offset = "0x82FD28", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004981")]
				[global::Cpp2ILInjected.Address(RVA = "0x82F4C0", Offset = "0x82F4C0", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x0600501D RID: 20509 RVA: 0x0003021B File Offset: 0x0002E41B
			[global::Cpp2ILInjected.Token(Token = "0x6004982")]
			[global::Cpp2ILInjected.Address(RVA = "0x82FC0C", Offset = "0x82FC0C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartySky), Member = "Draw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public Rectangle GetSourceRectangle()
			{
				throw null;
			}

			// Token: 0x04008DAB RID: 36267
			[global::Cpp2ILInjected.Token(Token = "0x400845C")]
			private const int MAX_FRAMES_X = 3;

			// Token: 0x04008DAC RID: 36268
			[global::Cpp2ILInjected.Token(Token = "0x400845D")]
			private const int MAX_FRAMES_Y = 3;

			// Token: 0x04008DAD RID: 36269
			[global::Cpp2ILInjected.Token(Token = "0x400845E")]
			private const int FRAME_RATE = 14;

			// Token: 0x04008DAE RID: 36270
			[global::Cpp2ILInjected.Token(Token = "0x400845F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Variant;

			// Token: 0x04008DAF RID: 36271
			[global::Cpp2ILInjected.Token(Token = "0x4008460")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private Texture2D _texture;

			// Token: 0x04008DB0 RID: 36272
			[global::Cpp2ILInjected.Token(Token = "0x4008461")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Vector2 Position;

			// Token: 0x04008DB1 RID: 36273
			[global::Cpp2ILInjected.Token(Token = "0x4008462")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public float Depth;

			// Token: 0x04008DB2 RID: 36274
			[global::Cpp2ILInjected.Token(Token = "0x4008463")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public int FrameHeight;

			// Token: 0x04008DB3 RID: 36275
			[global::Cpp2ILInjected.Token(Token = "0x4008464")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int FrameWidth;

			// Token: 0x04008DB4 RID: 36276
			[global::Cpp2ILInjected.Token(Token = "0x4008465")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float Speed;

			// Token: 0x04008DB5 RID: 36277
			[global::Cpp2ILInjected.Token(Token = "0x4008466")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public bool Active;

			// Token: 0x04008DB6 RID: 36278
			[global::Cpp2ILInjected.Token(Token = "0x4008467")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _frameCounter;
		}
	}
}
