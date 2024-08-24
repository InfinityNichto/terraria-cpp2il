using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.Minimap
{
	// Token: 0x020006B2 RID: 1714
	[global::Cpp2ILInjected.Token(Token = "0x2000A8C")]
	public class MinimapFrameManager : SelectionHolder<MinimapFrame>
	{
		// Token: 0x0600438E RID: 17294 RVA: 0x0002E157 File Offset: 0x0002C357
		[global::Cpp2ILInjected.Token(Token = "0x6004FC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9013E8", Offset = "0x9013E8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void Configuration_OnLoad(Preferences obj)
		{
			throw null;
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x0002E15A File Offset: 0x0002C35A
		[global::Cpp2ILInjected.Token(Token = "0x6004FC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x901498", Offset = "0x901498", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void Configuration_Save(Preferences obj)
		{
			throw null;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0002E15D File Offset: 0x0002C35D
		[global::Cpp2ILInjected.Token(Token = "0x6004FCA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9014F4", Offset = "0x9014F4", Length = "0x674")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrameManager), Member = "CreateAndAdd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0002E160 File Offset: 0x0002C360
		[global::Cpp2ILInjected.Token(Token = "0x6004FCB")]
		[global::Cpp2ILInjected.Address(RVA = "0x901B68", Offset = "0x901B68", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrameManager), Member = "PopulateOptionsAndLoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrameTemplate), Member = "CreateInstance", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(MinimapFrame))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void CreateAndAdd(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0002E163 File Offset: 0x0002C363
		[global::Cpp2ILInjected.Token(Token = "0x6004FCC")]
		[global::Cpp2ILInjected.Address(RVA = "0x901E8C", Offset = "0x901E8C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "DrawBackground", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public void DrawTo(SpriteBatch spriteBatch, Vector2 position)
		{
			throw null;
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x0002E166 File Offset: 0x0002C366
		[global::Cpp2ILInjected.Token(Token = "0x6004FCD")]
		[global::Cpp2ILInjected.Address(RVA = "0x901EC0", Offset = "0x901EC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "DrawForeground", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		public void DrawForeground(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x0002E169 File Offset: 0x0002C369
		[global::Cpp2ILInjected.Token(Token = "0x6004FCE")]
		[global::Cpp2ILInjected.Address(RVA = "0x901EC8", Offset = "0x901EC8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SelectionHolder<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MinimapFrameManager()
		{
			throw null;
		}
	}
}
