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
	// Token: 0x02000661 RID: 1633
	[global::Cpp2ILInjected.Token(Token = "0x20009DA")]
	public class SlimeSky : CustomSky
	{
		// Token: 0x06003FDD RID: 16349 RVA: 0x0002D674 File Offset: 0x0002B874
		[global::Cpp2ILInjected.Token(Token = "0x6004A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8590DC", Offset = "0x8590DC", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeSky), Member = "GenerateSlimes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x0002D677 File Offset: 0x0002B877
		[global::Cpp2ILInjected.Token(Token = "0x6004A4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8592A8", Offset = "0x8592A8", Length = "0x378")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = "OnLoad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = "Activate", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void GenerateSlimes()
		{
			throw null;
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x0002D67A File Offset: 0x0002B87A
		[global::Cpp2ILInjected.Token(Token = "0x6004A50")]
		[global::Cpp2ILInjected.Address(RVA = "0x859648", Offset = "0x859648", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x0002D67D File Offset: 0x0002B87D
		[global::Cpp2ILInjected.Token(Token = "0x6004A51")]
		[global::Cpp2ILInjected.Address(RVA = "0x8599F0", Offset = "0x8599F0", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeSky.Slime), Member = "GetSourceRectangle", ReturnType = typeof(Rectangle))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0002D680 File Offset: 0x0002B880
		[global::Cpp2ILInjected.Token(Token = "0x6004A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0C0", Offset = "0x85A0C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeSky), Member = "GenerateSlimes", ReturnType = typeof(void))]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x0002D683 File Offset: 0x0002B883
		[global::Cpp2ILInjected.Token(Token = "0x6004A53")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0DC", Offset = "0x85A0DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0002D686 File Offset: 0x0002B886
		[global::Cpp2ILInjected.Token(Token = "0x6004A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0E8", Offset = "0x85A0E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x0002D689 File Offset: 0x0002B889
		[global::Cpp2ILInjected.Token(Token = "0x6004A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0F0", Offset = "0x85A0F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x0002D68C File Offset: 0x0002B88C
		[global::Cpp2ILInjected.Token(Token = "0x6004A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0F8", Offset = "0x85A0F8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SlimeSky()
		{
			throw null;
		}

		// Token: 0x04006CF8 RID: 27896
		[global::Cpp2ILInjected.Token(Token = "0x40084E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Asset<Texture2D>[] _textures;

		// Token: 0x04006CF9 RID: 27897
		[global::Cpp2ILInjected.Token(Token = "0x40084E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SlimeSky.Slime[] _slimes;

		// Token: 0x04006CFA RID: 27898
		[global::Cpp2ILInjected.Token(Token = "0x40084E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private UnifiedRandom _random;

		// Token: 0x04006CFB RID: 27899
		[global::Cpp2ILInjected.Token(Token = "0x40084E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _slimesRemaining;

		// Token: 0x04006CFC RID: 27900
		[global::Cpp2ILInjected.Token(Token = "0x40084EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private bool _isActive;

		// Token: 0x04006CFD RID: 27901
		[global::Cpp2ILInjected.Token(Token = "0x40084EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
		private bool _isLeaving;

		// Token: 0x02000A58 RID: 2648
		[global::Cpp2ILInjected.Token(Token = "0x20009DB")]
		private struct Slime
		{
			// Token: 0x170008E5 RID: 2277
			// (get) Token: 0x0600509D RID: 20637 RVA: 0x00030380 File Offset: 0x0002E580
			// (set) Token: 0x0600509E RID: 20638 RVA: 0x00030383 File Offset: 0x0002E583
			[global::Cpp2ILInjected.Token(Token = "0x17000856")]
			public Texture2D Texture
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A57")]
				[global::Cpp2ILInjected.Address(RVA = "0x85A158", Offset = "0x85A158", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004A58")]
				[global::Cpp2ILInjected.Address(RVA = "0x859620", Offset = "0x859620", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x170008E6 RID: 2278
			// (get) Token: 0x0600509F RID: 20639 RVA: 0x00030386 File Offset: 0x0002E586
			// (set) Token: 0x060050A0 RID: 20640 RVA: 0x00030389 File Offset: 0x0002E589
			[global::Cpp2ILInjected.Token(Token = "0x17000857")]
			public int Frame
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A59")]
				[global::Cpp2ILInjected.Address(RVA = "0x85A160", Offset = "0x85A160", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004A5A")]
				[global::Cpp2ILInjected.Address(RVA = "0x8599C8", Offset = "0x8599C8", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060050A1 RID: 20641 RVA: 0x0003038C File Offset: 0x0002E58C
			[global::Cpp2ILInjected.Token(Token = "0x6004A5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x85A070", Offset = "0x85A070", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SlimeSky), Member = "Draw", MemberParameters = new object[]
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

			// Token: 0x04008E07 RID: 36359
			[global::Cpp2ILInjected.Token(Token = "0x40084EC")]
			private const int MAX_FRAMES = 4;

			// Token: 0x04008E08 RID: 36360
			[global::Cpp2ILInjected.Token(Token = "0x40084ED")]
			private const int FRAME_RATE = 6;

			// Token: 0x04008E09 RID: 36361
			[global::Cpp2ILInjected.Token(Token = "0x40084EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Texture2D _texture;

			// Token: 0x04008E0A RID: 36362
			[global::Cpp2ILInjected.Token(Token = "0x40084EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Vector2 Position;

			// Token: 0x04008E0B RID: 36363
			[global::Cpp2ILInjected.Token(Token = "0x40084F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public float Depth;

			// Token: 0x04008E0C RID: 36364
			[global::Cpp2ILInjected.Token(Token = "0x40084F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int FrameHeight;

			// Token: 0x04008E0D RID: 36365
			[global::Cpp2ILInjected.Token(Token = "0x40084F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int FrameWidth;

			// Token: 0x04008E0E RID: 36366
			[global::Cpp2ILInjected.Token(Token = "0x40084F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public float Speed;

			// Token: 0x04008E0F RID: 36367
			[global::Cpp2ILInjected.Token(Token = "0x40084F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public bool Active;

			// Token: 0x04008E10 RID: 36368
			[global::Cpp2ILInjected.Token(Token = "0x40084F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _frame;
		}
	}
}
