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
	[global::Cpp2ILInjected.Token(Token = "0x200074A")]
	public class MiscShaderData : ShaderData
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003D78")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1B54", Offset = "0x14A1B54", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Apply(Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A231C", Offset = "0x14A231C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public MiscShaderData UseColor(Color color)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2350", Offset = "0x14A2350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMisc", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public MiscShaderData UseSamplerState(SamplerState state)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AFE4", Offset = "0x149AFE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseImage0(Asset<Texture2D> texture)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D81")]
		[global::Cpp2ILInjected.Address(RVA = "0x149AFEC", Offset = "0x149AFEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseImage1(Asset<Texture2D> texture)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D83")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2664", Offset = "0x14A2664", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseImage2(Asset<Texture2D> texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D84")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A266C", Offset = "0x14A266C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool IsPowerOfTwo(int n)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D87")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2750", Offset = "0x14A2750", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public MiscShaderData UseSecondaryColor(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D88")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2744", Offset = "0x14A2744", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseSecondaryColor(Vector3 color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D89")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2784", Offset = "0x14A2784", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadMiscVertexShaders", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public MiscShaderData UseProjectionMatrix(bool doUse)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x149D194", Offset = "0x149D194", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MiscShaderData UseSaturation(float saturation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A2790", Offset = "0x14A2790", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual MiscShaderData GetSecondaryShader(Entity entity)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007C50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector3 _uColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Vector3 _uSecondaryColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _uSaturation;

		[global::Cpp2ILInjected.Token(Token = "0x4007C53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _uOpacity;

		[global::Cpp2ILInjected.Token(Token = "0x4007C54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _uImage0;

		[global::Cpp2ILInjected.Token(Token = "0x4007C55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Asset<Texture2D> _uImage1;

		[global::Cpp2ILInjected.Token(Token = "0x4007C56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Asset<Texture2D> _uImage2;

		[global::Cpp2ILInjected.Token(Token = "0x4007C57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _useProjectionMatrix;

		[global::Cpp2ILInjected.Token(Token = "0x4007C58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private Vector4 _shaderSpecificData;

		[global::Cpp2ILInjected.Token(Token = "0x4007C59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private SamplerState _customSamplerState;
	}
}
