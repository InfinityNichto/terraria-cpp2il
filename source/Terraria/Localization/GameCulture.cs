using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Localization
{
	[global::Cpp2ILInjected.Token(Token = "0x2000551")]
	public class GameCulture
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000666")]
		public static GameCulture DefaultCulture
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60032F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x133533C", Offset = "0x133533C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60032F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1335394", Offset = "0x1335394", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000667")]
		public bool IsActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x13353F0", Offset = "0x13353F0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DropTombstone", MemberParameters = new object[]
			{
				typeof(long),
				typeof(NetworkText),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "LocalizedDuration", MemberParameters = new object[]
			{
				typeof(TimeSpan),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "get_ActiveCulture", ReturnType = typeof(GameCulture))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000668")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1335468", Offset = "0x1335468", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60032F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335478", Offset = "0x1335478", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DropTombstone", MemberParameters = new object[]
		{
			typeof(long),
			typeof(NetworkText),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "LocalizedDuration", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "ContainsKey", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static GameCulture FromCultureName(GameCulture.CultureName name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60032F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335584", Offset = "0x1335584", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static GameCulture FromLegacyId(int id)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60032FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335698", Offset = "0x1335698", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LanguageManager), Member = "SetLanguage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static GameCulture FromName(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60032FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335814", Offset = "0x1335814", Length = "0x424")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameCulture), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "Add", MemberParameters = new object[]
		{
			"System.Int32Enum",
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		static GameCulture()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60032FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335C38", Offset = "0x1335C38", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameCulture), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GameCulture(string name, int legacyId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60032FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1335CE8", Offset = "0x1335CE8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void RegisterLegacyCulture(GameCulture culture, int legacyId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003C05")]
		private static Dictionary<GameCulture.CultureName, GameCulture> _NamedCultures;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C06")]
		private static GameCulture <DefaultCulture>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4003C07")]
		private static Dictionary<int, GameCulture> _legacyCultures;

		[global::Cpp2ILInjected.Token(Token = "0x4003C08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly CultureInfo CultureInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4003C09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int LegacyId;

		[global::Cpp2ILInjected.Token(Token = "0x2000552")]
		public enum CultureName
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003C0B")]
			English = 1,
			[global::Cpp2ILInjected.Token(Token = "0x4003C0C")]
			German,
			[global::Cpp2ILInjected.Token(Token = "0x4003C0D")]
			Italian,
			[global::Cpp2ILInjected.Token(Token = "0x4003C0E")]
			French,
			[global::Cpp2ILInjected.Token(Token = "0x4003C0F")]
			Spanish,
			[global::Cpp2ILInjected.Token(Token = "0x4003C10")]
			Russian,
			[global::Cpp2ILInjected.Token(Token = "0x4003C11")]
			Chinese,
			[global::Cpp2ILInjected.Token(Token = "0x4003C12")]
			Portuguese,
			[global::Cpp2ILInjected.Token(Token = "0x4003C13")]
			Polish,
			[global::Cpp2ILInjected.Token(Token = "0x4003C14")]
			Japanese,
			[global::Cpp2ILInjected.Token(Token = "0x4003C15")]
			Korean,
			[global::Cpp2ILInjected.Token(Token = "0x4003C16")]
			ChineseTraditional,
			[global::Cpp2ILInjected.Token(Token = "0x4003C17")]
			Unknown = 9999
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000553")]
		private sealed class <>c__DisplayClass13_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60032FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x133580C", Offset = "0x133580C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60032FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1335DE4", Offset = "0x1335DE4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			internal bool <FromName>b__0(GameCulture culture)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4003C18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string name;
		}
	}
}
