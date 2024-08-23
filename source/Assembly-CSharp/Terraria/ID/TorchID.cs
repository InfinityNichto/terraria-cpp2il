using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Light;
using Terraria.Utilities;

namespace Terraria.ID
{
	// Token: 0x0200040C RID: 1036
	[global::Cpp2ILInjected.Token(Token = "0x2000600")]
	public static class TorchID
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x0002AAFA File Offset: 0x00028CFA
		[global::Cpp2ILInjected.Token(Token = "0x60035A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D97D8", Offset = "0x13D97D8", Length = "0x6F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 58)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x0002AAFD File Offset: 0x00028CFD
		[global::Cpp2ILInjected.Token(Token = "0x60035A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13D9EDC", Offset = "0x13D9EDC", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_007_TownEntities", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Initializers.DyeInitializer.<>c", Member = "<LoadLegacyHairdyes>b__5_6", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(Color),
			typeof(ref bool)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ExportTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(LightMap)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileLightScanner), Member = "ApplyTileLight", MemberParameters = new object[]
		{
			typeof(Tile),
			typeof(int),
			typeof(int),
			typeof(ref FastRandom),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void TorchColor(int torchID, out float R, out float G, out float B)
		{
			throw null;
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x0002AB00 File Offset: 0x00028D00
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60035A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DA018", Offset = "0x13DA018", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static TorchID()
		{
			throw null;
		}

		// Token: 0x04005F62 RID: 24418
		[global::Cpp2ILInjected.Token(Token = "0x4007331")]
		public static int[] Dust;

		// Token: 0x04005F63 RID: 24419
		[global::Cpp2ILInjected.Token(Token = "0x4007332")]
		private static TorchID.ITorchLightProvider[] _lights;

		// Token: 0x04005F64 RID: 24420
		[global::Cpp2ILInjected.Token(Token = "0x4007333")]
		public const short Torch = 0;

		// Token: 0x04005F65 RID: 24421
		[global::Cpp2ILInjected.Token(Token = "0x4007334")]
		public const short Blue = 1;

		// Token: 0x04005F66 RID: 24422
		[global::Cpp2ILInjected.Token(Token = "0x4007335")]
		public const short Red = 2;

		// Token: 0x04005F67 RID: 24423
		[global::Cpp2ILInjected.Token(Token = "0x4007336")]
		public const short Green = 3;

		// Token: 0x04005F68 RID: 24424
		[global::Cpp2ILInjected.Token(Token = "0x4007337")]
		public const short Purple = 4;

		// Token: 0x04005F69 RID: 24425
		[global::Cpp2ILInjected.Token(Token = "0x4007338")]
		public const short White = 5;

		// Token: 0x04005F6A RID: 24426
		[global::Cpp2ILInjected.Token(Token = "0x4007339")]
		public const short Yellow = 6;

		// Token: 0x04005F6B RID: 24427
		[global::Cpp2ILInjected.Token(Token = "0x400733A")]
		public const short Demon = 7;

		// Token: 0x04005F6C RID: 24428
		[global::Cpp2ILInjected.Token(Token = "0x400733B")]
		public const short Cursed = 8;

		// Token: 0x04005F6D RID: 24429
		[global::Cpp2ILInjected.Token(Token = "0x400733C")]
		public const short Ice = 9;

		// Token: 0x04005F6E RID: 24430
		[global::Cpp2ILInjected.Token(Token = "0x400733D")]
		public const short Orange = 10;

		// Token: 0x04005F6F RID: 24431
		[global::Cpp2ILInjected.Token(Token = "0x400733E")]
		public const short Ichor = 11;

		// Token: 0x04005F70 RID: 24432
		[global::Cpp2ILInjected.Token(Token = "0x400733F")]
		public const short UltraBright = 12;

		// Token: 0x04005F71 RID: 24433
		[global::Cpp2ILInjected.Token(Token = "0x4007340")]
		public const short Bone = 13;

		// Token: 0x04005F72 RID: 24434
		[global::Cpp2ILInjected.Token(Token = "0x4007341")]
		public const short Rainbow = 14;

		// Token: 0x04005F73 RID: 24435
		[global::Cpp2ILInjected.Token(Token = "0x4007342")]
		public const short Pink = 15;

		// Token: 0x04005F74 RID: 24436
		[global::Cpp2ILInjected.Token(Token = "0x4007343")]
		public const short Desert = 16;

		// Token: 0x04005F75 RID: 24437
		[global::Cpp2ILInjected.Token(Token = "0x4007344")]
		public const short Coral = 17;

		// Token: 0x04005F76 RID: 24438
		[global::Cpp2ILInjected.Token(Token = "0x4007345")]
		public const short Corrupt = 18;

		// Token: 0x04005F77 RID: 24439
		[global::Cpp2ILInjected.Token(Token = "0x4007346")]
		public const short Crimson = 19;

		// Token: 0x04005F78 RID: 24440
		[global::Cpp2ILInjected.Token(Token = "0x4007347")]
		public const short Hallowed = 20;

		// Token: 0x04005F79 RID: 24441
		[global::Cpp2ILInjected.Token(Token = "0x4007348")]
		public const short Jungle = 21;

		// Token: 0x04005F7A RID: 24442
		[global::Cpp2ILInjected.Token(Token = "0x4007349")]
		public const short Mushroom = 22;

		// Token: 0x04005F7B RID: 24443
		[global::Cpp2ILInjected.Token(Token = "0x400734A")]
		public const short Shimmer = 23;

		// Token: 0x04005F7C RID: 24444
		[global::Cpp2ILInjected.Token(Token = "0x400734B")]
		public static readonly short Count;

		// Token: 0x0200092A RID: 2346
		[global::Cpp2ILInjected.Token(Token = "0x2000601")]
		private interface ITorchLightProvider
		{
			// Token: 0x06004C8B RID: 19595
			[global::Cpp2ILInjected.Token(Token = "0x60035A8")]
			void GetRGB(out float r, out float g, out float b);
		}

		// Token: 0x0200092B RID: 2347
		[global::Cpp2ILInjected.Token(Token = "0x2000602")]
		private struct ConstantTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x06004C8C RID: 19596 RVA: 0x0002F8CA File Offset: 0x0002DACA
			[global::Cpp2ILInjected.Token(Token = "0x60035A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D9ED0", Offset = "0x13D9ED0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ConstantTorchLight(float Red, float Green, float Blue)
			{
				throw null;
			}

			// Token: 0x06004C8D RID: 19597 RVA: 0x0002F8CD File Offset: 0x0002DACD
			[global::Cpp2ILInjected.Token(Token = "0x60035AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DA0BC", Offset = "0x13DA0BC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void GetRGB(out float r, out float g, out float b)
			{
				throw null;
			}

			// Token: 0x04008ABA RID: 35514
			[global::Cpp2ILInjected.Token(Token = "0x400734C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float R;

			// Token: 0x04008ABB RID: 35515
			[global::Cpp2ILInjected.Token(Token = "0x400734D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float G;

			// Token: 0x04008ABC RID: 35516
			[global::Cpp2ILInjected.Token(Token = "0x400734E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float B;
		}

		// Token: 0x0200092C RID: 2348
		[global::Cpp2ILInjected.Token(Token = "0x2000603")]
		private struct DemonTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x06004C8E RID: 19598 RVA: 0x0002F8D0 File Offset: 0x0002DAD0
			[global::Cpp2ILInjected.Token(Token = "0x60035AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DA0D8", Offset = "0x13DA0D8", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void GetRGB(out float r, out float g, out float b)
			{
				throw null;
			}
		}

		// Token: 0x0200092D RID: 2349
		[global::Cpp2ILInjected.Token(Token = "0x2000604")]
		private struct ShimmerTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x06004C8F RID: 19599 RVA: 0x0002F8D3 File Offset: 0x0002DAD3
			[global::Cpp2ILInjected.Token(Token = "0x60035AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DA17C", Offset = "0x13DA17C", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void GetRGB(out float r, out float g, out float b)
			{
				throw null;
			}
		}

		// Token: 0x0200092E RID: 2350
		[global::Cpp2ILInjected.Token(Token = "0x2000605")]
		private struct DiscoTorchLight : TorchID.ITorchLightProvider
		{
			// Token: 0x06004C90 RID: 19600 RVA: 0x0002F8D6 File Offset: 0x0002DAD6
			[global::Cpp2ILInjected.Token(Token = "0x60035AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DA280", Offset = "0x13DA280", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public void GetRGB(out float r, out float g, out float b)
			{
				throw null;
			}
		}
	}
}
