using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace Terraria.GameContent.RGB
{
	// Token: 0x0200058D RID: 1421
	[global::Cpp2ILInjected.Token(Token = "0x2000828")]
	public static class NoiseHelper
	{
		// Token: 0x06003BB3 RID: 15283 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		[global::Cpp2ILInjected.Token(Token = "0x60042D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B2FC", Offset = "0x79B2FC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NoiseHelper), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static float[] CreateStaticNoise(int length)
		{
			throw null;
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x0002CAB3 File Offset: 0x0002ACB3
		[global::Cpp2ILInjected.Token(Token = "0x60042D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B3DC", Offset = "0x79B3DC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static float GetDynamicNoise(int index, float currentTime)
		{
			throw null;
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x0002CAB6 File Offset: 0x0002ACB6
		[global::Cpp2ILInjected.Token(Token = "0x60042D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B498", Offset = "0x79B498", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float GetStaticNoise(int index)
		{
			throw null;
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x0002CAB9 File Offset: 0x0002ACB9
		[global::Cpp2ILInjected.Token(Token = "0x60042D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B500", Offset = "0x79B500", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static float GetDynamicNoise(int x, int y, float currentTime)
		{
			throw null;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x0002CABC File Offset: 0x0002ACBC
		[global::Cpp2ILInjected.Token(Token = "0x60042D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B57C", Offset = "0x79B57C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NoiseHelper), Member = "GetDynamicNoise", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static float GetDynamicNoiseInternal(int x, int y, float wrappedTime)
		{
			throw null;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x0002CABF File Offset: 0x0002ACBF
		[global::Cpp2ILInjected.Token(Token = "0x60042D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B638", Offset = "0x79B638", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NoiseHelper), Member = "GetStaticNoise", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static float GetStaticNoise(int x, int y)
		{
			throw null;
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x0002CAC2 File Offset: 0x0002ACC2
		[global::Cpp2ILInjected.Token(Token = "0x60042D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B6B0", Offset = "0x79B6B0", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoiseHelper), Member = "GetDynamicNoiseInternal", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float GetDynamicNoise(Vector2 position, float currentTime)
		{
			throw null;
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x0002CAC5 File Offset: 0x0002ACC5
		[global::Cpp2ILInjected.Token(Token = "0x60042D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x79B88C", Offset = "0x79B88C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoiseHelper), Member = "GetStaticNoise", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float GetStaticNoise(Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60042D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x79BA3C", Offset = "0x79BA3C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NoiseHelper), Member = "CreateStaticNoise", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static NoiseHelper()
		{
			throw null;
		}

		// Token: 0x04006B2C RID: 27436
		[global::Cpp2ILInjected.Token(Token = "0x4008119")]
		private const int RANDOM_SEED = 1;

		// Token: 0x04006B2D RID: 27437
		[global::Cpp2ILInjected.Token(Token = "0x400811A")]
		private const int NOISE_2D_SIZE = 32;

		// Token: 0x04006B2E RID: 27438
		[global::Cpp2ILInjected.Token(Token = "0x400811B")]
		private const int NOISE_2D_SIZE_MASK = 31;

		// Token: 0x04006B2F RID: 27439
		[global::Cpp2ILInjected.Token(Token = "0x400811C")]
		private const int NOISE_SIZE_MASK = 1023;

		// Token: 0x04006B30 RID: 27440
		[global::Cpp2ILInjected.Token(Token = "0x400811D")]
		private static readonly float[] StaticNoise;
	}
}
