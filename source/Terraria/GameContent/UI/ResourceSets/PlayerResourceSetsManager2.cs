using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x020006AD RID: 1709
	[global::Cpp2ILInjected.Token(Token = "0x2000A83")]
	public class PlayerResourceSetsManager2 : SelectionHolder<IPlayerResourcesDisplaySet>
	{
		// Token: 0x06004362 RID: 17250 RVA: 0x0002E0D3 File Offset: 0x0002C2D3
		[global::Cpp2ILInjected.Token(Token = "0x6004F8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF024", Offset = "0x8FF024", Length = "0x5C")]
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

		// Token: 0x06004363 RID: 17251 RVA: 0x0002E0D6 File Offset: 0x0002C2D6
		[global::Cpp2ILInjected.Token(Token = "0x6004F90")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF080", Offset = "0x8FF080", Length = "0xB0")]
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

		// Token: 0x06004364 RID: 17252 RVA: 0x0002E0D9 File Offset: 0x0002C2D9
		[global::Cpp2ILInjected.Token(Token = "0x6004F91")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF130", Offset = "0x8FF130", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		protected override void PopulateOptionsAndLoadContent(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x0002E0DC File Offset: 0x0002C2DC
		[global::Cpp2ILInjected.Token(Token = "0x6004F92")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF3C8", Offset = "0x8FF3C8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void TryToHoverOverResources()
		{
			throw null;
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x0002E0DF File Offset: 0x0002C2DF
		[global::Cpp2ILInjected.Token(Token = "0x6004F93")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF464", Offset = "0x8FF464", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw()
		{
			throw null;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x0002E0E2 File Offset: 0x0002C2E2
		[global::Cpp2ILInjected.Token(Token = "0x6004F94")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF4FC", Offset = "0x8FF4FC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SelectionHolder<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PlayerResourceSetsManager2()
		{
			throw null;
		}
	}
}
