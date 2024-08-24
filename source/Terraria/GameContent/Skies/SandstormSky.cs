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
	// Token: 0x02000660 RID: 1632
	[global::Cpp2ILInjected.Token(Token = "0x20009D9")]
	public class SandstormSky : CustomSky
	{
		// Token: 0x06003FD5 RID: 16341 RVA: 0x0002D65C File Offset: 0x0002B85C
		[global::Cpp2ILInjected.Token(Token = "0x6004A46")]
		[global::Cpp2ILInjected.Address(RVA = "0x858CBC", Offset = "0x858CBC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x0002D65F File Offset: 0x0002B85F
		[global::Cpp2ILInjected.Token(Token = "0x6004A47")]
		[global::Cpp2ILInjected.Address(RVA = "0x858CC0", Offset = "0x858CC0", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x0002D662 File Offset: 0x0002B862
		[global::Cpp2ILInjected.Token(Token = "0x6004A48")]
		[global::Cpp2ILInjected.Address(RVA = "0x858DB0", Offset = "0x858DB0", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(float)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x0002D665 File Offset: 0x0002B865
		[global::Cpp2ILInjected.Token(Token = "0x6004A49")]
		[global::Cpp2ILInjected.Address(RVA = "0x859050", Offset = "0x859050", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FD9 RID: 16345 RVA: 0x0002D668 File Offset: 0x0002B868
		[global::Cpp2ILInjected.Token(Token = "0x6004A4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x85905C", Offset = "0x85905C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FDA RID: 16346 RVA: 0x0002D66B File Offset: 0x0002B86B
		[global::Cpp2ILInjected.Token(Token = "0x6004A4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x859068", Offset = "0x859068", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FDB RID: 16347 RVA: 0x0002D66E File Offset: 0x0002B86E
		[global::Cpp2ILInjected.Token(Token = "0x6004A4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x859074", Offset = "0x859074", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x0002D671 File Offset: 0x0002B871
		[global::Cpp2ILInjected.Token(Token = "0x6004A4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x85907C", Offset = "0x85907C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SandstormSky()
		{
			throw null;
		}

		// Token: 0x04006CF4 RID: 27892
		[global::Cpp2ILInjected.Token(Token = "0x40084E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private UnifiedRandom _random;

		// Token: 0x04006CF5 RID: 27893
		[global::Cpp2ILInjected.Token(Token = "0x40084E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _isActive;

		// Token: 0x04006CF6 RID: 27894
		[global::Cpp2ILInjected.Token(Token = "0x40084E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _isLeaving;

		// Token: 0x04006CF7 RID: 27895
		[global::Cpp2ILInjected.Token(Token = "0x40084E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float _opacity;
	}
}
