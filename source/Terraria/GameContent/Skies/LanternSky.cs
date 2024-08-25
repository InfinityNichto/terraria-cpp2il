using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Events;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	[global::Cpp2ILInjected.Token(Token = "0x20009CE")]
	public class LanternSky : CustomSky
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x839ED8", Offset = "0x839ED8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnLoad()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A02")]
		[global::Cpp2ILInjected.Address(RVA = "0x839F44", Offset = "0x839F44", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "Activate", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky), Member = "ResetLantern", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void GenerateLanterns(bool onlyMissing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x83A13C", Offset = "0x83A13C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "GenerateLanterns", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky.Lantern), Member = "set_Texture", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ResetLantern(int i)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A04")]
		[global::Cpp2ILInjected.Address(RVA = "0x83A268", Offset = "0x83A268", Length = "0x37C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternNight), Member = "get_LanternsUp", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToDirectionInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky.Lantern), Member = "get_FloatAdjustedSpeed", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky), Member = "ResetLantern", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A05")]
		[global::Cpp2ILInjected.Address(RVA = "0x83A5E4", Offset = "0x83A5E4", Length = "0x57C")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky), Member = "DrawLantern", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(LanternSky.Lantern),
			typeof(Color),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A06")]
		[global::Cpp2ILInjected.Address(RVA = "0x83AB60", Offset = "0x83AB60", Length = "0x448")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky.Lantern), Member = "GetSourceRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void DrawLantern(SpriteBatch spriteBatch, LanternSky.Lantern lantern, Color opacity, Vector2 depthScale, Vector2 position, float alpha)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A07")]
		[global::Cpp2ILInjected.Address(RVA = "0x83AFA8", Offset = "0x83AFA8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LanternSky), Member = "GenerateLanterns", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A08")]
		[global::Cpp2ILInjected.Address(RVA = "0x83AFE8", Offset = "0x83AFE8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x83AFF4", Offset = "0x83AFF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x83AFFC", Offset = "0x83AFFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x83B004", Offset = "0x83B004", Length = "0x1060")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public LanternSky()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40084A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private bool _active;

		[global::Cpp2ILInjected.Token(Token = "0x40084A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D")]
		private bool _leaving;

		[global::Cpp2ILInjected.Token(Token = "0x40084A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float _opacity;

		[global::Cpp2ILInjected.Token(Token = "0x40084A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Asset<Texture2D> _texture;

		[global::Cpp2ILInjected.Token(Token = "0x40084A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private LanternSky.Lantern[] _lanterns;

		[global::Cpp2ILInjected.Token(Token = "0x40084A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private UnifiedRandom _random;

		[global::Cpp2ILInjected.Token(Token = "0x40084A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _lanternsDrawing;

		[global::Cpp2ILInjected.Token(Token = "0x40084AA")]
		private const float slowDown = 0.5f;

		[global::Cpp2ILInjected.Token(Token = "0x20009CF")]
		private struct Lantern
		{
			[global::Cpp2ILInjected.Token(Token = "0x17000851")]
			public Texture2D Texture
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A0C")]
				[global::Cpp2ILInjected.Address(RVA = "0x855C80", Offset = "0x855C80", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6004A0D")]
				[global::Cpp2ILInjected.Address(RVA = "0x855C88", Offset = "0x855C88", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "ResetLantern", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				set
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x17000852")]
			public float FloatAdjustedSpeed
			{
				[global::Cpp2ILInjected.Token(Token = "0x6004A0E")]
				[global::Cpp2ILInjected.Address(RVA = "0x855CB8", Offset = "0x855CB8", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004A0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x855CD4", Offset = "0x855CD4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanternSky), Member = "DrawLantern", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(LanternSky.Lantern),
				typeof(Color),
				typeof(Vector2),
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
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

			[global::Cpp2ILInjected.Token(Token = "0x40084AB")]
			private const int MAX_FRAMES_X = 3;

			[global::Cpp2ILInjected.Token(Token = "0x40084AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int Variant;

			[global::Cpp2ILInjected.Token(Token = "0x40084AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public int TimeUntilFloat;

			[global::Cpp2ILInjected.Token(Token = "0x40084AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int TimeUntilFloatMax;

			[global::Cpp2ILInjected.Token(Token = "0x40084AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Texture2D _texture;

			[global::Cpp2ILInjected.Token(Token = "0x40084B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Vector2 Position;

			[global::Cpp2ILInjected.Token(Token = "0x40084B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public float Depth;

			[global::Cpp2ILInjected.Token(Token = "0x40084B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
			public float Rotation;

			[global::Cpp2ILInjected.Token(Token = "0x40084B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int FrameHeight;

			[global::Cpp2ILInjected.Token(Token = "0x40084B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			public int FrameWidth;

			[global::Cpp2ILInjected.Token(Token = "0x40084B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public float Speed;

			[global::Cpp2ILInjected.Token(Token = "0x40084B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public bool Active;
		}
	}
}
