using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Utilities;

namespace Terraria.Graphics
{
	// Token: 0x020004E2 RID: 1250
	[global::Cpp2ILInjected.Token(Token = "0x2000738")]
	public struct FinalFractalHelper
	{
		// Token: 0x060036B2 RID: 14002 RVA: 0x0002BC5B File Offset: 0x00029E5B
		[global::Cpp2ILInjected.Token(Token = "0x6003D14")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A7DC", Offset = "0x149A7DC", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_Shoot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, FinalFractalHelper.FinalFractalProfile>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(IEnumerable<int>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static int GetRandomProfileIndex()
		{
			throw null;
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0002BC5E File Offset: 0x00029E5E
		[global::Cpp2ILInjected.Token(Token = "0x6003D15")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A958", Offset = "0x149A958", Length = "0x5B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FinalFractalHelper), Member = "GetFinalFractalProfile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(FinalFractalHelper.FinalFractalProfile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "PrepareStrip", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(int?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "DrawTrail", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public void Draw(Projectile proj)
		{
			throw null;
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x0002BC61 File Offset: 0x00029E61
		[global::Cpp2ILInjected.Token(Token = "0x6003D16")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AF10", Offset = "0x149AF10", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_182_FinalFractal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FinalFractalHelper), Member = "Draw", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, FinalFractalHelper.FinalFractalProfile>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref FinalFractalHelper.FinalFractalProfile)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static FinalFractalHelper.FinalFractalProfile GetFinalFractalProfile(int usedSwordId)
		{
			throw null;
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x0002BC64 File Offset: 0x00029E64
		[global::Cpp2ILInjected.Token(Token = "0x6003D17")]
		[global::Cpp2ILInjected.Address(RVA = "0x149B514", Offset = "0x149B514", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Color StripColors(float progressOnStrip)
		{
			throw null;
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x0002BC67 File Offset: 0x00029E67
		[global::Cpp2ILInjected.Token(Token = "0x6003D18")]
		[global::Cpp2ILInjected.Address(RVA = "0x149B60C", Offset = "0x149B60C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private float StripWidth(float progressOnStrip)
		{
			throw null;
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0002BC6A File Offset: 0x00029E6A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003D19")]
		[global::Cpp2ILInjected.Address(RVA = "0x149B618", Offset = "0x149B618", Length = "0x81C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, FinalFractalHelper.FinalFractalProfile>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FinalFractalHelper.FinalFractalProfile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, FinalFractalHelper.FinalFractalProfile>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(FinalFractalHelper.FinalFractalProfile)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static FinalFractalHelper()
		{
			throw null;
		}

		// Token: 0x04006729 RID: 26409
		[global::Cpp2ILInjected.Token(Token = "0x4007C09")]
		public const int TotalIllusions = 4;

		// Token: 0x0400672A RID: 26410
		[global::Cpp2ILInjected.Token(Token = "0x4007C0A")]
		public const int FramesPerImportantTrail = 15;

		// Token: 0x0400672B RID: 26411
		[global::Cpp2ILInjected.Token(Token = "0x4007C0B")]
		private static VertexStrip _vertexStrip;

		// Token: 0x0400672C RID: 26412
		[global::Cpp2ILInjected.Token(Token = "0x4007C0C")]
		private static Dictionary<int, FinalFractalHelper.FinalFractalProfile> _fractalProfiles;

		// Token: 0x0400672D RID: 26413
		[global::Cpp2ILInjected.Token(Token = "0x4007C0D")]
		private static FinalFractalHelper.FinalFractalProfile _defaultProfile;

		// Token: 0x0400672E RID: 26414
		[global::Cpp2ILInjected.Token(Token = "0x4007C0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Asset<Texture2D> FinalFractalAsset;

		// Token: 0x0400672F RID: 26415
		[global::Cpp2ILInjected.Token(Token = "0x4007C0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Asset<Texture2D> MagicMissileTrailErosionAsset;

		// Token: 0x02000963 RID: 2403
		// (Invoke) Token: 0x06004D3D RID: 19773
		[global::Cpp2ILInjected.Token(Token = "0x2000739")]
		public delegate void SpawnDustMethod(Vector2 centerPosition, float rotation, Vector2 velocity);

		// Token: 0x02000964 RID: 2404
		[global::Cpp2ILInjected.Token(Token = "0x200073A")]
		public struct FinalFractalProfile
		{
			// Token: 0x06004D40 RID: 19776 RVA: 0x0002FA41 File Offset: 0x0002DC41
			[global::Cpp2ILInjected.Token(Token = "0x6003D1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x149BF48", Offset = "0x149BF48", Length = "0x1B0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FinalFractalHelper), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip.StripHalfWidthFunction), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip.StripColorFunction), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FinalFractalHelper.SpawnDustMethod), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			public FinalFractalProfile(float fullBladeLength, Color color)
			{
				throw null;
			}

			// Token: 0x06004D41 RID: 19777 RVA: 0x0002FA44 File Offset: 0x0002DC44
			[global::Cpp2ILInjected.Token(Token = "0x6003D1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x149C434", Offset = "0x149C434", Length = "0x2DC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(Vector2?),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Dust))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotationVector2", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(Vector2))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void StripDust(Vector2 centerPosition, float rotation, Vector2 velocity)
			{
				throw null;
			}

			// Token: 0x06004D42 RID: 19778 RVA: 0x0002FA47 File Offset: 0x0002DC47
			[global::Cpp2ILInjected.Token(Token = "0x6003D20")]
			[global::Cpp2ILInjected.Address(RVA = "0x149C710", Offset = "0x149C710", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void StripColors(float progressOnStrip, out Color col)
			{
				throw null;
			}

			// Token: 0x06004D43 RID: 19779 RVA: 0x0002FA4A File Offset: 0x0002DC4A
			[global::Cpp2ILInjected.Token(Token = "0x6003D21")]
			[global::Cpp2ILInjected.Address(RVA = "0x149C7E0", Offset = "0x149C7E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private float StripWidth(float progressOnStrip)
			{
				throw null;
			}

			// Token: 0x04008B96 RID: 35734
			[global::Cpp2ILInjected.Token(Token = "0x4007C10")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float trailWidth;

			// Token: 0x04008B97 RID: 35735
			[global::Cpp2ILInjected.Token(Token = "0x4007C11")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public Color trailColor;

			// Token: 0x04008B98 RID: 35736
			[global::Cpp2ILInjected.Token(Token = "0x4007C12")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public FinalFractalHelper.SpawnDustMethod dustMethod;

			// Token: 0x04008B99 RID: 35737
			[global::Cpp2ILInjected.Token(Token = "0x4007C13")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public VertexStrip.StripColorFunction colorMethod;

			// Token: 0x04008B9A RID: 35738
			[global::Cpp2ILInjected.Token(Token = "0x4007C14")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public VertexStrip.StripHalfWidthFunction widthMethod;
		}
	}
}
