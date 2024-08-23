using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI.BigProgressBar;

// Token: 0x0200012F RID: 303
[global::Cpp2ILInjected.Token(Token = "0x20001AA")]
public static class BottomCentreHUDAnchorUpdator
{
	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000A69 RID: 2665 RVA: 0x00023A80 File Offset: 0x00021C80
	// (set) Token: 0x06000A6A RID: 2666 RVA: 0x00023A83 File Offset: 0x00021C83
	[global::Cpp2ILInjected.Token(Token = "0x17000124")]
	private static int BottomCentreHUDUpdateFrame
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B78")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AECB8", Offset = "0x9AECB8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000B79")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AED04", Offset = "0x9AED04", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00023A86 File Offset: 0x00021C86
	[global::Cpp2ILInjected.Token(Token = "0x6000B7A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AED54", Offset = "0x9AED54", Length = "0x5C0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControlAnchor), Member = "GetControlRegion", MemberParameters = new object[] { typeof(ControlAnchor.ControlId) }, ReturnType = typeof(Rectangle))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
	{
		typeof(ControlAnchor.ControlId),
		typeof(LayoutCalculator.AnchorType),
		typeof(Vector2)
	}, ReturnType = typeof(Vector2))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = "get_AnyControllerConnected", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_UsingTouchUI", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_BigBossProgressBar", ReturnType = typeof(BigProgressBarSystem))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigProgressBarSystem), Member = "IsTracking", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPageIcons), Member = "get_DisplayTouchOptions", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
	public static void Update()
	{
		throw null;
	}
}
