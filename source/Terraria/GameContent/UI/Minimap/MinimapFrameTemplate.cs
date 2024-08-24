using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x020006B3 RID: 1715
	[global::Cpp2ILInjected.Token(Token = "0x2000A8D")]
	public class MinimapFrameTemplate
	{
		// Token: 0x06004395 RID: 17301 RVA: 0x0002E16C File Offset: 0x0002C36C
		[global::Cpp2ILInjected.Token(Token = "0x6004FCF")]
		[global::Cpp2ILInjected.Address(RVA = "0x901C5C", Offset = "0x901C5C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MinimapFrameTemplate(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition)
		{
			throw null;
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x0002E16F File Offset: 0x0002C36F
		[global::Cpp2ILInjected.Token(Token = "0x6004FD0")]
		[global::Cpp2ILInjected.Address(RVA = "0x901CD4", Offset = "0x901CD4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = "CreateAndAdd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrameTemplate), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "SetResetButton", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "SetZoomOutButton", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "SetZoomInButton", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public MinimapFrame CreateInstance(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x0002E172 File Offset: 0x0002C372
		[global::Cpp2ILInjected.Token(Token = "0x6004FD1")]
		[global::Cpp2ILInjected.Address(RVA = "0x159393C", Offset = "0x159393C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameTemplate), Member = "CreateInstance", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(MinimapFrame))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
		{
			throw null;
		}

		// Token: 0x04006F7F RID: 28543
		[global::Cpp2ILInjected.Token(Token = "0x40088A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04006F80 RID: 28544
		[global::Cpp2ILInjected.Token(Token = "0x40088A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Vector2 frameOffset;

		// Token: 0x04006F81 RID: 28545
		[global::Cpp2ILInjected.Token(Token = "0x40088A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Vector2 resetPosition;

		// Token: 0x04006F82 RID: 28546
		[global::Cpp2ILInjected.Token(Token = "0x40088AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Vector2 zoomInPosition;

		// Token: 0x04006F83 RID: 28547
		[global::Cpp2ILInjected.Token(Token = "0x40088AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Vector2 zoomOutPosition;
	}
}
