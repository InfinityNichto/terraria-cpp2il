using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Dyes;

namespace Terraria.Graphics.Shaders
{
	[global::Cpp2ILInjected.Token(Token = "0x200074C")]
	public class ShaderData
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000782")]
		public Effect Shader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003DA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x149FEF4", Offset = "0x149FEF4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
			{
				typeof(Entity),
				typeof(DrawData?)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x149FEC8", Offset = "0x149FEC8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ShaderData(Ref<Effect> shader, string passName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A37D0", Offset = "0x14A37D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Apply(Entity entity, DrawData? drawData = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A225C", Offset = "0x14A225C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiscShaderData), Member = "Apply", MemberParameters = new object[] { typeof(DrawData?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Apply()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007C67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Ref<Effect> _shader;

		[global::Cpp2ILInjected.Token(Token = "0x4007C68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string _passName;

		[global::Cpp2ILInjected.Token(Token = "0x4007C69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public EffectPass _effectPass;
	}
}
