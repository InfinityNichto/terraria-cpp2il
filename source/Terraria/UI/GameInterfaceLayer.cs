using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Terraria.Graphics;

namespace Terraria.UI
{
	// Token: 0x020004C0 RID: 1216
	[global::Cpp2ILInjected.Token(Token = "0x20006DF")]
	public class GameInterfaceLayer
	{
		// Token: 0x0600358E RID: 13710 RVA: 0x0002B931 File Offset: 0x00029B31
		[global::Cpp2ILInjected.Token(Token = "0x6003B11")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A04C", Offset = "0x147A04C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyGameInterfaceLayer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(GameInterfaceDrawMethod),
			typeof(InterfaceScaleType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GameInterfaceLayer(string name, InterfaceScaleType scaleType)
		{
			throw null;
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x0002B934 File Offset: 0x00029B34
		[global::Cpp2ILInjected.Token(Token = "0x6003B12")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A07C", Offset = "0x147A07C", Length = "0x328")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "SetZoom_UI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "SetZoom_World", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_ZoomMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "SetZoom_Unscaled", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeLogger), Member = "DrawException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public bool Draw()
		{
			throw null;
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0002B937 File Offset: 0x00029B37
		[global::Cpp2ILInjected.Token(Token = "0x6003B13")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A3A4", Offset = "0x147A3A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual bool DrawSelf()
		{
			throw null;
		}

		// Token: 0x0400668F RID: 26255
		[global::Cpp2ILInjected.Token(Token = "0x4007AF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		// Token: 0x04006690 RID: 26256
		[global::Cpp2ILInjected.Token(Token = "0x4007AF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public InterfaceScaleType ScaleType;
	}
}
