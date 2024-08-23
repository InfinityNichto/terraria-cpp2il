using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000646 RID: 1606
	[global::Cpp2ILInjected.Token(Token = "0x200096E")]
	public class NPCStatsReportInfoElement : IBestiaryInfoElement, IUpdateBeforeSorting
	{
		// Token: 0x06003F12 RID: 16146 RVA: 0x0002D425 File Offset: 0x0002B625
		[global::Cpp2ILInjected.Token(Token = "0x6004831")]
		[global::Cpp2ILInjected.Address(RVA = "0x819ADC", Offset = "0x819ADC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Enemy", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = "RefreshStats", MemberParameters = new object[]
		{
			typeof(GameModeData),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public NPCStatsReportInfoElement(int npcNetId)
		{
			throw null;
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06003F13 RID: 16147 RVA: 0x0002D428 File Offset: 0x0002B628
		// (remove) Token: 0x06003F14 RID: 16148 RVA: 0x0002D42B File Offset: 0x0002B62B
		[global::Cpp2ILInjected.Token(Token = "0x14000055")]
		public event NPCStatsReportInfoElement.StatAdjustmentStep OnRefreshStats
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004832")]
			[global::Cpp2ILInjected.Address(RVA = "0x82063C", Offset = "0x82063C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryDatabaseNPCsPopulator), Member = "ModifyEntriesThatNeedIt", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004833")]
			[global::Cpp2ILInjected.Address(RVA = "0x8206D8", Offset = "0x8206D8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x0002D42E File Offset: 0x0002B62E
		[global::Cpp2ILInjected.Token(Token = "0x6004834")]
		[global::Cpp2ILInjected.Address(RVA = "0x820774", Offset = "0x820774", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "RefreshSelectedStats", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = "RefreshStats", MemberParameters = new object[]
		{
			typeof(GameModeData),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Refresh()
		{
			throw null;
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x0002D431 File Offset: 0x0002B631
		[global::Cpp2ILInjected.Token(Token = "0x6004835")]
		[global::Cpp2ILInjected.Address(RVA = "0x820808", Offset = "0x820808", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = "RefreshStats", MemberParameters = new object[]
		{
			typeof(GameModeData),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void UpdateBeforeSorting()
		{
			throw null;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x0002D434 File Offset: 0x0002B634
		[global::Cpp2ILInjected.Token(Token = "0x6004836")]
		[global::Cpp2ILInjected.Address(RVA = "0x8205B4", Offset = "0x8205B4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "Refresh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "UpdateBeforeSorting", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCStatsReportInfoElement), Member = "ProvideUIElement", MemberParameters = new object[] { typeof(BestiaryUICollectionInfo) }, ReturnType = typeof(UIElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "SetDefaults", MemberParameters = new object[]
		{
			typeof(int),
			typeof(NPCSpawnParams)
		}, ReturnType = typeof(void))]
		private void RefreshStats(GameModeData gameModeFound, NPC instance)
		{
			throw null;
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x0002D437 File Offset: 0x0002B637
		[global::Cpp2ILInjected.Token(Token = "0x6004837")]
		[global::Cpp2ILInjected.Address(RVA = "0x82089C", Offset = "0x82089C", Length = "0x1434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCStatsReportInfoElement), Member = "RefreshStats", MemberParameters = new object[]
		{
			typeof(GameModeData),
			typeof(NPC)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIHorizontalSeparator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.ElementEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnUpdate", MemberParameters = new object[] { typeof(UIElement.ElementEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 75)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x0002D43A File Offset: 0x0002B63A
		[global::Cpp2ILInjected.Token(Token = "0x6004838")]
		[global::Cpp2ILInjected.Address(RVA = "0x821CD0", Offset = "0x821CD0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ShowStats_Attack(UIElement element)
		{
			throw null;
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x0002D43D File Offset: 0x0002B63D
		[global::Cpp2ILInjected.Token(Token = "0x6004839")]
		[global::Cpp2ILInjected.Address(RVA = "0x821D88", Offset = "0x821D88", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ShowStats_Defense(UIElement element)
		{
			throw null;
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x0002D440 File Offset: 0x0002B640
		[global::Cpp2ILInjected.Token(Token = "0x600483A")]
		[global::Cpp2ILInjected.Address(RVA = "0x821E40", Offset = "0x821E40", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ShowStats_Knockback(UIElement element)
		{
			throw null;
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x0002D443 File Offset: 0x0002B643
		[global::Cpp2ILInjected.Token(Token = "0x600483B")]
		[global::Cpp2ILInjected.Address(RVA = "0x821EF8", Offset = "0x821EF8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "MouseText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(byte),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ShowStats_Life(UIElement element)
		{
			throw null;
		}

		// Token: 0x04006C8C RID: 27788
		[global::Cpp2ILInjected.Token(Token = "0x40083B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int NpcId;

		// Token: 0x04006C8D RID: 27789
		[global::Cpp2ILInjected.Token(Token = "0x40083B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int Damage;

		// Token: 0x04006C8E RID: 27790
		[global::Cpp2ILInjected.Token(Token = "0x40083B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int LifeMax;

		// Token: 0x04006C8F RID: 27791
		[global::Cpp2ILInjected.Token(Token = "0x40083B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float MonetaryValue;

		// Token: 0x04006C90 RID: 27792
		[global::Cpp2ILInjected.Token(Token = "0x40083B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int Defense;

		// Token: 0x04006C91 RID: 27793
		[global::Cpp2ILInjected.Token(Token = "0x40083B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float KnockbackResist;

		// Token: 0x04006C92 RID: 27794
		[global::Cpp2ILInjected.Token(Token = "0x40083B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public NPC _instance;

		// Token: 0x04006C93 RID: 27795
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40083BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private NPCStatsReportInfoElement.StatAdjustmentStep OnRefreshStats;

		// Token: 0x02000A28 RID: 2600
		// (Invoke) Token: 0x06004FDD RID: 20445
		[global::Cpp2ILInjected.Token(Token = "0x200096F")]
		public delegate void StatAdjustmentStep(NPCStatsReportInfoElement element);
	}
}
