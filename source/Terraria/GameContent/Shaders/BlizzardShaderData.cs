using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000586 RID: 1414
	[global::Cpp2ILInjected.Token(Token = "0x2000820")]
	public class BlizzardShaderData : ScreenShaderData
	{
		// Token: 0x06003B97 RID: 15255 RVA: 0x0002CA5C File Offset: 0x0002AC5C
		[global::Cpp2ILInjected.Token(Token = "0x60042B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x797650", Offset = "0x797650", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BlizzardShaderData(string passName)
		{
			throw null;
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x0002CA5F File Offset: 0x0002AC5F
		[global::Cpp2ILInjected.Token(Token = "0x60042B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x797704", Offset = "0x797704", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Normalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseDirection", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x0002CA62 File Offset: 0x0002AC62
		[global::Cpp2ILInjected.Token(Token = "0x60042B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x79799C", Offset = "0x79799C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		public override void Apply()
		{
			throw null;
		}

		// Token: 0x04006B0B RID: 27403
		[global::Cpp2ILInjected.Token(Token = "0x40080F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Vector2 _texturePosition;

		// Token: 0x04006B0C RID: 27404
		[global::Cpp2ILInjected.Token(Token = "0x40080F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private float windSpeed;
	}
}
