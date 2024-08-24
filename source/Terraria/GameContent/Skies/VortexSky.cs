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
	// Token: 0x02000664 RID: 1636
	[global::Cpp2ILInjected.Token(Token = "0x20009E0")]
	public class VortexSky : CustomSky
	{
		// Token: 0x06003FFC RID: 16380 RVA: 0x0002D6D1 File Offset: 0x0002B8D1
		[global::Cpp2ILInjected.Token(Token = "0x6004A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C61C", Offset = "0x85C61C", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FFD RID: 16381 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
		[global::Cpp2ILInjected.Token(Token = "0x6004A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x85C920", Offset = "0x85C920", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003FFE RID: 16382 RVA: 0x0002D6D7 File Offset: 0x0002B8D7
		[global::Cpp2ILInjected.Token(Token = "0x6004A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x85CB90", Offset = "0x85CB90", Length = "0x104")]
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

		// Token: 0x06003FFF RID: 16383 RVA: 0x0002D6DA File Offset: 0x0002B8DA
		[global::Cpp2ILInjected.Token(Token = "0x6004A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x85CC94", Offset = "0x85CC94", Length = "0x8A8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06004000 RID: 16384 RVA: 0x0002D6DD File Offset: 0x0002B8DD
		[global::Cpp2ILInjected.Token(Token = "0x6004A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D53C", Offset = "0x85D53C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06004001 RID: 16385 RVA: 0x0002D6E0 File Offset: 0x0002B8E0
		[global::Cpp2ILInjected.Token(Token = "0x6004A77")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D564", Offset = "0x85D564", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06004002 RID: 16386 RVA: 0x0002D6E3 File Offset: 0x0002B8E3
		[global::Cpp2ILInjected.Token(Token = "0x6004A78")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D5F0", Offset = "0x85D5F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06004003 RID: 16387 RVA: 0x0002D6E6 File Offset: 0x0002B8E6
		[global::Cpp2ILInjected.Token(Token = "0x6004A79")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D5F8", Offset = "0x85D5F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06004004 RID: 16388 RVA: 0x0002D6E9 File Offset: 0x0002B8E9
		[global::Cpp2ILInjected.Token(Token = "0x6004A7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D600", Offset = "0x85D600", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06004005 RID: 16389 RVA: 0x0002D6EC File Offset: 0x0002B8EC
		[global::Cpp2ILInjected.Token(Token = "0x6004A7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x85D628", Offset = "0x85D628", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public VortexSky()
		{
			throw null;
		}

		// Token: 0x04006D0C RID: 27916
		[global::Cpp2ILInjected.Token(Token = "0x400850F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04006D0D RID: 27917
		[global::Cpp2ILInjected.Token(Token = "0x4008510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04006D0E RID: 27918
		[global::Cpp2ILInjected.Token(Token = "0x4008511")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04006D0F RID: 27919
		[global::Cpp2ILInjected.Token(Token = "0x4008512")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _boltTexture;

		// Token: 0x04006D10 RID: 27920
		[global::Cpp2ILInjected.Token(Token = "0x4008513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _flashTexture;

		// Token: 0x04006D11 RID: 27921
		[global::Cpp2ILInjected.Token(Token = "0x4008514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _isActive;

		// Token: 0x04006D12 RID: 27922
		[global::Cpp2ILInjected.Token(Token = "0x4008515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int _ticksUntilNextBolt;

		// Token: 0x04006D13 RID: 27923
		[global::Cpp2ILInjected.Token(Token = "0x4008516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private float _fadeOpacity;

		// Token: 0x04006D14 RID: 27924
		[global::Cpp2ILInjected.Token(Token = "0x4008517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private VortexSky.Bolt[] _bolts;

		// Token: 0x02000A5B RID: 2651
		[global::Cpp2ILInjected.Token(Token = "0x20009E1")]
		private struct Bolt
		{
			// Token: 0x04008E1C RID: 36380
			[global::Cpp2ILInjected.Token(Token = "0x4008518")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04008E1D RID: 36381
			[global::Cpp2ILInjected.Token(Token = "0x4008519")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Depth;

			// Token: 0x04008E1E RID: 36382
			[global::Cpp2ILInjected.Token(Token = "0x400851A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			public int Life;

			// Token: 0x04008E1F RID: 36383
			[global::Cpp2ILInjected.Token(Token = "0x400851B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool IsAlive;
		}
	}
}
