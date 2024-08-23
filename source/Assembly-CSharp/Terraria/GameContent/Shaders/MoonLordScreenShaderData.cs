using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent.Shaders
{
	// Token: 0x02000588 RID: 1416
	[global::Cpp2ILInjected.Token(Token = "0x2000822")]
	public class MoonLordScreenShaderData : ScreenShaderData
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x0002CA6B File Offset: 0x0002AC6B
		[global::Cpp2ILInjected.Token(Token = "0x60042B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x797BC0", Offset = "0x797BC0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenEffectInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MoonLordScreenShaderData(string passName, bool aimAtPlayer)
		{
			throw null;
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x0002CA6E File Offset: 0x0002AC6E
		[global::Cpp2ILInjected.Token(Token = "0x60042B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x797BF0", Offset = "0x797BF0", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MoonLordScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void UpdateMoonLordIndex()
		{
			throw null;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x0002CA71 File Offset: 0x0002AC71
		[global::Cpp2ILInjected.Token(Token = "0x60042B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x797D2C", Offset = "0x797D2C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MoonLordScreenShaderData), Member = "UpdateMoonLordIndex", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "UseTargetPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(ScreenShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Apply()
		{
			throw null;
		}

		// Token: 0x04006B0D RID: 27405
		[global::Cpp2ILInjected.Token(Token = "0x40080F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int _moonLordIndex;

		// Token: 0x04006B0E RID: 27406
		[global::Cpp2ILInjected.Token(Token = "0x40080F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private bool _aimAtPlayer;
	}
}
