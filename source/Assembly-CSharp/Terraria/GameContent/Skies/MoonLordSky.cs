using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Initializers;
using Terraria.Utilities;

namespace Terraria.GameContent.Skies
{
	// Token: 0x0200065E RID: 1630
	[global::Cpp2ILInjected.Token(Token = "0x20009D6")]
	public class MoonLordSky : CustomSky
	{
		// Token: 0x06003FBE RID: 16318 RVA: 0x0002D617 File Offset: 0x0002B817
		[global::Cpp2ILInjected.Token(Token = "0x6004A2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8571A8", Offset = "0x8571A8", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MoonLordSky(bool forPlayer)
		{
			throw null;
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x0002D61A File Offset: 0x0002B81A
		[global::Cpp2ILInjected.Token(Token = "0x6004A30")]
		[global::Cpp2ILInjected.Address(RVA = "0x857224", Offset = "0x857224", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x0002D61D File Offset: 0x0002B81D
		[global::Cpp2ILInjected.Token(Token = "0x6004A31")]
		[global::Cpp2ILInjected.Address(RVA = "0x857228", Offset = "0x857228", Length = "0xA8")]
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

		// Token: 0x06003FC1 RID: 16321 RVA: 0x0002D620 File Offset: 0x0002B820
		[global::Cpp2ILInjected.Token(Token = "0x6004A32")]
		[global::Cpp2ILInjected.Address(RVA = "0x8572D0", Offset = "0x8572D0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordSky), Member = "OnTileColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordSky), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordSky), Member = "UpdateMoonLordIndex", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private float GetIntensity()
		{
			throw null;
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x0002D623 File Offset: 0x0002B823
		[global::Cpp2ILInjected.Token(Token = "0x6004A33")]
		[global::Cpp2ILInjected.Address(RVA = "0x85758C", Offset = "0x85758C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordSky), Member = "GetIntensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Color OnTileColor(Color inColor)
		{
			throw null;
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x0002D626 File Offset: 0x0002B826
		[global::Cpp2ILInjected.Token(Token = "0x6004A34")]
		[global::Cpp2ILInjected.Address(RVA = "0x857448", Offset = "0x857448", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordSky), Member = "GetIntensity", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool UpdateMoonLordIndex()
		{
			throw null;
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x0002D629 File Offset: 0x0002B829
		[global::Cpp2ILInjected.Token(Token = "0x6004A35")]
		[global::Cpp2ILInjected.Address(RVA = "0x85768C", Offset = "0x85768C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordSky), Member = "GetIntensity", ReturnType = typeof(float))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x0002D62C File Offset: 0x0002B82C
		[global::Cpp2ILInjected.Token(Token = "0x6004A36")]
		[global::Cpp2ILInjected.Address(RVA = "0x8577E4", Offset = "0x8577E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x0002D62F File Offset: 0x0002B82F
		[global::Cpp2ILInjected.Token(Token = "0x6004A37")]
		[global::Cpp2ILInjected.Address(RVA = "0x8577F4", Offset = "0x8577F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x0002D632 File Offset: 0x0002B832
		[global::Cpp2ILInjected.Token(Token = "0x6004A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x85781C", Offset = "0x85781C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x0002D635 File Offset: 0x0002B835
		[global::Cpp2ILInjected.Token(Token = "0x6004A39")]
		[global::Cpp2ILInjected.Address(RVA = "0x857834", Offset = "0x857834", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0002D638 File Offset: 0x0002B838
		[global::Cpp2ILInjected.Token(Token = "0x6004A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x857840", Offset = "0x857840", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x04006CE7 RID: 27879
		[global::Cpp2ILInjected.Token(Token = "0x40084D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04006CE8 RID: 27880
		[global::Cpp2ILInjected.Token(Token = "0x40084D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _isActive;

		// Token: 0x04006CE9 RID: 27881
		[global::Cpp2ILInjected.Token(Token = "0x40084D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _moonLordIndex;

		// Token: 0x04006CEA RID: 27882
		[global::Cpp2ILInjected.Token(Token = "0x40084D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _forPlayer;

		// Token: 0x04006CEB RID: 27883
		[global::Cpp2ILInjected.Token(Token = "0x40084D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float _fadeOpacity;
	}
}
