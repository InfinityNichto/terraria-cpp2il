using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Dyes;
using Terraria.Graphics.Shaders;
using Terraria.ID;

namespace Terraria.Initializers
{
	[global::Cpp2ILInjected.Token(Token = "0x200058A")]
	public static class DyeInitializer
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003495")]
		[global::Cpp2ILInjected.Address(RVA = "0x1378244", Offset = "0x1378244", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadBasicColorDye", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadBasicColorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "BindShader", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseSaturation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void LoadBasicColorDye(int baseDyeItem, int blackDyeItem, int brightDyeItem, int silverDyeItem, float r, float g, float b, float saturation = 1f, int oldShader = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003496")]
		[global::Cpp2ILInjected.Address(RVA = "0x13784FC", Offset = "0x13784FC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadBasicColorDye", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		private static void LoadBasicColorDye(int baseDyeItem, float r, float g, float b, float saturation = 1f, int oldShader = 1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003497")]
		[global::Cpp2ILInjected.Address(RVA = "0x137850C", Offset = "0x137850C", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadBasicColorDye", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		private static void LoadBasicColorDyes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003498")]
		[global::Cpp2ILInjected.Address(RVA = "0x137871C", Offset = "0x137871C", Length = "0x1E04")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadBasicColorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "BindShader", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseSaturation", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseSecondaryColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectiveArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TeamArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwilightDyeShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseImage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "FixRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 121)]
		private static void LoadArmorDyes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003499")]
		[global::Cpp2ILInjected.Address(RVA = "0x137A624", Offset = "0x137A624", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadLegacyHairdyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwilightHairDyeShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "BindShader", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderData), Member = "UseImage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(HairShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(HairShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void LoadHairDyes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600349A")]
		[global::Cpp2ILInjected.Address(RVA = "0x137A760", Offset = "0x137A760", Length = "0x95C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadHairDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyHairShaderData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyHairShaderData.ColorProcessingMethod), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyHairShaderData), Member = "UseLegacyMethod", MemberParameters = new object[] { typeof(LegacyHairShaderData.ColorProcessingMethod) }, ReturnType = typeof(LegacyHairShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "BindShader", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 73)]
		private static void LoadLegacyHairdyes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600349B")]
		[global::Cpp2ILInjected.Address(RVA = "0x137B0BC", Offset = "0x137B0BC", Length = "0x830")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseImage1", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseImage2", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseSamplerState", MemberParameters = new object[] { typeof(SamplerState) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		private static void LoadMisc()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600349C")]
		[global::Cpp2ILInjected.Address(RVA = "0x137B8EC", Offset = "0x137B8EC", Length = "0x894")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseProjectionMatrix", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseImage0", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseImage1", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseImage2", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private static void LoadMiscVertexShaders()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600349D")]
		[global::Cpp2ILInjected.Address(RVA = "0x137C180", Offset = "0x137C180", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PostContentLoadInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadHairDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		public static void Load()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600349E")]
		[global::Cpp2ILInjected.Address(RVA = "0x137A520", Offset = "0x137A520", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "GetShaderIdFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void FixRecipes()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200058B")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600349F")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C194", Offset = "0x137C194", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C1F0", Offset = "0x137C1F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C1F8", Offset = "0x137C1F8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Color <LoadLegacyHairdyes>b__5_0(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C248", Offset = "0x137C248", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Color <LoadLegacyHairdyes>b__5_1(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C2C8", Offset = "0x137C2C8", Length = "0x2C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Color <LoadLegacyHairdyes>b__5_2(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C58C", Offset = "0x137C58C", Length = "0x334")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "buyPrice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal Color <LoadLegacyHairdyes>b__5_3(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C8C0", Offset = "0x137C8C0", Length = "0x23C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal Color <LoadLegacyHairdyes>b__5_4(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CAFC", Offset = "0x137CAFC", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal Color <LoadLegacyHairdyes>b__5_5(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CBA0", Offset = "0x137CBA0", Length = "0x370")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_ZoneShimmer", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TorchID), Member = "TorchColor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref float),
				typeof(ref float),
				typeof(ref float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterStyle", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			internal Color <LoadLegacyHairdyes>b__5_6(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CF10", Offset = "0x137CF10", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal Color <LoadLegacyHairdyes>b__5_7(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CF3C", Offset = "0x137CF3C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Color <LoadLegacyHairdyes>b__5_8(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CFB0", Offset = "0x137CFB0", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Color <LoadLegacyHairdyes>b__5_9(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60034AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x137D0D0", Offset = "0x137D0D0", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Color <LoadLegacyHairdyes>b__5_10(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400415D")]
			public static readonly DyeInitializer.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x400415E")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_0;

			[global::Cpp2ILInjected.Token(Token = "0x400415F")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_1;

			[global::Cpp2ILInjected.Token(Token = "0x4004160")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_2;

			[global::Cpp2ILInjected.Token(Token = "0x4004161")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_3;

			[global::Cpp2ILInjected.Token(Token = "0x4004162")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_4;

			[global::Cpp2ILInjected.Token(Token = "0x4004163")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_5;

			[global::Cpp2ILInjected.Token(Token = "0x4004164")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_6;

			[global::Cpp2ILInjected.Token(Token = "0x4004165")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_7;

			[global::Cpp2ILInjected.Token(Token = "0x4004166")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_8;

			[global::Cpp2ILInjected.Token(Token = "0x4004167")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_9;

			[global::Cpp2ILInjected.Token(Token = "0x4004168")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_10;
		}
	}
}
