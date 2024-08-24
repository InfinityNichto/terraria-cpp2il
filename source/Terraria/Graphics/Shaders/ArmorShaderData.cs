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
	// Token: 0x020004EA RID: 1258
	[global::Cpp2ILInjected.Token(Token = "0x2000745")]
	public class ArmorShaderData : ShaderData
	{
		// Token: 0x060036D8 RID: 14040 RVA: 0x0002BCCD File Offset: 0x00029ECD
		[global::Cpp2ILInjected.Token(Token = "0x6003D4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x149FAA0", Offset = "0x149FAA0", Length = "0x428")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeamArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwilightDyeShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 69)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public ArmorShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x0002BCD0 File Offset: 0x00029ED0
		[global::Cpp2ILInjected.Token(Token = "0x6003D4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x149FF0C", Offset = "0x149FF0C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EffectPass),
			typeof(ShaderData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EffectPass GetDustEffect()
		{
			throw null;
		}

		// Token: 0x060036DA RID: 14042 RVA: 0x0002BCD3 File Offset: 0x00029ED3
		[global::Cpp2ILInjected.Token(Token = "0x6003D4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x149FFA0", Offset = "0x149FFA0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ApplyDust()
		{
			throw null;
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x0002BCD6 File Offset: 0x00029ED6
		[global::Cpp2ILInjected.Token(Token = "0x6003D4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x149FFEC", Offset = "0x149FFEC", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeamArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwilightDyeShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Apply(Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x0002BCD9 File Offset: 0x00029ED9
		[global::Cpp2ILInjected.Token(Token = "0x6003D4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0304", Offset = "0x14A0304", Length = "0x40")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public ArmorShaderData UseColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x0002BCDC File Offset: 0x00029EDC
		[global::Cpp2ILInjected.Token(Token = "0x6003D50")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0350", Offset = "0x14A0350", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeamArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeamArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public ArmorShaderData UseColor(Color color)
		{
			throw null;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x0002BCDF File Offset: 0x00029EDF
		[global::Cpp2ILInjected.Token(Token = "0x6003D51")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0344", Offset = "0x14A0344", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ArmorShaderData UseColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x0002BCE2 File Offset: 0x00029EE2
		[global::Cpp2ILInjected.Token(Token = "0x6003D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0384", Offset = "0x14A0384", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ArmorShaderData UseImage(string path)
		{
			throw null;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x0002BCE5 File Offset: 0x00029EE5
		[global::Cpp2ILInjected.Token(Token = "0x6003D53")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0488", Offset = "0x14A0488", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ArmorShaderData UseOpacity(float alpha)
		{
			throw null;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x0002BCE8 File Offset: 0x00029EE8
		[global::Cpp2ILInjected.Token(Token = "0x6003D54")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0490", Offset = "0x14A0490", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TwilightDyeShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ArmorShaderData UseTargetPosition(Vector2 position)
		{
			throw null;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x0002BCEB File Offset: 0x00029EEB
		[global::Cpp2ILInjected.Token(Token = "0x6003D55")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0498", Offset = "0x14A0498", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public ArmorShaderData UseSecondaryColor(float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x0002BCEE File Offset: 0x00029EEE
		[global::Cpp2ILInjected.Token(Token = "0x6003D56")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A04E4", Offset = "0x14A04E4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public ArmorShaderData UseSecondaryColor(Color color)
		{
			throw null;
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x0002BCF1 File Offset: 0x00029EF1
		[global::Cpp2ILInjected.Token(Token = "0x6003D57")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A04D8", Offset = "0x14A04D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ArmorShaderData UseSecondaryColor(Vector3 color)
		{
			throw null;
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x0002BCF4 File Offset: 0x00029EF4
		[global::Cpp2ILInjected.Token(Token = "0x6003D58")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0518", Offset = "0x14A0518", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		public ArmorShaderData UseSaturation(float saturation)
		{
			throw null;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x0002BCF7 File Offset: 0x00029EF7
		[global::Cpp2ILInjected.Token(Token = "0x6003D59")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A0520", Offset = "0x14A0520", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual ArmorShaderData GetSecondaryShader(Entity entity)
		{
			throw null;
		}

		// Token: 0x04006741 RID: 26433
		[global::Cpp2ILInjected.Token(Token = "0x4007C29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector3 _uColor;

		// Token: 0x04006742 RID: 26434
		[global::Cpp2ILInjected.Token(Token = "0x4007C2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private Vector3 _uSecondaryColor;

		// Token: 0x04006743 RID: 26435
		[global::Cpp2ILInjected.Token(Token = "0x4007C2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private float _uSaturation;

		// Token: 0x04006744 RID: 26436
		[global::Cpp2ILInjected.Token(Token = "0x4007C2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private float _uOpacity;

		// Token: 0x04006745 RID: 26437
		[global::Cpp2ILInjected.Token(Token = "0x4007C2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _uImage;

		// Token: 0x04006746 RID: 26438
		[global::Cpp2ILInjected.Token(Token = "0x4007C2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Vector2 _uTargetPosition;

		// Token: 0x04006747 RID: 26439
		[global::Cpp2ILInjected.Token(Token = "0x4007C2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int dustFrame;

		// Token: 0x04006748 RID: 26440
		[global::Cpp2ILInjected.Token(Token = "0x4007C30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private EffectPass dustEffect;

		// Token: 0x04006749 RID: 26441
		[global::Cpp2ILInjected.Token(Token = "0x4007C31")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private EffectParameter _uColorParam;

		// Token: 0x0400674A RID: 26442
		[global::Cpp2ILInjected.Token(Token = "0x4007C32")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private EffectParameter _uSaturationParam;

		// Token: 0x0400674B RID: 26443
		[global::Cpp2ILInjected.Token(Token = "0x4007C33")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private EffectParameter _uSecondaryColorParam;

		// Token: 0x0400674C RID: 26444
		[global::Cpp2ILInjected.Token(Token = "0x4007C34")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EffectParameter _uTimeParam;

		// Token: 0x0400674D RID: 26445
		[global::Cpp2ILInjected.Token(Token = "0x4007C35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private EffectParameter _uOpacityParam;

		// Token: 0x0400674E RID: 26446
		[global::Cpp2ILInjected.Token(Token = "0x4007C36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private EffectParameter _uTargetPositionParam;

		// Token: 0x0400674F RID: 26447
		[global::Cpp2ILInjected.Token(Token = "0x4007C37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private EffectParameter _uSourceRectParam;

		// Token: 0x04006750 RID: 26448
		[global::Cpp2ILInjected.Token(Token = "0x4007C38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private EffectParameter _uLegacyArmorSourceRectParam;

		// Token: 0x04006751 RID: 26449
		[global::Cpp2ILInjected.Token(Token = "0x4007C39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private EffectParameter _uWorldPositionParam;

		// Token: 0x04006752 RID: 26450
		[global::Cpp2ILInjected.Token(Token = "0x4007C3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private EffectParameter _uImageSize0Param;

		// Token: 0x04006753 RID: 26451
		[global::Cpp2ILInjected.Token(Token = "0x4007C3B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private EffectParameter _uLegacyArmorSheetSizeParam;

		// Token: 0x04006754 RID: 26452
		[global::Cpp2ILInjected.Token(Token = "0x4007C3C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private EffectParameter _uRotationParam;

		// Token: 0x04006755 RID: 26453
		[global::Cpp2ILInjected.Token(Token = "0x4007C3D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private EffectParameter _uImageSize1Param;

		// Token: 0x04006756 RID: 26454
		[global::Cpp2ILInjected.Token(Token = "0x4007C3E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private EffectParameter _uDirectionParam;

		// Token: 0x04006757 RID: 26455
		[global::Cpp2ILInjected.Token(Token = "0x4007C3F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool applyingDust;
	}
}
