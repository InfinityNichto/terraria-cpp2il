using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000587 RID: 1415
	[global::Cpp2ILInjected.Token(Token = "0x2000821")]
	public class BloodMoonScreenShaderData : ScreenShaderData
	{
		// Token: 0x06003B9A RID: 15258 RVA: 0x0002CA65 File Offset: 0x0002AC65
		[global::Cpp2ILInjected.Token(Token = "0x60042B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x7979C0", Offset = "0x7979C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BloodMoonScreenShaderData(string passName)
		{
			throw null;
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x0002CA68 File Offset: 0x0002AC68
		[global::Cpp2ILInjected.Token(Token = "0x60042B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x7979C8", Offset = "0x7979C8", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SmoothStep", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void Update(GameTime gameTime)
		{
			throw null;
		}
	}
}
