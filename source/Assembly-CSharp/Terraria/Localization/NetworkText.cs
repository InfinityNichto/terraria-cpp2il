using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat.Commands;
using Terraria.DataStructures;
using Terraria.GameContent.NetModules;
using Terraria.Initializers;
using Terraria.Net;

namespace Terraria.Localization
{
	// Token: 0x020003B8 RID: 952
	[global::Cpp2ILInjected.Token(Token = "0x200055B")]
	public class NetworkText
	{
		// Token: 0x06002EEC RID: 12012 RVA: 0x0002A617 File Offset: 0x00028817
		[global::Cpp2ILInjected.Token(Token = "0x6003351")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A6D4", Offset = "0x133A6D4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private NetworkText(string text, NetworkText.Mode mode)
		{
			throw null;
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x0002A61A File Offset: 0x0002881A
		[global::Cpp2ILInjected.Token(Token = "0x6003352")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A704", Offset = "0x133A704", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "FromFormattable", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "FromKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static NetworkText[] ConvertSubstitutionsToNetworkText(object[] substitutions)
		{
			throw null;
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x0002A61D File Offset: 0x0002881D
		[global::Cpp2ILInjected.Token(Token = "0x6003353")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A88C", Offset = "0x133A88C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "greetPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "PrepareAliases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HelpCommand), Member = "ComposeMessage", MemberParameters = new object[] { typeof(Dictionary<string, List<LocalizedText>>) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RollCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "ConvertSubstitutionsToNetworkText", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(NetworkText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static NetworkText FromFormattable(string text, params object[] substitutions)
		{
			throw null;
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x0002A620 File Offset: 0x00028820
		[global::Cpp2ILInjected.Token(Token = "0x6003354")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A82C", Offset = "0x133A82C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "TrySyncingMyPlayer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendAnglerQuest", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "greetPlayer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetGivenNetName", ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "CreateDeathMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "ConvertSubstitutionsToNetworkText", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(NetworkText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDeathReason), Member = "GetDeathText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ListPlayersCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PartyChatCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SayChatCommand), Member = "ProcessIncomingMessage", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static NetworkText FromLiteral(string text)
		{
			throw null;
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x0002A623 File Offset: 0x00028823
		[global::Cpp2ILInjected.Token(Token = "0x6003355")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A414", Offset = "0x133A414", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 117)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "ConvertSubstitutionsToNetworkText", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(NetworkText[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static NetworkText FromKey(string key, params object[] substitutions)
		{
			throw null;
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x0002A626 File Offset: 0x00028826
		[global::Cpp2ILInjected.Token(Token = "0x6003356")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A918", Offset = "0x133A918", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "GetMaxSerializedSize", ReturnType = typeof(int))]
		public int GetMaxSerializedSize()
		{
			throw null;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x0002A629 File Offset: 0x00028829
		[global::Cpp2ILInjected.Token(Token = "0x6003357")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A998", Offset = "0x133A998", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "SerializeSubstitutionList", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "SerializeServerMessage", MemberParameters = new object[]
		{
			typeof(NetworkText),
			typeof(Color),
			typeof(byte)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x0002A62C File Offset: 0x0002882C
		[global::Cpp2ILInjected.Token(Token = "0x6003358")]
		[global::Cpp2ILInjected.Address(RVA = "0x133A9E8", Offset = "0x133A9E8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		private void SerializeSubstitutionList(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x0002A62F File Offset: 0x0002882F
		[global::Cpp2ILInjected.Token(Token = "0x6003359")]
		[global::Cpp2ILInjected.Address(RVA = "0x133AA58", Offset = "0x133AA58", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "DeserializeSubstitutionList", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTextModule), Member = "DeserializeAsClient", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "DeserializeSubstitutionList", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static NetworkText Deserialize(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x0002A632 File Offset: 0x00028832
		[global::Cpp2ILInjected.Token(Token = "0x600335A")]
		[global::Cpp2ILInjected.Address(RVA = "0x133AC00", Offset = "0x133AC00", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "DeserializeSubstitutionList", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static NetworkText DeserializeLiteral(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x0002A635 File Offset: 0x00028835
		[global::Cpp2ILInjected.Token(Token = "0x600335B")]
		[global::Cpp2ILInjected.Address(RVA = "0x133AAFC", Offset = "0x133AAFC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "Deserialize", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "DeserializeLiteral", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "Deserialize", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void DeserializeSubstitutionList(BinaryReader reader)
		{
			throw null;
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x0002A638 File Offset: 0x00028838
		[global::Cpp2ILInjected.Token(Token = "0x600335C")]
		[global::Cpp2ILInjected.Address(RVA = "0x133ACE8", Offset = "0x133ACE8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetToEmptyLiteral()
		{
			throw null;
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x0002A63B File Offset: 0x0002883B
		[global::Cpp2ILInjected.Token(Token = "0x600335D")]
		[global::Cpp2ILInjected.Address(RVA = "0x133AD3C", Offset = "0x133AD3C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "ToDebugInfoString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x0002A63E File Offset: 0x0002883E
		[global::Cpp2ILInjected.Token(Token = "0x600335E")]
		[global::Cpp2ILInjected.Address(RVA = "0x133AEEC", Offset = "0x133AEEC", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkText), Member = "ToDebugInfoString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "ToDebugInfoString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private string ToDebugInfoString(string linePrefix = "")
		{
			throw null;
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x0002A641 File Offset: 0x00028841
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600335F")]
		[global::Cpp2ILInjected.Address(RVA = "0x133B0CC", Offset = "0x133B0CC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkText), Member = "FromLiteral", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NetworkText))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static NetworkText()
		{
			throw null;
		}

		// Token: 0x04003279 RID: 12921
		[global::Cpp2ILInjected.Token(Token = "0x4003C2A")]
		public static readonly NetworkText Empty;

		// Token: 0x0400327A RID: 12922
		[global::Cpp2ILInjected.Token(Token = "0x4003C2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private NetworkText[] _substitutions;

		// Token: 0x0400327B RID: 12923
		[global::Cpp2ILInjected.Token(Token = "0x4003C2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string _text;

		// Token: 0x0400327C RID: 12924
		[global::Cpp2ILInjected.Token(Token = "0x4003C2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private NetworkText.Mode _mode;

		// Token: 0x020008F3 RID: 2291
		[global::Cpp2ILInjected.Token(Token = "0x200055C")]
		private enum Mode : byte
		{
			// Token: 0x04008155 RID: 33109
			[global::Cpp2ILInjected.Token(Token = "0x4003C2F")]
			Literal,
			// Token: 0x04008156 RID: 33110
			[global::Cpp2ILInjected.Token(Token = "0x4003C30")]
			Formattable,
			// Token: 0x04008157 RID: 33111
			[global::Cpp2ILInjected.Token(Token = "0x4003C31")]
			LocalizationKey
		}
	}
}
