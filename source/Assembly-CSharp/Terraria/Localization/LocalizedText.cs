using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Chat.Commands;

namespace Terraria.Localization
{
	// Token: 0x020003B7 RID: 951
	[global::Cpp2ILInjected.Token(Token = "0x2000559")]
	public class LocalizedText
	{
		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x0002A5E7 File Offset: 0x000287E7
		// (set) Token: 0x06002EDD RID: 11997 RVA: 0x0002A5EA File Offset: 0x000287EA
		[global::Cpp2ILInjected.Token(Token = "0x1700066B")]
		public string Value
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600333F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1339EAC", Offset = "0x1339EAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003340")]
			[global::Cpp2ILInjected.Address(RVA = "0x1339EB4", Offset = "0x1339EB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x0002A5ED File Offset: 0x000287ED
		[global::Cpp2ILInjected.Token(Token = "0x6003341")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339590", Offset = "0x1339590", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal LocalizedText(string key, string text)
		{
			throw null;
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x0002A5F0 File Offset: 0x000287F0
		[global::Cpp2ILInjected.Token(Token = "0x6003342")]
		[global::Cpp2ILInjected.Address(RVA = "0x133851C", Offset = "0x133851C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetValue(string text)
		{
			throw null;
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x0002A5F3 File Offset: 0x000287F3
		[global::Cpp2ILInjected.Token(Token = "0x6003343")]
		[global::Cpp2ILInjected.Address(RVA = "0x133672C", Offset = "0x133672C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "GenerateName", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HelpText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetChat", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "HasLuckTextForWizard", MemberParameters = new object[] { typeof(ref string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpecialEventTextIfNotEmpty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DyeTraderQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestCountChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderHelpText", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BartenderChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "GolferChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BestiaryGirlChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "PrincessChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CatChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "DogChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "BunnyChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "SlimeChat", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Language), Member = "GetTextValueWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.GameTipsDisplay.GameTip", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(double)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchEvaluator), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(MatchEvaluator)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public string FormatWith(object obj)
		{
			throw null;
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x0002A5F6 File Offset: 0x000287F6
		[global::Cpp2ILInjected.Token(Token = "0x6003344")]
		[global::Cpp2ILInjected.Address(RVA = "0x13368D0", Offset = "0x13368D0", Length = "0x3B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public StringBuilder FormatWith(object obj, StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x0002A5F9 File Offset: 0x000287F9
		[global::Cpp2ILInjected.Token(Token = "0x6003345")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339EC4", Offset = "0x1339EC4", Length = "0x49C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HelpText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Lang.<>c__DisplayClass48_0", Member = "<CreateDialogFilter>b__0", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LocalizedText)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Matches", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MatchCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MatchCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public bool CanFormatWith(object obj)
		{
			throw null;
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x0002A5FC File Offset: 0x000287FC
		[global::Cpp2ILInjected.Token(Token = "0x6003346")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A360", Offset = "0x133A360", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartNight", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateTime_StartDay", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "greetPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnSkeletron", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "SpawnBoss", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RemoteClient), Member = "CheckSection", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HelpCommand), Member = "ComposeMessage", MemberParameters = new object[] { typeof(Dictionary<string, List<LocalizedText>>) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartyChatCommand), Member = "SendNoTeamError", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RollCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public NetworkText ToNetworkText()
		{
			throw null;
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x0002A5FF File Offset: 0x000287FF
		[global::Cpp2ILInjected.Token(Token = "0x6003347")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A4A0", Offset = "0x133A4A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public NetworkText ToNetworkText(params object[] substitutions)
		{
			throw null;
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x0002A602 File Offset: 0x00028802
		[global::Cpp2ILInjected.Token(Token = "0x6003348")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A508", Offset = "0x133A508", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static explicit operator string(LocalizedText text)
		{
			throw null;
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x0002A605 File Offset: 0x00028805
		[global::Cpp2ILInjected.Token(Token = "0x6003349")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339D1C", Offset = "0x1339D1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SyncOnePlayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UnspawnTravelNPC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		public string Format(object arg0)
		{
			throw null;
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x0002A608 File Offset: 0x00028808
		[global::Cpp2ILInjected.Token(Token = "0x600334A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339D28", Offset = "0x1339D28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		public string Format(object arg0, object arg1)
		{
			throw null;
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x0002A60B File Offset: 0x0002880B
		[global::Cpp2ILInjected.Token(Token = "0x600334B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339D34", Offset = "0x1339D34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		public string Format(object arg0, object arg1, object arg2)
		{
			throw null;
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x0002A60E File Offset: 0x0002880E
		[global::Cpp2ILInjected.Token(Token = "0x600334C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1339D40", Offset = "0x1339D40", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		public string Format(params object[] args)
		{
			throw null;
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x0002A611 File Offset: 0x00028811
		[global::Cpp2ILInjected.Token(Token = "0x600334D")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A510", Offset = "0x133A510", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x0002A614 File Offset: 0x00028814
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600334E")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A518", Offset = "0x133A518", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static LocalizedText()
		{
			throw null;
		}

		// Token: 0x04003275 RID: 12917
		[global::Cpp2ILInjected.Token(Token = "0x4003C24")]
		public static readonly LocalizedText Empty;

		// Token: 0x04003276 RID: 12918
		[global::Cpp2ILInjected.Token(Token = "0x4003C25")]
		private static Regex _substitutionRegex;

		// Token: 0x04003277 RID: 12919
		[global::Cpp2ILInjected.Token(Token = "0x4003C26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string Key;

		// Token: 0x04003278 RID: 12920
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <Value>k__BackingField;

		// Token: 0x020008F2 RID: 2290
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200055A")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06004C0E RID: 19470 RVA: 0x0002F75F File Offset: 0x0002D95F
			[global::Cpp2ILInjected.Token(Token = "0x600334F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1339EBC", Offset = "0x1339EBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			// Token: 0x06004C0F RID: 19471 RVA: 0x0002F762 File Offset: 0x0002D962
			[global::Cpp2ILInjected.Token(Token = "0x6003350")]
			[global::Cpp2ILInjected.Address(RVA = "0x133A5E8", Offset = "0x133A5E8", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal string <FormatWith>b__0(Match match)
			{
				throw null;
			}

			// Token: 0x04008152 RID: 33106
			[global::Cpp2ILInjected.Token(Token = "0x4003C28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public PropertyDescriptorCollection properties;

			// Token: 0x04008153 RID: 33107
			[global::Cpp2ILInjected.Token(Token = "0x4003C29")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public object obj;
		}
	}
}
