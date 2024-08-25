using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Dyes
{
	[global::Cpp2ILInjected.Token(Token = "0x200081D")]
	public class TeamArmorShaderData : ArmorShaderData
	{
		[global::Cpp2ILInjected.Token(Token = "0x60042AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x796F2C", Offset = "0x796F2C", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public TeamArmorShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60042AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x797144", Offset = "0x797144", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "UseColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(ArmorShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Apply(Entity entity, DrawData? drawData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60042AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x7972A8", Offset = "0x7972A8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override ArmorShaderData GetSecondaryShader(Entity entity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40080F0")]
		private static bool isInitialized;

		[global::Cpp2ILInjected.Token(Token = "0x40080F1")]
		private static ArmorShaderData[] dustShaderData;
	}
}
