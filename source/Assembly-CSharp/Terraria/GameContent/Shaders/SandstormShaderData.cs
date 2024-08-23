using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000589 RID: 1417
	[global::Cpp2ILInjected.Token(Token = "0x2000823")]
	public class SandstormShaderData : ScreenShaderData
	{
		// Token: 0x06003B9F RID: 15263 RVA: 0x0002CA74 File Offset: 0x0002AC74
		[global::Cpp2ILInjected.Token(Token = "0x60042BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x797DE8", Offset = "0x797DE8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SandstormShaderData(string passName)
		{
			throw null;
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x0002CA77 File Offset: 0x0002AC77
		[global::Cpp2ILInjected.Token(Token = "0x60042BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x797E90", Offset = "0x797E90", Length = "0x210")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x0002CA7A File Offset: 0x0002AC7A
		[global::Cpp2ILInjected.Token(Token = "0x60042BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x7980A0", Offset = "0x7980A0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		public override void Apply()
		{
			throw null;
		}

		// Token: 0x04006B0F RID: 27407
		[global::Cpp2ILInjected.Token(Token = "0x40080F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Vector2 _texturePosition;
	}
}
