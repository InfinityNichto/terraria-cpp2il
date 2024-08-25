using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007FC")]
	public class Profiles
	{
		[global::Cpp2ILInjected.Token(Token = "0x6004194")]
		[global::Cpp2ILInjected.Address(RVA = "0x78175C", Offset = "0x78175C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Profiles()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007FD")]
		public class StackedNPCProfile : ITownNPCProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004195")]
			[global::Cpp2ILInjected.Address(RVA = "0x77FE68", Offset = "0x77FE68", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public StackedNPCProfile(params ITownNPCProfile[] profilesInOrderOfVariants)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004196")]
			[global::Cpp2ILInjected.Address(RVA = "0x781764", Offset = "0x781764", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int RollVariation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004197")]
			[global::Cpp2ILInjected.Address(RVA = "0x78176C", Offset = "0x78176C", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(object[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public string GetNameForVariant(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004198")]
			[global::Cpp2ILInjected.Address(RVA = "0x781880", Offset = "0x781880", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(object[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6004199")]
			[global::Cpp2ILInjected.Address(RVA = "0x781994", Offset = "0x781994", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "IndexInRange", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(object[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public int GetHeadTextureIndex(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008075")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal ITownNPCProfile[] _profiles;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007FE")]
		public class LegacyNPCProfile : ITownNPCProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x600419A")]
			[global::Cpp2ILInjected.Address(RVA = "0x77FBF8", Offset = "0x77FBF8", Length = "0x270")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = "LegacyWithSimpleShimmer", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(ITownNPCProfile))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			public LegacyNPCProfile(string npcFileTitleFilePath, int defaultHeadIndex, bool includeDefault = true, bool uniquePartyTexture = true)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600419B")]
			[global::Cpp2ILInjected.Address(RVA = "0x781AA8", Offset = "0x781AA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int RollVariation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600419C")]
			[global::Cpp2ILInjected.Address(RVA = "0x781AB0", Offset = "0x781AB0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "getNewNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public string GetNameForVariant(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600419D")]
			[global::Cpp2ILInjected.Address(RVA = "0x781B0C", Offset = "0x781B0C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600419E")]
			[global::Cpp2ILInjected.Address(RVA = "0x781B3C", Offset = "0x781B3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int GetHeadTextureIndex(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008076")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _rootFilePath;

			[global::Cpp2ILInjected.Token(Token = "0x4008077")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _defaultVariationHeadIndex;

			[global::Cpp2ILInjected.Token(Token = "0x4008078")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal Asset<Texture2D> _defaultNoAlt;

			[global::Cpp2ILInjected.Token(Token = "0x4008079")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Asset<Texture2D> _defaultParty;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20007FF")]
		public class TransformableNPCProfile : ITownNPCProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x600419F")]
			[global::Cpp2ILInjected.Address(RVA = "0x780024", Offset = "0x780024", Length = "0x2E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = "TransformableWithSimpleShimmer", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(ITownNPCProfile))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			public TransformableNPCProfile(string npcFileTitleFilePath, int defaultHeadIndex, bool includeCredits = true)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x781B44", Offset = "0x781B44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int RollVariation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x781B4C", Offset = "0x781B4C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "getNewNPCName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public string GetNameForVariant(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x781BA8", Offset = "0x781BA8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x781BE4", Offset = "0x781BE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int GetHeadTextureIndex(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400807A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _rootFilePath;

			[global::Cpp2ILInjected.Token(Token = "0x400807B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _defaultVariationHeadIndex;

			[global::Cpp2ILInjected.Token(Token = "0x400807C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal Asset<Texture2D> _defaultNoAlt;

			[global::Cpp2ILInjected.Token(Token = "0x400807D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Asset<Texture2D> _defaultTransformed;

			[global::Cpp2ILInjected.Token(Token = "0x400807E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal Asset<Texture2D> _defaultCredits;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000800")]
		public class VariantNPCProfile : ITownNPCProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x60041A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x7813D8", Offset = "0x7813D8", Length = "0x21C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TownNPCProfiles), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public VariantNPCProfile(string npcFileTitleFilePath, string npcBaseName, int[] variantHeadIds, params string[] variantTextureNames)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x781BEC", Offset = "0x781BEC", Length = "0x1D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public Profiles.VariantNPCProfile SetPartyTextures(params string[] variantTextureNames)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x781DBC", Offset = "0x781DBC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public int RollVariation()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x781E24", Offset = "0x781E24", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "get_genRand", ReturnType = typeof(UnifiedRandom))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "RandomFromCategory", MemberParameters = new object[]
			{
				typeof(string),
				typeof(UnifiedRandom)
			}, ReturnType = typeof(LocalizedText))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public string GetNameForVariant(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x781ED8", Offset = "0x781ED8", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60041A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x781FF4", Offset = "0x781FF4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public int GetHeadTextureIndex(NPC npc)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400807F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string _rootFilePath;

			[global::Cpp2ILInjected.Token(Token = "0x4008080")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string _npcBaseName;

			[global::Cpp2ILInjected.Token(Token = "0x4008081")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int[] _variantHeadIDs;

			[global::Cpp2ILInjected.Token(Token = "0x4008082")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string[] _variants;

			[global::Cpp2ILInjected.Token(Token = "0x4008083")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal Dictionary<string, Asset<Texture2D>> _variantTextures;
		}
	}
}
