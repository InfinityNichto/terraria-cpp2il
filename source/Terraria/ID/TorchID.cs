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
	[global::Cpp2ILInjected.Token(Token = "0x2000600")]
	public static class TorchID
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007331")]
		public static int[] Dust;

		[global::Cpp2ILInjected.Token(Token = "0x4007332")]
		private static TorchID.ITorchLightProvider[] _lights;

		[global::Cpp2ILInjected.Token(Token = "0x4007333")]
		public const short Torch = 0;

		[global::Cpp2ILInjected.Token(Token = "0x4007334")]
		public const short Blue = 1;

		[global::Cpp2ILInjected.Token(Token = "0x4007335")]
		public const short Red = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4007336")]
		public const short Green = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4007337")]
		public const short Purple = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4007338")]
		public const short White = 5;

		[global::Cpp2ILInjected.Token(Token = "0x4007339")]
		public const short Yellow = 6;

		[global::Cpp2ILInjected.Token(Token = "0x400733A")]
		public const short Demon = 7;

		[global::Cpp2ILInjected.Token(Token = "0x400733B")]
		public const short Cursed = 8;

		[global::Cpp2ILInjected.Token(Token = "0x400733C")]
		public const short Ice = 9;

		[global::Cpp2ILInjected.Token(Token = "0x400733D")]
		public const short Orange = 10;

		[global::Cpp2ILInjected.Token(Token = "0x400733E")]
		public const short Ichor = 11;

		[global::Cpp2ILInjected.Token(Token = "0x400733F")]
		public const short UltraBright = 12;

		[global::Cpp2ILInjected.Token(Token = "0x4007340")]
		public const short Bone = 13;

		[global::Cpp2ILInjected.Token(Token = "0x4007341")]
		public const short Rainbow = 14;

		[global::Cpp2ILInjected.Token(Token = "0x4007342")]
		public const short Pink = 15;

		[global::Cpp2ILInjected.Token(Token = "0x4007343")]
		public const short Desert = 16;

		[global::Cpp2ILInjected.Token(Token = "0x4007344")]
		public const short Coral = 17;

		[global::Cpp2ILInjected.Token(Token = "0x4007345")]
		public const short Corrupt = 18;

		[global::Cpp2ILInjected.Token(Token = "0x4007346")]
		public const short Crimson = 19;

		[global::Cpp2ILInjected.Token(Token = "0x4007347")]
		public const short Hallowed = 20;

		[global::Cpp2ILInjected.Token(Token = "0x4007348")]
		public const short Jungle = 21;

		[global::Cpp2ILInjected.Token(Token = "0x4007349")]
		public const short Mushroom = 22;

		[global::Cpp2ILInjected.Token(Token = "0x400734A")]
		public const short Shimmer = 23;

		[global::Cpp2ILInjected.Token(Token = "0x400734B")]
		public static readonly short Count;

		[global::Cpp2ILInjected.Token(Token = "0x2000601")]
		private interface ITorchLightProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60035A8")]
			void GetRGB(out float r, out float g, out float b);
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000602")]
		private struct ConstantTorchLight : TorchID.ITorchLightProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60035A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x13D9ED0", Offset = "0x13D9ED0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public ConstantTorchLight(float Red, float Green, float Blue)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60035AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DA0BC", Offset = "0x13DA0BC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void GetRGB(out float r, out float g, out float b)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400734C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public float R;

			[global::Cpp2ILInjected.Token(Token = "0x400734D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			public float G;

			[global::Cpp2ILInjected.Token(Token = "0x400734E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public float B;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000603")]
		private struct DemonTorchLight : TorchID.ITorchLightProvider
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000604")]
		private struct ShimmerTorchLight : TorchID.ITorchLightProvider
		{
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

		[global::Cpp2ILInjected.Token(Token = "0x2000605")]
		private struct DiscoTorchLight : TorchID.ITorchLightProvider
		{
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
