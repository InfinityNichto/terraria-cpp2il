using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Achievements;
using Terraria.GameInput;
using Terraria.Social.Base;

namespace Terraria.UI
{
	// Token: 0x020004C1 RID: 1217
	[global::Cpp2ILInjected.Token(Token = "0x20006E0")]
	public class InGameNotificationsTracker
	{
		// Token: 0x06003591 RID: 13713 RVA: 0x0002B93A File Offset: 0x00029B3A
		[global::Cpp2ILInjected.Token(Token = "0x6003B14")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A3AC", Offset = "0x147A3AC", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Achievements", ReturnType = typeof(AchievementManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Achievement.AchievementCompleted), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AchievementManager), Member = "add_OnAchievementCompleted", MemberParameters = new object[] { typeof(Achievement.AchievementCompleted) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "add_OnRequestAdded", MemberParameters = new object[] { typeof(ServerJoinRequestEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "add_OnRequestRemoved", MemberParameters = new object[] { typeof(ServerJoinRequestEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0002B93D File Offset: 0x00029B3D
		[global::Cpp2ILInjected.Token(Token = "0x6003B15")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A528", Offset = "0x147A528", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void JoinRequests_OnRequestAdded(UserJoinToServerRequest request)
		{
			throw null;
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0002B940 File Offset: 0x00029B40
		[global::Cpp2ILInjected.Token(Token = "0x6003B16")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A6AC", Offset = "0x147A6AC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void JoinRequests_OnRequestRemoved(UserJoinToServerRequest request)
		{
			throw null;
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x0002B943 File Offset: 0x00029B43
		[global::Cpp2ILInjected.Token(Token = "0x6003B17")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A82C", Offset = "0x147A82C", Length = "0x32C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_13_AchievementCompletePopups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "GetAnchoredPosition", MemberParameters = new object[]
		{
			typeof(ControlAnchor.ControlId),
			typeof(LayoutCalculator.AnchorType),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static void DrawInGame(SpriteBatch sb)
		{
			throw null;
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x0002B946 File Offset: 0x00029B46
		[global::Cpp2ILInjected.Token(Token = "0x6003B18")]
		[global::Cpp2ILInjected.Address(RVA = "0x147AB58", Offset = "0x147AB58", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void DrawInIngameOptions(SpriteBatch spriteBatch, Rectangle area, ref int gamepadPointIdLocalIndexToUse)
		{
			throw null;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x0002B949 File Offset: 0x00029B49
		[global::Cpp2ILInjected.Token(Token = "0x6003B19")]
		[global::Cpp2ILInjected.Address(RVA = "0x147ADAC", Offset = "0x147ADAC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = ".ctor", MemberParameters = new object[] { typeof(Achievement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void AddCompleted(Achievement achievement)
		{
			throw null;
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x0002B94C File Offset: 0x00029B4C
		[global::Cpp2ILInjected.Token(Token = "0x6003B1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x147A57C", Offset = "0x147A57C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = ".ctor", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void AddJoinRequest(UserJoinToServerRequest request)
		{
			throw null;
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x0002B94F File Offset: 0x00029B4F
		[global::Cpp2ILInjected.Token(Token = "0x6003B1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x147B138", Offset = "0x147B138", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateMenu", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Clear()
		{
			throw null;
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x0002B952 File Offset: 0x00029B52
		[global::Cpp2ILInjected.Token(Token = "0x6003B1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x147B1C8", Offset = "0x147B1C8", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0002B955 File Offset: 0x00029B55
		[global::Cpp2ILInjected.Token(Token = "0x6003B1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x147B3D0", Offset = "0x147B3D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public InGameNotificationsTracker()
		{
			throw null;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x0002B958 File Offset: 0x00029B58
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003B1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x147B3D8", Offset = "0x147B3D8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static InGameNotificationsTracker()
		{
			throw null;
		}

		// Token: 0x04006691 RID: 26257
		[global::Cpp2ILInjected.Token(Token = "0x4007AF3")]
		private static List<IInGameNotification> _notifications;
	}
}
