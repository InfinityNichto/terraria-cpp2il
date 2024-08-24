using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Tile_Entities;
using Terraria.Graphics.Renderers;
using Terraria.Graphics.Shaders;

namespace Terraria.DataStructures
{
	// Token: 0x02000442 RID: 1090
	[global::Cpp2ILInjected.Token(Token = "0x200063D")]
	public class PlayerDrawHelper
	{
		// Token: 0x0600313F RID: 12607 RVA: 0x0002ACEF File Offset: 0x00028EEF
		[global::Cpp2ILInjected.Token(Token = "0x600365C")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE6E4", Offset = "0x13DE6E4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_09_Wings", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHeadSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "Draw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static int PackShader(int localShaderIndex, PlayerDrawHelper.ShaderConfiguration shaderType)
		{
			throw null;
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x0002ACF2 File Offset: 0x00028EF2
		[global::Cpp2ILInjected.Token(Token = "0x600365D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE6F0", Offset = "0x13DE6F0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void UnpackShader(int packedShaderIndex, out int localShaderIndex, out PlayerDrawHelper.ShaderConfiguration shaderType)
		{
			throw null;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0002ACF5 File Offset: 0x00028EF5
		[global::Cpp2ILInjected.Token(Token = "0x600365E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DE71C", Offset = "0x13DE71C", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(Vector2[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = ".ctor", MemberParameters = new object[] { typeof(DrawData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "Apply", MemberParameters = new object[]
		{
			typeof(short),
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "Apply", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_tileShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ConvertPaintIdToTileShaderIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public static bool SetShaderForData(Player player, int cHead, ref DrawData cdd, ref EffectPass effectPass)
		{
			throw null;
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x0002ACF8 File Offset: 0x00028EF8
		[global::Cpp2ILInjected.Token(Token = "0x600365F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DED64", Offset = "0x13DED64", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawHeadLayers), Member = "DrawPlayer_RenderAllLayers", MemberParameters = new object[] { typeof(ref PlayerDrawHeadSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref ParticleRendererSettings),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = "RenderDrawData", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = ".ctor", MemberParameters = new object[] { typeof(DrawData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderDataSet), Member = "Apply", MemberParameters = new object[]
		{
			typeof(short),
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "Apply", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_tileShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ConvertPaintIdToTileShaderIndex", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public static bool SetShaderForData(Player player, int cHead, ref DrawData cdd)
		{
			throw null;
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x0002ACFB File Offset: 0x00028EFB
		[global::Cpp2ILInjected.Token(Token = "0x6003660")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DF3AC", Offset = "0x13DF3AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerDrawHelper()
		{
			throw null;
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0002ACFE File Offset: 0x00028EFE
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003661")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DF3B4", Offset = "0x13DF3B4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static PlayerDrawHelper()
		{
			throw null;
		}

		// Token: 0x04006325 RID: 25381
		[global::Cpp2ILInjected.Token(Token = "0x400770F")]
		public static Color DISPLAY_DOLL_DEFAULT_SKIN_COLOR;

		// Token: 0x02000930 RID: 2352
		[global::Cpp2ILInjected.Token(Token = "0x200063E")]
		public enum ShaderConfiguration
		{
			// Token: 0x04008ACA RID: 35530
			[global::Cpp2ILInjected.Token(Token = "0x4007711")]
			ArmorShader,
			// Token: 0x04008ACB RID: 35531
			[global::Cpp2ILInjected.Token(Token = "0x4007712")]
			HairShader,
			// Token: 0x04008ACC RID: 35532
			[global::Cpp2ILInjected.Token(Token = "0x4007713")]
			TileShader,
			// Token: 0x04008ACD RID: 35533
			[global::Cpp2ILInjected.Token(Token = "0x4007714")]
			TilePaintID,
			// Token: 0x04008ACE RID: 35534
			[global::Cpp2ILInjected.Token(Token = "0x4007715")]
			Misc
		}
	}
}
