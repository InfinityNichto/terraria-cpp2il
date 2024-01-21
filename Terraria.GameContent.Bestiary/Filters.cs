using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000619")]
public static class Filters
{
	[Cpp2IlInjected.Token(Token = "0x2000A0B")]
	public class BySearch : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>, ISearchFilter<BestiaryEntry>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D69")]
		private string _search;

		[Cpp2IlInjected.Token(Token = "0x170008D1")]
		public bool? ForcedDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6004FC1")]
			[Cpp2IlInjected.Address(RVA = "0x10FBFB4", Offset = "0x10FBFB4", VA = "0x10FBFB4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC2")]
		[Cpp2IlInjected.Address(RVA = "0x10FC024", Offset = "0x10FC024", VA = "0x10FC024")]
		public BySearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC3")]
		[Cpp2IlInjected.Address(RVA = "0x10FC02C", Offset = "0x10FC02C", VA = "0x10FC02C", Slot = "5")]
		public bool FitsFilter(BestiaryEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC4")]
		[Cpp2IlInjected.Address(RVA = "0x10FC20C", Offset = "0x10FC20C", VA = "0x10FC20C", Slot = "6")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC5")]
		[Cpp2IlInjected.Address(RVA = "0x10FC25C", Offset = "0x10FC25C", VA = "0x10FC25C", Slot = "7")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC6")]
		[Cpp2IlInjected.Address(RVA = "0x10FC424", Offset = "0x10FC424", VA = "0x10FC424", Slot = "8")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC7")]
		[Cpp2IlInjected.Address(RVA = "0x10FC5C0", Offset = "0x10FC5C0", VA = "0x10FC5C0", Slot = "9")]
		public void SetSearch(string searchText)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A0C")]
	public class ByUnlockState : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x4008D6A")]
		private const int framesPerRow = 16;

		[Cpp2IlInjected.Token(Token = "0x4008D6B")]
		private const int framesPerColumn = 5;

		[Cpp2IlInjected.Token(Token = "0x170008D2")]
		public bool? ForcedDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6004FC8")]
			[Cpp2IlInjected.Address(RVA = "0x10FC5C8", Offset = "0x10FC5C8", VA = "0x10FC5C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FC9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC638", Offset = "0x10FC638", VA = "0x10FC638", Slot = "5")]
		public bool FitsFilter(BestiaryEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCA")]
		[Cpp2IlInjected.Address(RVA = "0x10FC790", Offset = "0x10FC790", VA = "0x10FC790", Slot = "6")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCB")]
		[Cpp2IlInjected.Address(RVA = "0x10FC7E0", Offset = "0x10FC7E0", VA = "0x10FC7E0", Slot = "7")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCC")]
		[Cpp2IlInjected.Address(RVA = "0x10FC9AC", Offset = "0x10FC9AC", VA = "0x10FC9AC", Slot = "8")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCD")]
		[Cpp2IlInjected.Address(RVA = "0x10FCB50", Offset = "0x10FCB50", VA = "0x10FCB50")]
		public ByUnlockState()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A0D")]
	public class ByRareCreature : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x170008D3")]
		public bool? ForcedDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6004FCE")]
			[Cpp2IlInjected.Address(RVA = "0x10FBB1C", Offset = "0x10FBB1C", VA = "0x10FBB1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FCF")]
		[Cpp2IlInjected.Address(RVA = "0x10FBB24", Offset = "0x10FBB24", VA = "0x10FBB24", Slot = "5")]
		public bool FitsFilter(BestiaryEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD0")]
		[Cpp2IlInjected.Address(RVA = "0x10FBBF8", Offset = "0x10FBBF8", VA = "0x10FBBF8", Slot = "6")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD1")]
		[Cpp2IlInjected.Address(RVA = "0x10FBC48", Offset = "0x10FBC48", VA = "0x10FBC48", Slot = "7")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD2")]
		[Cpp2IlInjected.Address(RVA = "0x10FBE10", Offset = "0x10FBE10", VA = "0x10FBE10", Slot = "8")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD3")]
		[Cpp2IlInjected.Address(RVA = "0x10FBFAC", Offset = "0x10FBFAC", VA = "0x10FBFAC")]
		public ByRareCreature()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A0E")]
	public class ByBoss : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x4008D6C")]
		private const int framesPerRow = 16;

		[Cpp2IlInjected.Token(Token = "0x4008D6D")]
		private const int framesPerColumn = 5;

		[Cpp2IlInjected.Token(Token = "0x170008D4")]
		public bool? ForcedDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6004FD4")]
			[Cpp2IlInjected.Address(RVA = "0x10FB33C", Offset = "0x10FB33C", VA = "0x10FB33C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD5")]
		[Cpp2IlInjected.Address(RVA = "0x10FB344", Offset = "0x10FB344", VA = "0x10FB344", Slot = "5")]
		public bool FitsFilter(BestiaryEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD6")]
		[Cpp2IlInjected.Address(RVA = "0x10FB418", Offset = "0x10FB418", VA = "0x10FB418", Slot = "6")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD7")]
		[Cpp2IlInjected.Address(RVA = "0x10FB468", Offset = "0x10FB468", VA = "0x10FB468", Slot = "7")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD8")]
		[Cpp2IlInjected.Address(RVA = "0x10FB634", Offset = "0x10FB634", VA = "0x10FB634", Slot = "8")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FD9")]
		[Cpp2IlInjected.Address(RVA = "0x10FB7D8", Offset = "0x10FB7D8", VA = "0x10FB7D8")]
		public ByBoss()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000A0F")]
	public class ByInfoElement : IBestiaryEntryFilter, IEntryFilter<BestiaryEntry>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008D6E")]
		private IBestiaryInfoElement _element;

		[Cpp2IlInjected.Token(Token = "0x170008D5")]
		public bool? ForcedDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x6004FDA")]
			[Cpp2IlInjected.Address(RVA = "0x10FB7E0", Offset = "0x10FB7E0", VA = "0x10FB7E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6004FDB")]
		[Cpp2IlInjected.Address(RVA = "0x10FB7E8", Offset = "0x10FB7E8", VA = "0x10FB7E8")]
		public ByInfoElement(IBestiaryInfoElement element)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004FDC")]
		[Cpp2IlInjected.Address(RVA = "0x10FB808", Offset = "0x10FB808", VA = "0x10FB808", Slot = "5")]
		public bool FitsFilter(BestiaryEntry entry)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6004FDD")]
		[Cpp2IlInjected.Address(RVA = "0x10FB86C", Offset = "0x10FB86C", VA = "0x10FB86C", Slot = "6")]
		public string GetDisplayNameKey()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FDE")]
		[Cpp2IlInjected.Address(RVA = "0x10FB948", Offset = "0x10FB948", VA = "0x10FB948", Slot = "7")]
		public UIElement GetImage()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004FDF")]
		[Cpp2IlInjected.Address(RVA = "0x10FBA24", Offset = "0x10FBA24", VA = "0x10FBA24", Slot = "8")]
		public void GetDisplay(out Texture2D texture, out Rectangle frame)
		{
		}
	}
}
