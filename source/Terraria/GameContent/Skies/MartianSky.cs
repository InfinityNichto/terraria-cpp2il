using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	[global::Cpp2ILInjected.Token(Token = "0x20009D0")]
	public class MartianSky : CustomSky
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004A10")]
		[global::Cpp2ILInjected.Address(RVA = "0x855D0C", Offset = "0x855D0C", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSky.Ufo), Member = "AssignNewBehavior", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A11")]
		[global::Cpp2ILInjected.Address(RVA = "0x855FD4", Offset = "0x855FD4", Length = "0x66C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSky.Ufo), Member = "GetSourceRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A12")]
		[global::Cpp2ILInjected.Address(RVA = "0x856688", Offset = "0x856688", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "Activate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSky.Ufo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void GenerateUfos()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A13")]
		[global::Cpp2ILInjected.Address(RVA = "0x856A40", Offset = "0x856A40", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MartianSky), Member = "GenerateUfos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<MartianSky.Ufo>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(MartianSky.Ufo) }, MemberParameters = new object[]
		{
			typeof(MartianSky.Ufo[]),
			typeof(Comparison<MartianSky.Ufo>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A14")]
		[global::Cpp2ILInjected.Address(RVA = "0x856B54", Offset = "0x856B54", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A15")]
		[global::Cpp2ILInjected.Address(RVA = "0x856B60", Offset = "0x856B60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A16")]
		[global::Cpp2ILInjected.Address(RVA = "0x856B68", Offset = "0x856B68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A17")]
		[global::Cpp2ILInjected.Address(RVA = "0x856B70", Offset = "0x856B70", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MartianSky()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40084B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private MartianSky.Ufo[] _ufos;

		[global::Cpp2ILInjected.Token(Token = "0x40084B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private UnifiedRandom _random;

		[global::Cpp2ILInjected.Token(Token = "0x40084B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _maxUfos;

		[global::Cpp2ILInjected.Token(Token = "0x40084BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private bool _active;

		[global::Cpp2ILInjected.Token(Token = "0x40084BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x35")]
		private bool _leaving;

		[global::Cpp2ILInjected.Token(Token = "0x40084BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _activeUfos;

		[global::Cpp2ILInjected.Token(Token = "0x20009D1")]
		private abstract class IUfoController
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004A18")]
			public abstract void InitializeUfo(ref MartianSky.Ufo ufo);

			[global::Cpp2ILInjected.Token(Token = "0x6004A19")]
			public abstract bool Update(ref MartianSky.Ufo ufo);

			[global::Cpp2ILInjected.Token(Token = "0x6004A1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x856BD0", Offset = "0x856BD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			protected IUfoController()
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009D2")]
		private class ZipBehavior : MartianSky.IUfoController
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x856BD8", Offset = "0x856BD8", Length = "0x214")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public override void InitializeUfo(ref MartianSky.Ufo ufo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x856DEC", Offset = "0x856DEC", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override bool Update(ref MartianSky.Ufo ufo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x856ED0", Offset = "0x856ED0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ZipBehavior()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40084BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Vector2 _speed;

			[global::Cpp2ILInjected.Token(Token = "0x40084BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _ticks;

			[global::Cpp2ILInjected.Token(Token = "0x40084BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _maxTicks;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009D3")]
		private class HoverBehavior : MartianSky.IUfoController
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004A1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x856ED8", Offset = "0x856ED8", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public override void InitializeUfo(ref MartianSky.Ufo ufo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x856FEC", Offset = "0x856FEC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override bool Update(ref MartianSky.Ufo ufo)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A20")]
			[global::Cpp2ILInjected.Address(RVA = "0x857058", Offset = "0x857058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public HoverBehavior()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40084C0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int _ticks;

			[global::Cpp2ILInjected.Token(Token = "0x40084C1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			private int _maxTicks;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20009D4")]
		private struct Ufo
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000853")]
			public int Frame
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A21")]
				[global::Cpp2ILInjected.Address(RVA = "0x857060", Offset = "0x857060", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004A22")]
				[global::Cpp2ILInjected.Address(RVA = "0x855EC4", Offset = "0x855EC4", Length = "0x28")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000854")]
			public Texture2D Texture
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A23")]
				[global::Cpp2ILInjected.Address(RVA = "0x857068", Offset = "0x857068", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004A24")]
				[global::Cpp2ILInjected.Address(RVA = "0x857070", Offset = "0x857070", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000855")]
			public MartianSky.IUfoController Controller
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A25")]
				[global::Cpp2ILInjected.Address(RVA = "0x8570A0", Offset = "0x8570A0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004A26")]
				[global::Cpp2ILInjected.Address(RVA = "0x8570A8", Offset = "0x8570A8", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A27")]
			[global::Cpp2ILInjected.Address(RVA = "0x85694C", Offset = "0x85694C", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "GenerateUfos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public Ufo(Texture2D texture, float depth = 1f)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A28")]
			[global::Cpp2ILInjected.Address(RVA = "0x856640", Offset = "0x856640", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "Draw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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

			[global::Cpp2ILInjected.Token(Token = "0x6004A29")]
			[global::Cpp2ILInjected.Address(RVA = "0x855EEC", Offset = "0x855EEC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool Update()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x855F00", Offset = "0x855F00", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MartianSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void AssignNewBehavior()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8570C4", Offset = "0x8570C4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			static Ufo()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40084C2")]
			private const int MAX_FRAMES = 3;

			[global::Cpp2ILInjected.Token(Token = "0x40084C3")]
			private const int FRAME_RATE = 4;

			[global::Cpp2ILInjected.Token(Token = "0x40084C4")]
			public static UnifiedRandom Random;

			[global::Cpp2ILInjected.Token(Token = "0x40084C5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _frame;

			[global::Cpp2ILInjected.Token(Token = "0x40084C6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private Texture2D _texture;

			[global::Cpp2ILInjected.Token(Token = "0x40084C7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private MartianSky.IUfoController _controller;

			[global::Cpp2ILInjected.Token(Token = "0x40084C8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Texture2D GlowTexture;

			[global::Cpp2ILInjected.Token(Token = "0x40084C9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Vector2 Position;

			[global::Cpp2ILInjected.Token(Token = "0x40084CA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int FrameHeight;

			[global::Cpp2ILInjected.Token(Token = "0x40084CB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public int FrameWidth;

			[global::Cpp2ILInjected.Token(Token = "0x40084CC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public float Depth;

			[global::Cpp2ILInjected.Token(Token = "0x40084CD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public float Scale;

			[global::Cpp2ILInjected.Token(Token = "0x40084CE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public float Opacity;

			[global::Cpp2ILInjected.Token(Token = "0x40084CF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public bool IsActive;

			[global::Cpp2ILInjected.Token(Token = "0x40084D0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public float Rotation;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20009D5")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004A2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x857134", Offset = "0x857134", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x857190", Offset = "0x857190", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x857198", Offset = "0x857198", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			internal int <Activate>b__13_0(MartianSky.Ufo ufo1, MartianSky.Ufo ufo2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40084D1")]
			public static readonly MartianSky.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40084D2")]
			public static Comparison<MartianSky.Ufo> <>9__13_0;
		}
	}
}
