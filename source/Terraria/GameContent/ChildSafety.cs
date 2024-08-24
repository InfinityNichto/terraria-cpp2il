using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;

namespace Terraria.GameContent
{
	// Token: 0x02000543 RID: 1347
	[global::Cpp2ILInjected.Token(Token = "0x20007B5")]
	public class ChildSafety
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x0002C46B File Offset: 0x0002A66B
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x0002C46E File Offset: 0x0002A66E
		[global::Cpp2ILInjected.Token(Token = "0x170007BB")]
		public static bool Disabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004050")]
			[global::Cpp2ILInjected.Address(RVA = "0x76D2C0", Offset = "0x76D2C0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUINPCDialogue), Member = "Option1Clicked", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "GetSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "KillMe", MemberParameters = new object[]
			{
				typeof(PlayerDeathReason),
				typeof(double),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004051")]
			[global::Cpp2ILInjected.Address(RVA = "0x76D30C", Offset = "0x76D30C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x0002C471 File Offset: 0x0002A671
		[global::Cpp2ILInjected.Token(Token = "0x6004052")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D35C", Offset = "0x76D35C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool DangerousGore(int id)
		{
			throw null;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x0002C474 File Offset: 0x0002A674
		[global::Cpp2ILInjected.Token(Token = "0x6004053")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D3C8", Offset = "0x76D3C8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool DangerousDust(int id)
		{
			throw null;
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x0002C477 File Offset: 0x0002A677
		[global::Cpp2ILInjected.Token(Token = "0x6004054")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D434", Offset = "0x76D434", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ChildSafety()
		{
			throw null;
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0002C47A File Offset: 0x0002A67A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004055")]
		[global::Cpp2ILInjected.Address(RVA = "0x76D43C", Offset = "0x76D43C", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		static ChildSafety()
		{
			throw null;
		}

		// Token: 0x040068C7 RID: 26823
		[global::Cpp2ILInjected.Token(Token = "0x4007E18")]
		private static SetFactory factoryDust;

		// Token: 0x040068C8 RID: 26824
		[global::Cpp2ILInjected.Token(Token = "0x4007E19")]
		private static SetFactory factoryGore;

		// Token: 0x040068C9 RID: 26825
		[global::Cpp2ILInjected.Token(Token = "0x4007E1A")]
		private static readonly bool[] SafeGore;

		// Token: 0x040068CA RID: 26826
		[global::Cpp2ILInjected.Token(Token = "0x4007E1B")]
		private static readonly bool[] SafeDust;
	}
}
