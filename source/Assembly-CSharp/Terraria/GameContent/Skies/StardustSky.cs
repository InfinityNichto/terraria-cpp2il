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
	// Token: 0x02000663 RID: 1635
	[global::Cpp2ILInjected.Token(Token = "0x20009DE")]
	public class StardustSky : CustomSky
	{
		// Token: 0x06003FF1 RID: 16369 RVA: 0x0002D6B0 File Offset: 0x0002B8B0
		[global::Cpp2ILInjected.Token(Token = "0x6004A67")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B3EC", Offset = "0x85B3EC", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FF2 RID: 16370 RVA: 0x0002D6B3 File Offset: 0x0002B8B3
		[global::Cpp2ILInjected.Token(Token = "0x6004A68")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B708", Offset = "0x85B708", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003FF3 RID: 16371 RVA: 0x0002D6B6 File Offset: 0x0002B8B6
		[global::Cpp2ILInjected.Token(Token = "0x6004A69")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B7A8", Offset = "0x85B7A8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override Color OnTileColor(Color inColor)
		{
			throw null;
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x0002D6B9 File Offset: 0x0002B8B9
		[global::Cpp2ILInjected.Token(Token = "0x6004A6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x85B8AC", Offset = "0x85B8AC", Length = "0x9D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x0002D6BC File Offset: 0x0002B8BC
		[global::Cpp2ILInjected.Token(Token = "0x6004A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C280", Offset = "0x85C280", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x0002D6BF File Offset: 0x0002B8BF
		[global::Cpp2ILInjected.Token(Token = "0x6004A6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C2A8", Offset = "0x85C2A8", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<StardustSky.Star>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(StardustSky.Star) }, MemberParameters = new object[]
		{
			typeof(StardustSky.Star[]),
			typeof(Comparison<StardustSky.Star>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x0002D6C2 File Offset: 0x0002B8C2
		[global::Cpp2ILInjected.Token(Token = "0x6004A6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C574", Offset = "0x85C574", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		private int SortMethod(StardustSky.Star meteor1, StardustSky.Star meteor2)
		{
			throw null;
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x0002D6C5 File Offset: 0x0002B8C5
		[global::Cpp2ILInjected.Token(Token = "0x6004A6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C584", Offset = "0x85C584", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x0002D6C8 File Offset: 0x0002B8C8
		[global::Cpp2ILInjected.Token(Token = "0x6004A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C58C", Offset = "0x85C58C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FFA RID: 16378 RVA: 0x0002D6CB File Offset: 0x0002B8CB
		[global::Cpp2ILInjected.Token(Token = "0x6004A70")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C594", Offset = "0x85C594", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FFB RID: 16379 RVA: 0x0002D6CE File Offset: 0x0002B8CE
		[global::Cpp2ILInjected.Token(Token = "0x6004A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C5BC", Offset = "0x85C5BC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StardustSky()
		{
			throw null;
		}

		// Token: 0x04006D05 RID: 27909
		[global::Cpp2ILInjected.Token(Token = "0x4008502")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04006D06 RID: 27910
		[global::Cpp2ILInjected.Token(Token = "0x4008503")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04006D07 RID: 27911
		[global::Cpp2ILInjected.Token(Token = "0x4008504")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04006D08 RID: 27912
		[global::Cpp2ILInjected.Token(Token = "0x4008505")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D>[] _starTextures;

		// Token: 0x04006D09 RID: 27913
		[global::Cpp2ILInjected.Token(Token = "0x4008506")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _isActive;

		// Token: 0x04006D0A RID: 27914
		[global::Cpp2ILInjected.Token(Token = "0x4008507")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private StardustSky.Star[] _stars;

		// Token: 0x04006D0B RID: 27915
		[global::Cpp2ILInjected.Token(Token = "0x4008508")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private float _fadeOpacity;

		// Token: 0x02000A5A RID: 2650
		[global::Cpp2ILInjected.Token(Token = "0x20009DF")]
		private struct Star
		{
			// Token: 0x04008E16 RID: 36374
			[global::Cpp2ILInjected.Token(Token = "0x4008509")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04008E17 RID: 36375
			[global::Cpp2ILInjected.Token(Token = "0x400850A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Depth;

			// Token: 0x04008E18 RID: 36376
			[global::Cpp2ILInjected.Token(Token = "0x400850B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int TextureIndex;

			// Token: 0x04008E19 RID: 36377
			[global::Cpp2ILInjected.Token(Token = "0x400850C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public float SinOffset;

			// Token: 0x04008E1A RID: 36378
			[global::Cpp2ILInjected.Token(Token = "0x400850D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public float AlphaFrequency;

			// Token: 0x04008E1B RID: 36379
			[global::Cpp2ILInjected.Token(Token = "0x400850E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public float AlphaAmplitude;
		}
	}
}
