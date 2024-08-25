using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Dyes
{
	[global::Cpp2ILInjected.Token(Token = "0x200081A")]
	public class LegacyHairShaderData : HairShaderData
	{
		[global::Cpp2ILInjected.Token(Token = "0x60042A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x7966C0", Offset = "0x7966C0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadLegacyHairdyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HairShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		public LegacyHairShaderData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60042A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x7966E8", Offset = "0x7966E8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector4", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector4), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Vector4)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector4) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override Color GetColor(Player player, Color lightColor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60042A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x79681C", Offset = "0x79681C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadLegacyHairdyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public LegacyHairShaderData UseLegacyMethod(LegacyHairShaderData.ColorProcessingMethod colorProcessor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40080EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private LegacyHairShaderData.ColorProcessingMethod _colorProcessor;

		[global::Cpp2ILInjected.Token(Token = "0x200081B")]
		public delegate Color ColorProcessingMethod(Player player, Color color, ref bool lighting);
	}
}
