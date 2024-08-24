using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Dyes
{
	// Token: 0x02000582 RID: 1410
	[global::Cpp2ILInjected.Token(Token = "0x200081C")]
	public class ReflectiveArmorShaderData : ArmorShaderData
	{
		// Token: 0x06003B8E RID: 15246 RVA: 0x0002CA41 File Offset: 0x0002AC41
		[global::Cpp2ILInjected.Token(Token = "0x60042A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x796A68", Offset = "0x796A68", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DyeInitializer), Member = "LoadArmorDyes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		public ReflectiveArmorShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x0002CA44 File Offset: 0x0002AC44
		[global::Cpp2ILInjected.Token(Token = "0x60042AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x796A70", Offset = "0x796A70", Length = "0x4BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrawData?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShaderData), Member = "get_Shader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetSubLight", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "SetValue", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override void Apply(Entity entity, DrawData? drawData)
		{
			throw null;
		}
	}
}
