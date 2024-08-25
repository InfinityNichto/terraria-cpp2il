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
	[global::Cpp2ILInjected.Token(Token = "0x2000748")]
	public class HairShaderData : ShaderData
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003D68")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1420", Offset = "0x14A1420", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public HairShaderData UseColor(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D69")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1414", Offset = "0x14A1414", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseColor(Vector3 color)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A1558", Offset = "0x14A1558", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseOpacity(float alpha)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003D6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15AC", Offset = "0x14A15AC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		public HairShaderData UseSecondaryColor(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15A0", Offset = "0x14A15A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseSecondaryColor(Vector3 color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A15E0", Offset = "0x14A15E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public HairShaderData UseSaturation(float saturation)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007C46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected Vector3 _uColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		protected Vector3 _uSecondaryColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected float _uSaturation;

		[global::Cpp2ILInjected.Token(Token = "0x4007C49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		protected float _uOpacity;

		[global::Cpp2ILInjected.Token(Token = "0x4007C4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected Asset<Texture2D> _uImage;

		[global::Cpp2ILInjected.Token(Token = "0x4007C4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected bool _shaderDisabled;

		[global::Cpp2ILInjected.Token(Token = "0x4007C4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private Vector2 _uTargetPosition;
	}
}
