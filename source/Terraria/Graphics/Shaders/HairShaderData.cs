using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.Dyes;
using Terraria.Initializers;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020004ED RID: 1261
	[global::Cpp2ILInjected.Token(Token = "0x2000748")]
	public class HairShaderData : ShaderData
	{
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x0002BD15 File Offset: 0x00029F15
		[global::Cpp2ILInjected.Token(Token = "0x1700077F")]
		public bool ShaderDisabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003D63")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A0C1C", Offset = "0x14A0C1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x0002BD18 File Offset: 0x00029F18
		[global::Cpp2ILInjected.Token(Token = "0x6003D64")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0C24", Offset = "0x14A0C24", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyHairShaderData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwilightHairDyeShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public HairShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0002BD1B File Offset: 0x00029F1B
		[global::Cpp2ILInjected.Token(Token = "0x6003D65")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0D98", Offset = "0x14A0D98", Length = "0x54C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwilightHairDyeShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public virtual void Apply(Player player, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x0002BD1E File Offset: 0x00029F1E
		[global::Cpp2ILInjected.Token(Token = "0x6003D66")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A12E4", Offset = "0x14A12E4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual Color GetColor(Player player, Color lightColor)
		{
			throw null;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x0002BD21 File Offset: 0x00029F21
		[global::Cpp2ILInjected.Token(Token = "0x6003D67")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A13D4", Offset = "0x14A13D4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadHairDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public HairShaderData UseColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x0002BD24 File Offset: 0x00029F24
		[global::Cpp2ILInjected.Token(Token = "0x6003D68")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1420", Offset = "0x14A1420", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public HairShaderData UseColor(Color color)
		{
			throw null;
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x0002BD27 File Offset: 0x00029F27
		[global::Cpp2ILInjected.Token(Token = "0x6003D69")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1414", Offset = "0x14A1414", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x0002BD2A File Offset: 0x00029F2A
		[global::Cpp2ILInjected.Token(Token = "0x6003D6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1454", Offset = "0x14A1454", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadHairDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public HairShaderData UseImage(string path)
		{
			throw null;
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x0002BD2D File Offset: 0x00029F2D
		[global::Cpp2ILInjected.Token(Token = "0x6003D6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1558", Offset = "0x14A1558", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseOpacity(float alpha)
		{
			throw null;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x0002BD30 File Offset: 0x00029F30
		[global::Cpp2ILInjected.Token(Token = "0x6003D6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1560", Offset = "0x14A1560", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public HairShaderData UseSecondaryColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x0002BD33 File Offset: 0x00029F33
		[global::Cpp2ILInjected.Token(Token = "0x6003D6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15AC", Offset = "0x14A15AC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public HairShaderData UseSecondaryColor(Color color)
		{
			throw null;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x0002BD36 File Offset: 0x00029F36
		[global::Cpp2ILInjected.Token(Token = "0x6003D6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15A0", Offset = "0x14A15A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseSecondaryColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x0002BD39 File Offset: 0x00029F39
		[global::Cpp2ILInjected.Token(Token = "0x6003D6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15E0", Offset = "0x14A15E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseSaturation(float saturation)
		{
			throw null;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x0002BD3C File Offset: 0x00029F3C
		[global::Cpp2ILInjected.Token(Token = "0x6003D70")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15E8", Offset = "0x14A15E8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwilightHairDyeShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public HairShaderData UseTargetPosition(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0400675E RID: 26462
		[global::Cpp2ILInjected.Token(Token = "0x4007C46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected Vector3 _uColor;

		// Token: 0x0400675F RID: 26463
		[global::Cpp2ILInjected.Token(Token = "0x4007C47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		protected Vector3 _uSecondaryColor;

		// Token: 0x04006760 RID: 26464
		[global::Cpp2ILInjected.Token(Token = "0x4007C48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected float _uSaturation;

		// Token: 0x04006761 RID: 26465
		[global::Cpp2ILInjected.Token(Token = "0x4007C49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		protected float _uOpacity;

		// Token: 0x04006762 RID: 26466
		[global::Cpp2ILInjected.Token(Token = "0x4007C4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected Asset<Texture2D> _uImage;

		// Token: 0x04006763 RID: 26467
		[global::Cpp2ILInjected.Token(Token = "0x4007C4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected bool _shaderDisabled;

		// Token: 0x04006764 RID: 26468
		[global::Cpp2ILInjected.Token(Token = "0x4007C4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private Vector2 _uTargetPosition;
	}
}
