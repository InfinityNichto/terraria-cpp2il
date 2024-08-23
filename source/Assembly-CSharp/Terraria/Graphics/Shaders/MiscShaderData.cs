using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Animations;
using Terraria.Graphics.Light;
using Terraria.Initializers;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004EF RID: 1263
	[global::Cpp2ILInjected.Token(Token = "0x200074A")]
	public class MiscShaderData : ShaderData
	{
		// Token: 0x06003704 RID: 14084 RVA: 0x0002BD51 File Offset: 0x00029F51
		[global::Cpp2ILInjected.Token(Token = "0x6003D77")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A19E0", Offset = "0x14A19E0", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public MiscShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x0002BD54 File Offset: 0x00029F54
		[global::Cpp2ILInjected.Token(Token = "0x6003D78")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1B54", Offset = "0x14A1B54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Apply(Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x0002BD57 File Offset: 0x00029F57
		[global::Cpp2ILInjected.Token(Token = "0x6003D79")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1BAC", Offset = "0x14A1BAC", Length = "0x6B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public virtual void Apply(DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x0002BD5A File Offset: 0x00029F5A
		[global::Cpp2ILInjected.Token(Token = "0x6003D7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A22D0", Offset = "0x14A22D0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "UpdateSettingsForRendering", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public MiscShaderData UseColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x0002BD5D File Offset: 0x00029F5D
		[global::Cpp2ILInjected.Token(Token = "0x6003D7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A231C", Offset = "0x14A231C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public MiscShaderData UseColor(Color color)
		{
			throw null;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x0002BD60 File Offset: 0x00029F60
		[global::Cpp2ILInjected.Token(Token = "0x6003D7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2310", Offset = "0x14A2310", Length = "0xC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public MiscShaderData UseColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x0002BD63 File Offset: 0x00029F63
		[global::Cpp2ILInjected.Token(Token = "0x6003D7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2350", Offset = "0x14A2350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public MiscShaderData UseSamplerState(SamplerState state)
		{
			throw null;
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x0002BD66 File Offset: 0x00029F66
		[global::Cpp2ILInjected.Token(Token = "0x6003D7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2358", Offset = "0x14A2358", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MiscShaderData UseImage0(string path)
		{
			throw null;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x0002BD69 File Offset: 0x00029F69
		[global::Cpp2ILInjected.Token(Token = "0x6003D7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AFE4", Offset = "0x149AFE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseImage0(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x0002BD6C File Offset: 0x00029F6C
		[global::Cpp2ILInjected.Token(Token = "0x6003D80")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A245C", Offset = "0x14A245C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MiscShaderData UseImage1(string path)
		{
			throw null;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x0002BD6F File Offset: 0x00029F6F
		[global::Cpp2ILInjected.Token(Token = "0x6003D81")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AFEC", Offset = "0x149AFEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseImage1(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x0002BD72 File Offset: 0x00029F72
		[global::Cpp2ILInjected.Token(Token = "0x6003D82")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2560", Offset = "0x14A2560", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public MiscShaderData UseImage2(string path)
		{
			throw null;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x0002BD75 File Offset: 0x00029F75
		[global::Cpp2ILInjected.Token(Token = "0x6003D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2664", Offset = "0x14A2664", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseImage2(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x0002BD78 File Offset: 0x00029F78
		[global::Cpp2ILInjected.Token(Token = "0x6003D84")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A266C", Offset = "0x14A266C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsPowerOfTwo(int n)
		{
			throw null;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x0002BD7B File Offset: 0x00029F7B
		[global::Cpp2ILInjected.Token(Token = "0x6003D85")]
		[global::Cpp2ILInjected.Address(RVA = "0x149D19C", Offset = "0x149D19C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "UpdateSettingsForRendering", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public MiscShaderData UseOpacity(float alpha)
		{
			throw null;
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x0002BD7E File Offset: 0x00029F7E
		[global::Cpp2ILInjected.Token(Token = "0x6003D86")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2704", Offset = "0x14A2704", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public MiscShaderData UseSecondaryColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x0002BD81 File Offset: 0x00029F81
		[global::Cpp2ILInjected.Token(Token = "0x6003D87")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2750", Offset = "0x14A2750", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public MiscShaderData UseSecondaryColor(Color color)
		{
			throw null;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x0002BD84 File Offset: 0x00029F84
		[global::Cpp2ILInjected.Token(Token = "0x6003D88")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2744", Offset = "0x14A2744", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseSecondaryColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x0002BD87 File Offset: 0x00029F87
		[global::Cpp2ILInjected.Token(Token = "0x6003D89")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2784", Offset = "0x14A2784", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public MiscShaderData UseProjectionMatrix(bool doUse)
		{
			throw null;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0002BD8A File Offset: 0x00029F8A
		[global::Cpp2ILInjected.Token(Token = "0x6003D8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x149D194", Offset = "0x149D194", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseSaturation(float saturation)
		{
			throw null;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x0002BD8D File Offset: 0x00029F8D
		[global::Cpp2ILInjected.Token(Token = "0x6003D8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2790", Offset = "0x14A2790", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual MiscShaderData GetSecondaryShader(Entity entity)
		{
			throw null;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x0002BD90 File Offset: 0x00029F90
		[global::Cpp2ILInjected.Token(Token = "0x6003D8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AFD8", Offset = "0x149AFD8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Segments.SpriteSegment.MaskedFadeEffect), Member = "BeforeDrawing", MemberParameters = new object[]
		{
			typeof(ref GameAnimationSegment),
			typeof(ref DrawData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public MiscShaderData UseShaderSpecificData(Vector4 specificData)
		{
			throw null;
		}

		// Token: 0x04006768 RID: 26472
		[global::Cpp2ILInjected.Token(Token = "0x4007C50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector3 _uColor;

		// Token: 0x04006769 RID: 26473
		[global::Cpp2ILInjected.Token(Token = "0x4007C51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Vector3 _uSecondaryColor;

		// Token: 0x0400676A RID: 26474
		[global::Cpp2ILInjected.Token(Token = "0x4007C52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _uSaturation;

		// Token: 0x0400676B RID: 26475
		[global::Cpp2ILInjected.Token(Token = "0x4007C53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _uOpacity;

		// Token: 0x0400676C RID: 26476
		[global::Cpp2ILInjected.Token(Token = "0x4007C54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _uImage0;

		// Token: 0x0400676D RID: 26477
		[global::Cpp2ILInjected.Token(Token = "0x4007C55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Asset<Texture2D> _uImage1;

		// Token: 0x0400676E RID: 26478
		[global::Cpp2ILInjected.Token(Token = "0x4007C56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Asset<Texture2D> _uImage2;

		// Token: 0x0400676F RID: 26479
		[global::Cpp2ILInjected.Token(Token = "0x4007C57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _useProjectionMatrix;

		// Token: 0x04006770 RID: 26480
		[global::Cpp2ILInjected.Token(Token = "0x4007C58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private Vector4 _shaderSpecificData;

		// Token: 0x04006771 RID: 26481
		[global::Cpp2ILInjected.Token(Token = "0x4007C59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private SamplerState _customSamplerState;
	}
}
