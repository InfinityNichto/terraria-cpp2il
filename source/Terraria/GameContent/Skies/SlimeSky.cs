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
	[global::Cpp2ILInjected.Token(Token = "0x20009DA")]
	public class SlimeSky : CustomSky
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6004A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0C0", Offset = "0x85A0C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SlimeSky), Member = "GenerateSlimes", ReturnType = typeof(void))]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A53")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0DC", Offset = "0x85A0DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0E8", Offset = "0x85A0E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x85A0F0", Offset = "0x85A0F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x40084E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Asset<Texture2D>[] _textures;

		[global::Cpp2ILInjected.Token(Token = "0x40084E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SlimeSky.Slime[] _slimes;

		[global::Cpp2ILInjected.Token(Token = "0x40084E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private UnifiedRandom _random;

		[global::Cpp2ILInjected.Token(Token = "0x40084E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _slimesRemaining;

		[global::Cpp2ILInjected.Token(Token = "0x40084EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private bool _isActive;

		[global::Cpp2ILInjected.Token(Token = "0x40084EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
		private bool _isLeaving;

		[global::Cpp2ILInjected.Token(Token = "0x20009DB")]
		private struct Slime
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x40084EC")]
			private const int MAX_FRAMES = 4;

			[global::Cpp2ILInjected.Token(Token = "0x40084ED")]
			private const int FRAME_RATE = 6;

			[global::Cpp2ILInjected.Token(Token = "0x40084EE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Texture2D _texture;

			[global::Cpp2ILInjected.Token(Token = "0x40084EF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public Vector2 Position;

			[global::Cpp2ILInjected.Token(Token = "0x40084F0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public float Depth;

			[global::Cpp2ILInjected.Token(Token = "0x40084F1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public int FrameHeight;

			[global::Cpp2ILInjected.Token(Token = "0x40084F2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int FrameWidth;

			[global::Cpp2ILInjected.Token(Token = "0x40084F3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			public float Speed;

			[global::Cpp2ILInjected.Token(Token = "0x40084F4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public bool Active;

			[global::Cpp2ILInjected.Token(Token = "0x40084F5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			private int _frame;
		}
	}
}
