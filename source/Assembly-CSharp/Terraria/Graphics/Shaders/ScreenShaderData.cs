using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Shaders;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Light;
using Terraria.Initializers;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004F0 RID: 1264
	[global::Cpp2ILInjected.Token(Token = "0x200074B")]
	public class ScreenShaderData : ShaderData
	{
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600371A RID: 14106 RVA: 0x0002BD93 File Offset: 0x00029F93
		[global::Cpp2ILInjected.Token(Token = "0x17000780")]
		public float Intensity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A2794", Offset = "0x14A2794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0002BD96 File Offset: 0x00029F96
		[global::Cpp2ILInjected.Token(Token = "0x17000781")]
		public float CombinedOpacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A279C", Offset = "0x14A279C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Filter), Member = "IsVisible", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleOverlay), Member = "IsVisible", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x0002BD99 File Offset: 0x00029F99
		[global::Cpp2ILInjected.Token(Token = "0x6003D8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A27A8", Offset = "0x14A27A8", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BloodMoonScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordScreenShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public ScreenShaderData(string passName)
		{
			throw null;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x0002BD9C File Offset: 0x00029F9C
		[global::Cpp2ILInjected.Token(Token = "0x6003D90")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2B28", Offset = "0x14A2B28", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleOverlay), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(EffectPriority),
			typeof(RenderLayers)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		public ScreenShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x0002BD9F File Offset: 0x00029F9F
		[global::Cpp2ILInjected.Token(Token = "0x6003D91")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2E84", Offset = "0x14A2E84", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public virtual void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x0002BDA2 File Offset: 0x00029FA2
		[global::Cpp2ILInjected.Token(Token = "0x6003D92")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2E88", Offset = "0x14A2E88", Length = "0x5F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Asset<>), Member = "get_IsLoaded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public override void Apply()
		{
			throw null;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x0002BDA5 File Offset: 0x00029FA5
		[global::Cpp2ILInjected.Token(Token = "0x6003D93")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3478", Offset = "0x14A3478", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ScreenShaderData UseImageOffset(Vector2 offset)
		{
			throw null;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x0002BDA8 File Offset: 0x00029FA8
		[global::Cpp2ILInjected.Token(Token = "0x6003D94")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3480", Offset = "0x14A3480", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		public ScreenShaderData UseIntensity(float intensity)
		{
			throw null;
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x0002BDAB File Offset: 0x00029FAB
		[global::Cpp2ILInjected.Token(Token = "0x6003D95")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3488", Offset = "0x14A3488", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public ScreenShaderData UseColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x0002BDAE File Offset: 0x00029FAE
		[global::Cpp2ILInjected.Token(Token = "0x6003D96")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A34D4", Offset = "0x14A34D4", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		public ScreenShaderData UseProgress(float progress)
		{
			throw null;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x0002BDB1 File Offset: 0x00029FB1
		[global::Cpp2ILInjected.Token(Token = "0x6003D97")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A34DC", Offset = "0x14A34DC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ScreenShaderData UseImage(Texture2D image, int index = 0, SamplerState samplerState = null)
		{
			throw null;
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x0002BDB4 File Offset: 0x00029FB4
		[global::Cpp2ILInjected.Token(Token = "0x6003D98")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3570", Offset = "0x14A3570", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ScreenShaderData UseImage(string path, int index = 0, SamplerState samplerState = null)
		{
			throw null;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x0002BDB7 File Offset: 0x00029FB7
		[global::Cpp2ILInjected.Token(Token = "0x6003D99")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A36E8", Offset = "0x14A36E8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public ScreenShaderData UseColor(Color color)
		{
			throw null;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x0002BDBA File Offset: 0x00029FBA
		[global::Cpp2ILInjected.Token(Token = "0x6003D9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A34C8", Offset = "0x14A34C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ScreenShaderData UseColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x0002BDBD File Offset: 0x00029FBD
		[global::Cpp2ILInjected.Token(Token = "0x6003D9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A371C", Offset = "0x14A371C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public ScreenShaderData UseDirection(Vector2 direction)
		{
			throw null;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		[global::Cpp2ILInjected.Token(Token = "0x6003D9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3724", Offset = "0x14A3724", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Filter), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Filter), Member = "Activate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FilterManager), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleOverlay), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public ScreenShaderData UseGlobalOpacity(float opacity)
		{
			throw null;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0002BDC3 File Offset: 0x00029FC3
		[global::Cpp2ILInjected.Token(Token = "0x6003D9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A372C", Offset = "0x14A372C", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ManageSpecialBiomeVisuals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Filter), Member = "Activate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleOverlay), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BlizzardShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SandstormShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public ScreenShaderData UseTargetPosition(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x0002BDC6 File Offset: 0x00029FC6
		[global::Cpp2ILInjected.Token(Token = "0x6003D9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3734", Offset = "0x14A3734", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public ScreenShaderData UseSecondaryColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x0002BDC9 File Offset: 0x00029FC9
		[global::Cpp2ILInjected.Token(Token = "0x6003D9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3780", Offset = "0x14A3780", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public ScreenShaderData UseSecondaryColor(Color color)
		{
			throw null;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x0002BDCC File Offset: 0x00029FCC
		[global::Cpp2ILInjected.Token(Token = "0x6003DA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3774", Offset = "0x14A3774", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ScreenShaderData UseSecondaryColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x0002BDCF File Offset: 0x00029FCF
		[global::Cpp2ILInjected.Token(Token = "0x6003DA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A37B4", Offset = "0x14A37B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateBiomes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BloodMoonScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SepiaScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		public ScreenShaderData UseOpacity(float opacity)
		{
			throw null;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x0002BDD2 File Offset: 0x00029FD2
		[global::Cpp2ILInjected.Token(Token = "0x6003DA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A37BC", Offset = "0x14A37BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public ScreenShaderData UseImageScale(Vector2 scale, int index = 0)
		{
			throw null;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x0002BDD5 File Offset: 0x00029FD5
		[global::Cpp2ILInjected.Token(Token = "0x6003DA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A37CC", Offset = "0x14A37CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual ScreenShaderData GetSecondaryShader(Player player)
		{
			throw null;
		}

		// Token: 0x04006772 RID: 26482
		[global::Cpp2ILInjected.Token(Token = "0x4007C5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector3 _uColor;

		// Token: 0x04006773 RID: 26483
		[global::Cpp2ILInjected.Token(Token = "0x4007C5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Vector3 _uSecondaryColor;

		// Token: 0x04006774 RID: 26484
		[global::Cpp2ILInjected.Token(Token = "0x4007C5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _uOpacity;

		// Token: 0x04006775 RID: 26485
		[global::Cpp2ILInjected.Token(Token = "0x4007C5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _globalOpacity;

		// Token: 0x04006776 RID: 26486
		[global::Cpp2ILInjected.Token(Token = "0x4007C5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private float _uIntensity;

		// Token: 0x04006777 RID: 26487
		[global::Cpp2ILInjected.Token(Token = "0x4007C5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private Vector2 _uTargetPosition;

		// Token: 0x04006778 RID: 26488
		[global::Cpp2ILInjected.Token(Token = "0x4007C60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private Vector2 _uDirection;

		// Token: 0x04006779 RID: 26489
		[global::Cpp2ILInjected.Token(Token = "0x4007C61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private float _uProgress;

		// Token: 0x0400677A RID: 26490
		[global::Cpp2ILInjected.Token(Token = "0x4007C62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Vector2 _uImageOffset;

		// Token: 0x0400677B RID: 26491
		[global::Cpp2ILInjected.Token(Token = "0x4007C63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Asset<Texture2D>[] _uAssetImages;

		// Token: 0x0400677C RID: 26492
		[global::Cpp2ILInjected.Token(Token = "0x4007C64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Texture2D[] _uCustomImages;

		// Token: 0x0400677D RID: 26493
		[global::Cpp2ILInjected.Token(Token = "0x4007C65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private SamplerState[] _samplerStates;

		// Token: 0x0400677E RID: 26494
		[global::Cpp2ILInjected.Token(Token = "0x4007C66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Vector2[] _imageScales;
	}
}
