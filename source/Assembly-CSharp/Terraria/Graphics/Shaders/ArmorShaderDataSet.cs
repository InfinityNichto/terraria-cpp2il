using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Items;
using Terraria.Graphics.Light;
using Terraria.ID;
using Terraria.Initializers;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004EB RID: 1259
	[global::Cpp2ILInjected.Token(Token = "0x2000746")]
	public class ArmorShaderDataSet
	{
		// Token: 0x060036E7 RID: 14055 RVA: 0x0002BCFA File Offset: 0x00029EFA
		[global::Cpp2ILInjected.Token(Token = "0x6003D5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D6F64", Offset = "0x14D6F64", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadBasicColorDye", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 72)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public T BindShader<T>(int itemId, T shaderData) where T : ArmorShaderData
		{
			throw null;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x0002BCFD File Offset: 0x00029EFD
		[global::Cpp2ILInjected.Token(Token = "0x6003D5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0524", Offset = "0x14A0524", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2),
			typeof(LightMap),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EntitySpriteDraw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EntitySpriteDraw", MemberParameters = new object[] { typeof(DrawData) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Apply(int shaderId, Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x0002BD00 File Offset: 0x00029F00
		[global::Cpp2ILInjected.Token(Token = "0x6003D5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A065C", Offset = "0x14A065C", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void ApplySecondary(int shaderId, Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x0002BD03 File Offset: 0x00029F03
		[global::Cpp2ILInjected.Token(Token = "0x6003D5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A07A4", Offset = "0x14A07A4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.Minecart), Member = "SparksMeow", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ArmorShaderData GetShaderFromItemId(int type)
		{
			throw null;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x0002BD06 File Offset: 0x00029F06
		[global::Cpp2ILInjected.Token(Token = "0x6003D5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A085C", Offset = "0x14A085C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ItemVariant)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "FixRecipes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples.CommonlyUsedContentSamples), Member = "PrepareAfterEverythingElseLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetShaderIdFromItemId(int type)
		{
			throw null;
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x0002BD09 File Offset: 0x00029F09
		[global::Cpp2ILInjected.Token(Token = "0x6003D5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A08F0", Offset = "0x14A08F0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 108)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ArmorShaderData GetSecondaryShader(int id, Player player)
		{
			throw null;
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x0002BD0C File Offset: 0x00029F0C
		[global::Cpp2ILInjected.Token(Token = "0x6003D60")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0998", Offset = "0x14A0998", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameShaders), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ArmorShaderDataSet()
		{
			throw null;
		}

		// Token: 0x04006758 RID: 26456
		[global::Cpp2ILInjected.Token(Token = "0x4007C40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected List<ArmorShaderData> _shaderData;

		// Token: 0x04006759 RID: 26457
		[global::Cpp2ILInjected.Token(Token = "0x4007C41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected Dictionary<int, int> _shaderLookupDictionary;

		// Token: 0x0400675A RID: 26458
		[global::Cpp2ILInjected.Token(Token = "0x4007C42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected int _shaderDataCount;
	}
}
