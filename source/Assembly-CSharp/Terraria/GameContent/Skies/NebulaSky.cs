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
	// Token: 0x0200065F RID: 1631
	[global::Cpp2ILInjected.Token(Token = "0x20009D7")]
	public class NebulaSky : CustomSky
	{
		// Token: 0x06003FCA RID: 16330 RVA: 0x0002D63B File Offset: 0x0002B83B
		[global::Cpp2ILInjected.Token(Token = "0x6004A3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x857868", Offset = "0x857868", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override void OnLoad()
		{
			throw null;
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x0002D63E File Offset: 0x0002B83E
		[global::Cpp2ILInjected.Token(Token = "0x6004A3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x857C24", Offset = "0x857C24", Length = "0xA0")]
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

		// Token: 0x06003FCC RID: 16332 RVA: 0x0002D641 File Offset: 0x0002B841
		[global::Cpp2ILInjected.Token(Token = "0x6004A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x857CC4", Offset = "0x857CC4", Length = "0x104")]
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

		// Token: 0x06003FCD RID: 16333 RVA: 0x0002D644 File Offset: 0x0002B844
		[global::Cpp2ILInjected.Token(Token = "0x6004A3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x857DC8", Offset = "0x857DC8", Length = "0xBC0")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public override void Draw(SpriteBatch spriteBatch, float minDepth, float maxDepth)
		{
			throw null;
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0002D647 File Offset: 0x0002B847
		[global::Cpp2ILInjected.Token(Token = "0x6004A3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x858988", Offset = "0x858988", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override float GetCloudAlpha()
		{
			throw null;
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x0002D64A File Offset: 0x0002B84A
		[global::Cpp2ILInjected.Token(Token = "0x6004A40")]
		[global::Cpp2ILInjected.Address(RVA = "0x8589B0", Offset = "0x8589B0", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<NebulaSky.LightPillar>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(NebulaSky.LightPillar) }, MemberParameters = new object[]
		{
			typeof(NebulaSky.LightPillar[]),
			typeof(Comparison<NebulaSky.LightPillar>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Activate(Vector2 position, params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x0002D64D File Offset: 0x0002B84D
		[global::Cpp2ILInjected.Token(Token = "0x6004A41")]
		[global::Cpp2ILInjected.Address(RVA = "0x858BF4", Offset = "0x858BF4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		private int SortMethod(NebulaSky.LightPillar pillar1, NebulaSky.LightPillar pillar2)
		{
			throw null;
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x0002D650 File Offset: 0x0002B850
		[global::Cpp2ILInjected.Token(Token = "0x6004A42")]
		[global::Cpp2ILInjected.Address(RVA = "0x858C24", Offset = "0x858C24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x0002D653 File Offset: 0x0002B853
		[global::Cpp2ILInjected.Token(Token = "0x6004A43")]
		[global::Cpp2ILInjected.Address(RVA = "0x858C2C", Offset = "0x858C2C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x0002D656 File Offset: 0x0002B856
		[global::Cpp2ILInjected.Token(Token = "0x6004A44")]
		[global::Cpp2ILInjected.Address(RVA = "0x858C34", Offset = "0x858C34", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x0002D659 File Offset: 0x0002B859
		[global::Cpp2ILInjected.Token(Token = "0x6004A45")]
		[global::Cpp2ILInjected.Address(RVA = "0x858C5C", Offset = "0x858C5C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "LoadSkies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomSky), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NebulaSky()
		{
			throw null;
		}

		// Token: 0x04006CEC RID: 27884
		[global::Cpp2ILInjected.Token(Token = "0x40084D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NebulaSky.LightPillar[] _pillars;

		// Token: 0x04006CED RID: 27885
		[global::Cpp2ILInjected.Token(Token = "0x40084D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private UnifiedRandom _random;

		// Token: 0x04006CEE RID: 27886
		[global::Cpp2ILInjected.Token(Token = "0x40084DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Asset<Texture2D> _planetTexture;

		// Token: 0x04006CEF RID: 27887
		[global::Cpp2ILInjected.Token(Token = "0x40084DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _bgTexture;

		// Token: 0x04006CF0 RID: 27888
		[global::Cpp2ILInjected.Token(Token = "0x40084DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _beamTexture;

		// Token: 0x04006CF1 RID: 27889
		[global::Cpp2ILInjected.Token(Token = "0x40084DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D>[] _rockTextures;

		// Token: 0x04006CF2 RID: 27890
		[global::Cpp2ILInjected.Token(Token = "0x40084DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _isActive;

		// Token: 0x04006CF3 RID: 27891
		[global::Cpp2ILInjected.Token(Token = "0x40084DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private float _fadeOpacity;

		// Token: 0x02000A57 RID: 2647
		[global::Cpp2ILInjected.Token(Token = "0x20009D8")]
		private struct LightPillar
		{
			// Token: 0x04008E05 RID: 36357
			[global::Cpp2ILInjected.Token(Token = "0x40084E0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Vector2 Position;

			// Token: 0x04008E06 RID: 36358
			[global::Cpp2ILInjected.Token(Token = "0x40084E1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float Depth;
		}
	}
}
