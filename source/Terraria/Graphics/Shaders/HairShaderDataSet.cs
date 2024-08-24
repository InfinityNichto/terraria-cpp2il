using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Items;
using Terraria.ID;
using Terraria.Initializers;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004EE RID: 1262
	[global::Cpp2ILInjected.Token(Token = "0x2000749")]
	public class HairShaderDataSet
	{
		// Token: 0x060036FE RID: 14078 RVA: 0x0002BD3F File Offset: 0x00029F3F
		[global::Cpp2ILInjected.Token(Token = "0x6003D71")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B25C", Offset = "0x158B25C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadHairDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadLegacyHairdyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public T BindShader<T>(int itemId, T shaderData) where T : HairShaderData
		{
			throw null;
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x0002BD42 File Offset: 0x00029F42
		[global::Cpp2ILInjected.Token(Token = "0x6003D72")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15F0", Offset = "0x14A15F0", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHelper), Member = "SetShaderForData", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(ref DrawData),
			typeof(ref EffectPass)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHelper), Member = "SetShaderForData", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int),
			typeof(ref DrawData)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Apply(short shaderId, Player player, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x0002BD45 File Offset: 0x00029F45
		[global::Cpp2ILInjected.Token(Token = "0x6003D73")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1730", Offset = "0x14A1730", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetHairColor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Color GetColor(short shaderId, Player player, Color lightColor)
		{
			throw null;
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x0002BD48 File Offset: 0x00029F48
		[global::Cpp2ILInjected.Token(Token = "0x6003D74")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1890", Offset = "0x14A1890", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public HairShaderData GetShaderFromItemId(int type)
		{
			throw null;
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x0002BD4B File Offset: 0x00029F4B
		[global::Cpp2ILInjected.Token(Token = "0x6003D75")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A194C", Offset = "0x14A194C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "FixRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.CommonlyUsedContentSamples), Member = "PrepareAfterEverythingElseLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public short GetShaderIdFromItemId(int type)
		{
			throw null;
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x0002BD4E File Offset: 0x00029F4E
		[global::Cpp2ILInjected.Token(Token = "0x6003D76")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0B58", Offset = "0x14A0B58", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameShaders), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, short>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public HairShaderDataSet()
		{
			throw null;
		}

		// Token: 0x04006765 RID: 26469
		[global::Cpp2ILInjected.Token(Token = "0x4007C4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected List<HairShaderData> _shaderData;

		// Token: 0x04006766 RID: 26470
		[global::Cpp2ILInjected.Token(Token = "0x4007C4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected Dictionary<int, short> _shaderLookupDictionary;

		// Token: 0x04006767 RID: 26471
		[global::Cpp2ILInjected.Token(Token = "0x4007C4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected byte _shaderDataCount;
	}
}
