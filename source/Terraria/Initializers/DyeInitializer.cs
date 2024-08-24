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
	// Token: 0x020003D5 RID: 981
	[global::Cpp2ILInjected.Token(Token = "0x200058A")]
	public static class DyeInitializer
	{
		// Token: 0x0600300F RID: 12303 RVA: 0x0002A977 File Offset: 0x00028B77
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

		// Token: 0x06003010 RID: 12304 RVA: 0x0002A97A File Offset: 0x00028B7A
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

		// Token: 0x06003011 RID: 12305 RVA: 0x0002A97D File Offset: 0x00028B7D
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

		// Token: 0x06003012 RID: 12306 RVA: 0x0002A980 File Offset: 0x00028B80
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

		// Token: 0x06003013 RID: 12307 RVA: 0x0002A983 File Offset: 0x00028B83
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

		// Token: 0x06003014 RID: 12308 RVA: 0x0002A986 File Offset: 0x00028B86
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

		// Token: 0x06003015 RID: 12309 RVA: 0x0002A989 File Offset: 0x00028B89
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

		// Token: 0x06003016 RID: 12310 RVA: 0x0002A98C File Offset: 0x00028B8C
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

		// Token: 0x06003017 RID: 12311 RVA: 0x0002A98F File Offset: 0x00028B8F
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

		// Token: 0x06003018 RID: 12312 RVA: 0x0002A992 File Offset: 0x00028B92
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

		// Token: 0x02000905 RID: 2309
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200058B")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C31 RID: 19505 RVA: 0x0002F7BC File Offset: 0x0002D9BC
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

			// Token: 0x06004C32 RID: 19506 RVA: 0x0002F7BF File Offset: 0x0002D9BF
			[global::Cpp2ILInjected.Token(Token = "0x60034A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C1F0", Offset = "0x137C1F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004C33 RID: 19507 RVA: 0x0002F7C2 File Offset: 0x0002D9C2
			[global::Cpp2ILInjected.Token(Token = "0x60034A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C1F8", Offset = "0x137C1F8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Color <LoadLegacyHairdyes>b__5_0(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			// Token: 0x06004C34 RID: 19508 RVA: 0x0002F7C5 File Offset: 0x0002D9C5
			[global::Cpp2ILInjected.Token(Token = "0x60034A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x137C248", Offset = "0x137C248", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal Color <LoadLegacyHairdyes>b__5_1(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			// Token: 0x06004C35 RID: 19509 RVA: 0x0002F7C8 File Offset: 0x0002D9C8
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

			// Token: 0x06004C36 RID: 19510 RVA: 0x0002F7CB File Offset: 0x0002D9CB
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

			// Token: 0x06004C37 RID: 19511 RVA: 0x0002F7CE File Offset: 0x0002D9CE
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

			// Token: 0x06004C38 RID: 19512 RVA: 0x0002F7D1 File Offset: 0x0002D9D1
			[global::Cpp2ILInjected.Token(Token = "0x60034A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CAFC", Offset = "0x137CAFC", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal Color <LoadLegacyHairdyes>b__5_5(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			// Token: 0x06004C39 RID: 19513 RVA: 0x0002F7D4 File Offset: 0x0002D9D4
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

			// Token: 0x06004C3A RID: 19514 RVA: 0x0002F7D7 File Offset: 0x0002D9D7
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

			// Token: 0x06004C3B RID: 19515 RVA: 0x0002F7DA File Offset: 0x0002D9DA
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

			// Token: 0x06004C3C RID: 19516 RVA: 0x0002F7DD File Offset: 0x0002D9DD
			[global::Cpp2ILInjected.Token(Token = "0x60034AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x137CFB0", Offset = "0x137CFB0", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal Color <LoadLegacyHairdyes>b__5_9(Player player, Color newColor, ref bool lighting)
			{
				throw null;
			}

			// Token: 0x06004C3D RID: 19517 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
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

			// Token: 0x0400855B RID: 34139
			[global::Cpp2ILInjected.Token(Token = "0x400415D")]
			public static readonly DyeInitializer.<>c <>9;

			// Token: 0x0400855C RID: 34140
			[global::Cpp2ILInjected.Token(Token = "0x400415E")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_0;

			// Token: 0x0400855D RID: 34141
			[global::Cpp2ILInjected.Token(Token = "0x400415F")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_1;

			// Token: 0x0400855E RID: 34142
			[global::Cpp2ILInjected.Token(Token = "0x4004160")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_2;

			// Token: 0x0400855F RID: 34143
			[global::Cpp2ILInjected.Token(Token = "0x4004161")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_3;

			// Token: 0x04008560 RID: 34144
			[global::Cpp2ILInjected.Token(Token = "0x4004162")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_4;

			// Token: 0x04008561 RID: 34145
			[global::Cpp2ILInjected.Token(Token = "0x4004163")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_5;

			// Token: 0x04008562 RID: 34146
			[global::Cpp2ILInjected.Token(Token = "0x4004164")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_6;

			// Token: 0x04008563 RID: 34147
			[global::Cpp2ILInjected.Token(Token = "0x4004165")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_7;

			// Token: 0x04008564 RID: 34148
			[global::Cpp2ILInjected.Token(Token = "0x4004166")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_8;

			// Token: 0x04008565 RID: 34149
			[global::Cpp2ILInjected.Token(Token = "0x4004167")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_9;

			// Token: 0x04008566 RID: 34150
			[global::Cpp2ILInjected.Token(Token = "0x4004168")]
			public static LegacyHairShaderData.ColorProcessingMethod <>9__5_10;
		}
	}
}
