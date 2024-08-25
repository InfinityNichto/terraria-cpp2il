using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;
using UnityEngine;

namespace Terraria.Graphics.Effects
{
	[global::Cpp2ILInjected.Token(Token = "0x2000783")]
	public class Filter : GameEffect
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003EF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B34", Offset = "0x740B34", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Filter(ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x740B64", Offset = "0x740B64", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseGlobalOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Update(GameTime gameTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x740BA0", Offset = "0x740BA0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Apply()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x740BB0", Offset = "0x740BB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ScreenShaderData GetShader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x740BB8", Offset = "0x740BB8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseGlobalOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Microsoft.Xna.Framework.Vector2) }, ReturnType = typeof(ScreenShaderData))]
		public override void Activate(Microsoft.Xna.Framework.Vector2 position, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x740C08", Offset = "0x740C08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Deactivate(params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x740C10", Offset = "0x740C10", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool IsInUse()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x740C30", Offset = "0x740C30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool IsActive()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003EF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x740C38", Offset = "0x740C38", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "get_CombinedOpacity", ReturnType = typeof(float))]
		public override bool IsVisible()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007D7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public bool Active;

		[global::Cpp2ILInjected.Token(Token = "0x4007D7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ScreenShaderData _shader;

		[global::Cpp2ILInjected.Token(Token = "0x4007D7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool IsHidden;
	}
}
