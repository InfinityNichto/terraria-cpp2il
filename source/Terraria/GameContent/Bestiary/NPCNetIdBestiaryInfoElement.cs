using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000968")]
	public class NPCNetIdBestiaryInfoElement : IBestiaryInfoElement, IBestiaryEntryDisplayIndex
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700082C")]
		public int NetId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600481C")]
			[global::Cpp2ILInjected.Address(RVA = "0x81EA50", Offset = "0x81EA50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600481D")]
			[global::Cpp2ILInjected.Address(RVA = "0x81EA58", Offset = "0x81EA58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600481E")]
		[global::Cpp2ILInjected.Address(RVA = "0x819990", Offset = "0x819990", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCNetIdBestiaryInfoElement(int npcNetId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600481F")]
		[global::Cpp2ILInjected.Address(RVA = "0x81EA60", Offset = "0x81EA60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700082D")]
		public int BestiaryDisplayIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004820")]
			[global::Cpp2ILInjected.Address(RVA = "0x81EA68", Offset = "0x81EA68", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40083AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <NetId>k__BackingField;
	}
}
